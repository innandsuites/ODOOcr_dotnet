using CSharpPosProject.Red;
using email;
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

namespace CSharpPosProject.emailFrm
{
    public partial class EmailFrm : Form
    {
        public EmailFrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendGridTest sg = new SendGridTest();
            sg.send();
            
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            //MSGraphTokenReq req = new MSGraphTokenReq();
            
            //Task<string> result =  req.getTokenAsync();
            string result = await LongOperation();
            textBox1.Text = result.ToString();
        }
        public async Task<string> LongOperation()
        {
            // Perform asynchronous tasks here
            MSGraphTokenReq req = new MSGraphTokenReq();
            
            string result = await req.getTokenAsync();
            return result.ToString();                                  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
