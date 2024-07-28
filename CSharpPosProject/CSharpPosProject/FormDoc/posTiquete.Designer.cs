namespace CSharpPosProject.FormDoc
{
    partial class posTiquete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelTot = new System.Windows.Forms.Label();
            this.textBoxTot = new System.Windows.Forms.TextBox();
            this.textBoxCan = new System.Windows.Forms.TextBox();
            this.labelCan = new System.Windows.Forms.Label();
            this.buttonEli = new System.Windows.Forms.Button();
            this.buttonAgr = new System.Windows.Forms.Button();
            this.dataGridViewPos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.labelCod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTot
            // 
            this.labelTot.AutoSize = true;
            this.labelTot.Location = new System.Drawing.Point(506, 420);
            this.labelTot.Name = "labelTot";
            this.labelTot.Size = new System.Drawing.Size(31, 13);
            this.labelTot.TabIndex = 17;
            this.labelTot.Text = "Total";
            // 
            // textBoxTot
            // 
            this.textBoxTot.Location = new System.Drawing.Point(559, 417);
            this.textBoxTot.Name = "textBoxTot";
            this.textBoxTot.Size = new System.Drawing.Size(100, 20);
            this.textBoxTot.TabIndex = 16;
            // 
            // textBoxCan
            // 
            this.textBoxCan.Location = new System.Drawing.Point(308, 137);
            this.textBoxCan.Name = "textBoxCan";
            this.textBoxCan.Size = new System.Drawing.Size(122, 20);
            this.textBoxCan.TabIndex = 15;
            // 
            // labelCan
            // 
            this.labelCan.AutoSize = true;
            this.labelCan.Location = new System.Drawing.Point(241, 140);
            this.labelCan.Name = "labelCan";
            this.labelCan.Size = new System.Drawing.Size(49, 13);
            this.labelCan.TabIndex = 14;
            this.labelCan.Text = "Cantidad";
            // 
            // buttonEli
            // 
            this.buttonEli.Location = new System.Drawing.Point(584, 137);
            this.buttonEli.Name = "buttonEli";
            this.buttonEli.Size = new System.Drawing.Size(103, 23);
            this.buttonEli.TabIndex = 13;
            this.buttonEli.Text = "eliminar";
            this.buttonEli.UseVisualStyleBackColor = true;
            this.buttonEli.Click += new System.EventHandler(this.buttonEli_Click);
            // 
            // buttonAgr
            // 
            this.buttonAgr.Location = new System.Drawing.Point(453, 137);
            this.buttonAgr.Name = "buttonAgr";
            this.buttonAgr.Size = new System.Drawing.Size(112, 23);
            this.buttonAgr.TabIndex = 12;
            this.buttonAgr.Text = "agregar";
            this.buttonAgr.UseVisualStyleBackColor = true;
            this.buttonAgr.Click += new System.EventHandler(this.buttonAgr_Click);
            // 
            // dataGridViewPos
            // 
            this.dataGridViewPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewPos.Location = new System.Drawing.Point(16, 285);
            this.dataGridViewPos.Name = "dataGridViewPos";
            this.dataGridViewPos.Size = new System.Drawing.Size(754, 103);
            this.dataGridViewPos.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod. Producto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(92, 137);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(122, 20);
            this.textBoxCod.TabIndex = 10;
            this.textBoxCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCod_KeyDown);
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Location = new System.Drawing.Point(13, 137);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(40, 13);
            this.labelCod.TabIndex = 9;
            this.labelCod.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fecha: ";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(50, 13);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(35, 13);
            this.lbFecha.TabIndex = 19;
            this.lbFecha.Text = "label2";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(199, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(400, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 24;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Colon";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(70, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Dolar";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(634, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(136, 50);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moneda";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(92, 100);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(507, 21);
            this.comboBox2.TabIndex = 27;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Servicios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Base Imp.";
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(122, 20);
            this.textBox1.TabIndex = 30;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(19, 202);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(580, 65);
            this.textBox2.TabIndex = 31;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // posTiquete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTot);
            this.Controls.Add(this.textBoxTot);
            this.Controls.Add(this.textBoxCan);
            this.Controls.Add(this.labelCan);
            this.Controls.Add(this.buttonEli);
            this.Controls.Add(this.buttonAgr);
            this.Controls.Add(this.dataGridViewPos);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.labelCod);
            this.Name = "posTiquete";
            this.Text = "posTiquete";
            this.Load += new System.EventHandler(this.posTiquete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTot;
        private System.Windows.Forms.TextBox textBoxTot;
        private System.Windows.Forms.TextBox textBoxCan;
        private System.Windows.Forms.Label labelCan;
        private System.Windows.Forms.Button buttonEli;
        private System.Windows.Forms.Button buttonAgr;
        private System.Windows.Forms.DataGridView dataGridViewPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}