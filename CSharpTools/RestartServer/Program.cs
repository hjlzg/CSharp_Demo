using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace RestartServer
{
    class Program
    {
        static string configPath = AppDomain.CurrentDomain.BaseDirectory + @"appConfig.json";
        static bool isFirstRun = true;

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var exePath = Readjson("path", configPath);
            var time = Convert.ToInt32(Readjson("time", configPath));
            while (true)
            {
                DateTime tm = DateTime.Now;
                string fileName = Path.GetFileNameWithoutExtension(exePath);
                if (isFirstRun || ((tm.Hour == time) && tm.Minute < 1))
                {
                    isFirstRun = false;
                    foreach (Process p in Process.GetProcesses())
                    {
                        if (p.ProcessName == fileName)
                        {
                            p.Kill();
                        }
                    }
                    Console.WriteLine($"{DateTime.Now} 开始重启");
                    RestartExe(exePath);
                    Console.WriteLine($"{DateTime.Now} 重启结束....");
                }
                Thread.Sleep(60000);
            }
        }

        /// <summary>
        /// 读取JSON文件
        /// </summary>
        /// <param name="key">JSON文件中的key值</param>
        /// <returns>JSON文件中的value值</returns>
        public static string Readjson(string key, string jsonfile)
        {
            using (StreamReader file = File.OpenText(jsonfile))
            {
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o = (JObject)JToken.ReadFrom(reader);
                    var value = o[key].ToString();
                    return value;
                }
            }
        }

        /// <summary>
        /// 重启EXE 程序
        /// </summary>
        /// <param name="path"></param>
        public static void RestartExe(string path)
        {
            using (Process process=new Process())
            {
                process.StartInfo.FileName = path;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardInput = true;

                process.Start();

                //process.WaitForExit(10000); //等待五分钟
            }
        }
    }
}
