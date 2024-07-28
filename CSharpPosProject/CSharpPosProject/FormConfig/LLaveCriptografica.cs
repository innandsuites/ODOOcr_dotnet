﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpPosProject.Formularios
{
    public partial class LLaveCriptografica : Form
    {
        public LLaveCriptografica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            //openFileDialog1.Filter = ".p12";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;
            if( openFileDialog1.ShowDialog() != DialogResult.OK ) { return; }
            string selectedFileName = openFileDialog1.FileName;
            textBox1.Text = selectedFileName;
        }
    }
}
