using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPosProject.odoo
{
    public class Test
    {
         public string result;
        public string callPy()
        {
            var cmd = "C:\\Users\\daniel\\GitHub\\Facturador-Desktop\\test.py";
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "C:\\Users\\daniel\\AppData\\Local\\Microsoft\\WindowsApps\\python.exe",
                    Arguments = cmd,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                },
                EnableRaisingEvents = true
            };

            process.ErrorDataReceived += Process_OutputDataReceived;
            process.OutputDataReceived += Process_OutputDataReceived;

            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
            //result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            
            return result;
        }

        public void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            //result = e.Data;
            Console.WriteLine(e.Data);
        }
    }
}
    

