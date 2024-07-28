using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPosProject.odoo
{
    public class Test2
    {
        public List<string> callPy()
        {
            var process = new Process();
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            //process.StartInfo.WorkingDirectory = @"C:\test\";
            process.StartInfo.FileName = "C:\\Users\\daniel\\AppData\\Local\\Microsoft\\WindowsApps\\python.exe";
            process.StartInfo.Arguments = "C:\\Users\\daniel\\GitHub\\Facturador-Desktop\\test.py";

            process.Start();
            var output = new List<string>();

            while (process.StandardOutput.Peek() > -1)
            {
                output.Add(process.StandardOutput.ReadLine());
            }

            
            process.WaitForExit();
            return output;
        }
    }
}
