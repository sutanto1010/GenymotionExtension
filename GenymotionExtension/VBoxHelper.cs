using System;
using System.Collections.Generic;
using System.Diagnostics;
using GenymotionExtension.Models;
using Syncfusion.Windows.Shared;

namespace GenymotionExtension
{
    public class VBoxHelper
    {
        private static string virtualBoxManage = @"C:\Program Files\Oracle\VirtualBox\";

        public static String GetCommandResult(String args)
        {
            Process VBoxManage = new Process();
            VBoxManage.StartInfo.CreateNoWindow = true;
            VBoxManage.StartInfo.FileName = virtualBoxManage + "VBoxManage.exe";
            VBoxManage.StartInfo.WorkingDirectory = virtualBoxManage;
            VBoxManage.StartInfo.Arguments = args;
            VBoxManage.StartInfo.UseShellExecute = false;
            VBoxManage.StartInfo.RedirectStandardOutput = true;
            VBoxManage.Start();
            String line = "";
            while (!VBoxManage.StandardOutput.EndOfStream)
            {
                line = VBoxManage.StandardOutput.ReadToEnd();
            }

            return line;
        }

        public static IList<VirtualDevice> GetVirtualDevices()
        {
            var devices = new List<VirtualDevice>();
            var temp = VBoxHelper.GetCommandResult("list vms");
            temp = temp.Replace("\r\n","\n").Replace("\"","");
            var lines = temp.Split('\n');
            foreach (var line in lines)
            {
                if(line.IsNullOrWhiteSpace())
                    continue;
                var idIndex = line.IndexOf("{");
                var id = Guid.Parse(line.Substring(idIndex));
                var name = line.Substring(0, idIndex-1);
                devices.Add(new VirtualDevice(){Id = id, Name = name});
            }
            return devices;
        }
    }
}
