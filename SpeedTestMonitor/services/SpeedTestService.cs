using SpeedTestMonitor.model;
using System;
using System.Collections.Generic;
using System.Threading;
using Newtonsoft.Json;
using SpeedTestMonitor.util;

namespace SpeedTestMonitor.services
{
    class SpeedTestService
    {

        public static FormMain main;

        public static List<SpeedTest> results;
        public static bool newTest = false;

        public static bool monitor = false;
        public static bool running = false;

        private static DateTime sleepEnd;

        public static int hour = 0;
        public static int minutes = 2;

        public static long amountTests = 0;

        public static void startMonitorSpeedTest()
        {
            if (monitor)
            {
                return;
            }

            if (results == null)
            {
                results = new List<SpeedTest>();
            }

            Thread thread = new Thread(t =>
            {
                monitor = true;
                while (monitor)
                {
                    doSpeedTest();

                    if (hour > 0)
                    {
                        sleepEnd = DateTime.Now.AddMilliseconds(hour * minutes * 60 * 1000);
                        Thread.Sleep(hour * minutes * 60 * 1000);
                    } else
                    {
                        sleepEnd = DateTime.Now.AddMilliseconds(minutes * 60 * 1000);
                        Thread.Sleep(minutes * 60 * 1000);
                    }
                }
                
            })
            { IsBackground = true };
            thread.Start();
        }

        private static void doSpeedTest()
        {
            using (System.Diagnostics.Process pProcess = new System.Diagnostics.Process())
            {
                running = true;
                pProcess.StartInfo.FileName = @"C:\Users\SoldierJVX\source\repos\SpeedTestMonitor\SpeedTestMonitor\ookla-speedtest\speedtest.exe";
                pProcess.StartInfo.Arguments = "-f json"; //argument
                pProcess.StartInfo.UseShellExecute = false;
                pProcess.StartInfo.RedirectStandardOutput = true;
                pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                pProcess.StartInfo.CreateNoWindow = true; //not diplay a windows
                pProcess.Start();
                string result = pProcess.StandardOutput.ReadToEnd();//The output result


                if (result.Equals("") || result.Contains("error"))
                {
                    main.showMessage("Erro ao obter resultados do SpeedTest. Verifique sua conexão a internet!");

                    main.getBtnStartMonitor().Text = "Iniciar Monitoramento";
                    monitor = false;
                } else
                {
                    
                    SpeedTest speedTest = JsonConvert.DeserializeObject<SpeedTest>(result);
                    results.Add(speedTest);

                    double download = speedTest.download.bandwidth / 125000;
                    double upload = speedTest.upload.bandwidth / 125000;

                    DateTime localDate = DateTime.Now;

                    main.updateChart(Utils.valueInTwoSpaces(localDate.Hour) + ":" + Utils.valueInTwoSpaces(localDate.Minute), download, upload);

                    if(results.Count > 6)
                    {
                        main.removeOldInfo();
                    }

                    notifyUser(download, upload);

                    newTest = true;
                }

                running = false;
            }
        }

        private static void notifyUser(double download, double upload)
        {
            if (main.getChbDownload().Checked)
            {
                if (download < int.Parse(main.getTxtDownload().Value+""))
                {
                    main.getNotifyIcon().ShowBalloonTip(10, "Velocidade abaixo da configurada", download + " Mbps de Download", System.Windows.Forms.ToolTipIcon.Warning);
                }
            }

            if (main.getChbUpload().Checked)
            {
                if (upload < int.Parse(main.getTxtUpload().Value + ""))
                {
                    main.getNotifyIcon().ShowBalloonTip(10, "Velocidade abaixo da configurada", upload + " Mbps de Upload", System.Windows.Forms.ToolTipIcon.Warning);
                }
            }
        }

        internal static void stopMonitorSpeedTest()
        {
            monitor = false;
        }

        public static string getRemainToNextSpeedTest()
        {
            DateTime now = DateTime.Now;

            TimeSpan span = now - sleepEnd;

            return Utils.valueInTwoSpaces(Utils.removeNegative(span.Hours)) + ":" + Utils.valueInTwoSpaces(Utils.removeNegative(span.Minutes)) + ":" + Utils.valueInTwoSpaces(Utils.removeNegative(span.Seconds));
        }
    }
    
}
