using Newtonsoft.Json;
using SpeedTestMonitor.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTestMonitor.services
{
    class SaveService
    {

        public static List<SpeedTest> readSave()
        {
            checkSaveFolder();

            try
            {
                DateTime now = DateTime.Now;

                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/" + now.Day + "-" + now.Month + "-" + now.Year + ".json");
                //Read the first line of text
                String line = sr.ReadLine();

                List<SpeedTest> results = JsonConvert.DeserializeObject<List<SpeedTest>>(line);

                //close the file
                sr.Close();

                return results;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            return null;
        }

        public static bool saveSpeedTests(List<SpeedTest> results)
        {
            checkSaveFolder();

            String line;
            try
            {
                DateTime now = DateTime.Now;

                //Pass the file path and file name to the StreamReader constructor
                StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/"+ now.Day + "-" + now.Month + "-" + now.Year + ".json");

                sw.Write(JsonConvert.SerializeObject(results));
                //close the file
                sw.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            return false;

        }

        private static void checkSaveFolder()
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/SpeedTestMonitor"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/SpeedTestMonitor");
            }
        }
    }
}
