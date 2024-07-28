namespace CSharpPosProject.Formularios
{
    partial class pos
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
            this.labelCod = new System.Windows.Forms.Label();
            this.textBoxCod = new System.Windows.Forms.TextBox();
            this.dataGridViewPos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAgr = new System.Windows.Forms.Button();
            this.buttonEli = new System.Windows.Forms.Button();
            this.labelCan = new System.Windows.Forms.Label();
            this.textBoxCan = new System.Windows.Forms.TextBox();
            this.textBoxTot = new System.Windows.Forms.TextBox();
            this.labelTot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCod
            // 
            this.labelCod.AutoSize = true;
            this.labelCod.Location = new System.Drawing.Point(26, 20);
            this.labelCod.Name = "labelCod";
            this.labelCod.Size = new System.Drawing.Size(40, 13);
            this.labelCod.TabIndex = 0;
            this.labelCod.Text = "Codigo";
            // 
            // textBoxCod
            // 
            this.textBoxCod.Location = new System.Drawing.Point(104, 17);
            this.textBoxCod.Name = "textBoxCod";
            this.textBoxCod.Size = new System.Drawing.Size(122, 20);
            this.textBoxCod.TabIndex = 1;
            this.textBoxCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCod_KeyDown);

            // 
            // dataGridViewPos
            // 
            this.dataGridViewPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridViewPos.Location = new System.Drawing.Point(29, 100);
            this.dataGridViewPos.Name = "dataGridViewPos";
            this.dataGridViewPos.Size = new System.Drawing.Size(546, 178);
            this.dataGridViewPos.TabIndex = 2;
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
            // buttonAgr
            // 
            this.buttonAgr.Location = new System.Drawing.Point(232, 17);
            this.buttonAgr.Name = "buttonAgr";
            this.buttonAgr.Size = new System.Drawing.Size(112, 23);
            this.buttonAgr.TabIndex = 3;
            this.buttonAgr.Text = "agregar";
            this.buttonAgr.UseVisualStyleBackColor = true;
            this.buttonAgr.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEli
            // 
            this.buttonEli.Location = new System.Drawing.Point(350, 17);
            this.buttonEli.Name = "buttonEli";
            this.buttonEli.Size = new System.Drawing.Size(103, 23);
            this.buttonEli.TabIndex = 4;
            this.buttonEli.Text = "eliminar";
            this.buttonEli.UseVisualStyleBackColor = true;
            this.buttonEli.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelCan
            // 
            this.labelCan.AutoSize = true;
            this.labelCan.Location = new System.Drawing.Point(26, 60);
            this.labelCan.Name = "labelCan";
            this.labelCan.Size = new System.Drawing.Size(49, 13);
            this.labelCan.TabIndex = 5;
            this.labelCan.Text = "Cantidad";
            // 
            // textBoxCan
            // 
            this.textBoxCan.Location = new System.Drawing.Point(104, 57);
            this.textBoxCan.Name = "textBoxCan";
            this.textBoxCan.Size = new System.Drawing.Size(122, 20);
            this.textBoxCan.TabIndex = 6;
            this.textBoxCan.Text = "1";
            // 
            // textBoxTot
            // 
            this.textBoxTot.Location = new System.Drawing.Point(475, 297);
            this.textBoxTot.Name = "textBoxTot";
            this.textBoxTot.Size = new System.Drawing.Size(100, 20);
            this.textBoxTot.TabIndex = 7;
            // 
            // labelTot
            // 
            this.labelTot.AutoSize = true;
            this.labelTot.Location = new System.Drawing.Point(422, 300);
            this.labelTot.Name = "labelTot";
            this.labelTot.Size = new System.Drawing.Size(31, 13);
            this.labelTot.TabIndex = 8;
            this.labelTot.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 348);
            this.Controls.Add(this.labelTot);
            this.Controls.Add(this.textBoxTot);
            this.Controls.Add(this.textBoxCan);
            this.Controls.Add(this.labelCan);
            this.Controls.Add(this.buttonEli);
            this.Controls.Add(this.buttonAgr);
            this.Controls.Add(this.dataGridViewPos);
            this.Controls.Add(this.textBoxCod);
            this.Controls.Add(this.labelCod);
            this.Name = "Form1";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCod;
        private System.Windows.Forms.TextBox textBoxCod;
        private System.Windows.Forms.DataGridView dataGridViewPos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button buttonAgr;
        private System.Windows.Forms.Button buttonEli;
        private System.Windows.Forms.Label labelCan;
        private System.Windows.Forms.TextBox textBoxCan;
        private System.Windows.Forms.TextBox textBoxTot;
        private System.Windows.Forms.Label labelTot;
    }
}