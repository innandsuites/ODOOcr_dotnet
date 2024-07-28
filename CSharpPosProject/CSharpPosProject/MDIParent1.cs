using CSharpPosProject.emailFrm;
using CSharpPosProject.FormConfig;
using CSharpPosProject.FormDoc;
using CSharpPosProject.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CSharpPosProject
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void idpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("credencial.xml");
                XmlNodeList nodeList = doc.SelectNodes("/Credencial");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Guarde sus credenciales" + ex);
            }
            
            Idp idp = new Idp();
            idp.MdiParent = this;
            idp.Show();
        }

        private void tokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TokenFrm tk= new TokenFrm();
            tk.MdiParent = this;
            tk.Show();

        }

        private void actividadEconomicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActividadEconomicaFrm aef = new ActividadEconomicaFrm();
            aef.MdiParent = this;
            aef.Show();
        }

        private void llaveCriptograficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LLaveCriptografica key = new LLaveCriptografica();
            key.MdiParent = this;
            key.Show();
        }

        private void posOpenForm(object sender, EventArgs e)
        {
            pos p = new pos();
            p.MdiParent = this;
            p.Show();
        }

        private void baseDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseDatosFrm bdf = new BaseDatosFrm();
            bdf.MdiParent = this;
            bdf.Show();
        }

        private void buscarComprobanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarComprobantes bc = new BuscarComprobantes();
            bc.MdiParent = this;
            bc.Show();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdooConfigFrm oc = new OdooConfigFrm();
            oc.MdiParent = this;
            oc.Show();
        }

        private void plantilla1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            posTiquete pos = new posTiquete();
            pos.MdiParent = this;
            pos.Show();
        }

        private void cabysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CabysFrm c = new CabysFrm();
            c.MdiParent = this;
            c.Show();
        }

        private void configureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailFrm em  = new EmailFrm();
            em.MdiParent = this;
            em.Show();
        }
    }
}
