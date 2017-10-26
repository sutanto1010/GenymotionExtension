using System;
using System.Diagnostics;

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
    }
}
