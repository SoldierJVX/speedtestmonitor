using SpeedTestMonitor.model;
using SpeedTestMonitor.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedTestMonitor
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            SpeedTestService.main = this;
            monitorSpeedTest();
            checkStartup();
            loadSavedSpeedTests();
        }

        private void loadSavedSpeedTests()
        {

            List<SpeedTest> results = SaveService.readSave();

            if (results == null)
            {
                return;
            }

            SpeedTestService.results = results;

            fillChart();


        }

        private void checkStartup()
        {
            if (StartupService.isStartup())
            {
                chbStartup.Checked = true;
                chbStartup_CheckedChanged(null, null);
            }
        }

        delegate void SetTextCallback(string texto);

        private void monitorSpeedTest()
        {
            String msg = "Não está fazendo SpeedTest no momento.";

            Thread thread = new Thread(t =>
            {
                while (true)
                {
                    
                    if (SpeedTestService.running)
                    {
                        if (msg.StartsWith("SpeedTest em andamento"))
                        {
                            switch (msg)
                            {
                                case "SpeedTest em andamento.":
                                    msg = "SpeedTest em andamento..";
                                    break;
                                case "SpeedTest em andamento..":
                                    msg = "SpeedTest em andamento...";
                                    break;
                                case "SpeedTest em andamento...":
                                    msg = "SpeedTest em andamento.";
                                    break;
                            }
                        }
                        else
                        {
                            msg = "SpeedTest em andamento.";
                        }
                    }
                    else
                    {
                        if (SpeedTestService.monitor)
                        {
                            msg = "Não está fazendo SpeedTest no momento.\nPróximo monitoramento em " + SpeedTestService.getRemainToNextSpeedTest();
                        } else
                        {
                            msg = "Não está fazendo SpeedTest no momento.";
                        }
                        
                    }

                    this.lblStatus.Text = msg;
                    Thread.Sleep(1000); // 1 sec
                }

            })
            { IsBackground = true };
            thread.Start();
        }

        private void btnStartMonitor_Click(object sender, EventArgs e)
        {
            if(btnStartMonitor.Text == "Iniciar Monitoramento")
            {
                btnStartMonitor.Text = "Parar Monitoramento";
                SpeedTestService.startMonitorSpeedTest();
            } else
            {
                btnStartMonitor.Text = "Iniciar Monitoramento";
                SpeedTestService.stopMonitorSpeedTest();
            }

        }

        internal Button getBtnStartMonitor()
        {
            return btnStartMonitor;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            configChart();
            fillNotifyIcon();
        }

        internal void removeOldInfo()
        {
            chart1.Series["Download"].Points.RemoveAt(0);
            chart1.Series["Upload"].Points.RemoveAt(0);
        }

        private void fillNotifyIcon()
        {
            var contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(new MenuItem("Fechar", fechar_Click));

            notifyIcon.ContextMenu = contextMenu;
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        internal NumericUpDown getTxtDownload()
        {
            return txtDownload;
        }

        internal NotifyIcon getNotifyIcon()
        {
            return notifyIcon;
        }

        internal CheckBox getChbDownload()
        {
            return chbDownload;
        }

        internal CheckBox getChbUpload()
        {
            return chbUpload;
        }

        internal NumericUpDown getTxtUpload()
        {
            return txtUpload;
        }

        private void configChart()
        {
            chart1.Titles.Add("SpeedTest");
            chart1.Series["Download"].IsValueShownAsLabel = true;
            chart1.Series["Upload"].IsValueShownAsLabel = true;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
        }

        internal void showMessage(string v)
        {
            MessageBox.Show(v);
        }

        public void updateChart(string time, double download, double upload)
        {
            chart1.Series["Download"].Points.AddXY(time, download);
            chart1.Series["Upload"].Points.AddXY(time, upload);
            SpeedTestService.amountTests++;

            lblAmoutTests.Text = "Testes Realizados: " + SpeedTestService.amountTests;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por: SoldierJVX\n\nIcons made by Freepik from Flaticon");
        }

        private void chbDownload_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDownload.Checked)
            {
                txtDownload.Enabled = true;
            } else
            {
                txtDownload.Enabled = false;
            }
            
        }

        private void chbUpload_CheckedChanged(object sender, EventArgs e)
        {
            if (chbUpload.Checked)
            {
                txtUpload.Enabled = true;
            }
            else
            {
                txtUpload.Enabled = false;
            }
        }

        private void txtHour_ValueChanged(object sender, EventArgs e)
        {
            if (txtHour.Text.Equals(""))
            {
                SpeedTestService.hour = 0;
            }

            SpeedTestService.hour = int.Parse(txtHour.Value + "");
        }

        private void txtMinutes_ValueChanged(object sender, EventArgs e)
        {
            if (txtMinutes.Text.Equals(""))
            {
                SpeedTestService.minutes = 0;
            }

            SpeedTestService.minutes = int.Parse(txtMinutes.Value+"");
        }

        private void chbStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (chbStartup.Checked)
            {
                StartupService.setStartup();
            }
            else
            {
                StartupService.unsetStartup();
            }
        }
    }
}
