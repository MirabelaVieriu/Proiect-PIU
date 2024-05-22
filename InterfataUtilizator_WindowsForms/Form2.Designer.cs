namespace InterfataUtilizator_WindowsForms
{
    partial class Form2
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
            this.dgvLivezi = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.tbSuprafata = new System.Windows.Forms.TextBox();
            this.lblSuprafata = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErori = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btCauta = new System.Windows.Forms.Button();
            this.tbCauta = new System.Windows.Forms.TextBox();
            this.lblLivada = new System.Windows.Forms.Label();
            this.btStergere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivezi)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLivezi
            // 
            this.dgvLivezi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLivezi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivezi.Location = new System.Drawing.Point(57, 55);
            this.dgvLivezi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLivezi.Name = "dgvLivezi";
            this.dgvLivezi.RowHeadersWidth = 51;
            this.dgvLivezi.Size = new System.Drawing.Size(569, 245);
            this.dgvLivezi.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btStergere);
            this.panel1.Controls.Add(this.btnModifica);
            this.panel1.Controls.Add(this.btnAdauga);
            this.panel1.Controls.Add(this.tbSuprafata);
            this.panel1.Controls.Add(this.lblSuprafata);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Location = new System.Drawing.Point(836, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 397);
            this.panel1.TabIndex = 4;
            // 
            // btnModifica
            // 
            this.btnModifica.BackColor = System.Drawing.Color.PaleGreen;
            this.btnModifica.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifica.Location = new System.Drawing.Point(148, 215);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(94, 28);
            this.btnModifica.TabIndex = 7;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = false;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdauga.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(24, 215);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(100, 28);
            this.btnAdauga.TabIndex = 5;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // tbSuprafata
            // 
            this.tbSuprafata.Location = new System.Drawing.Point(24, 76);
            this.tbSuprafata.Margin = new System.Windows.Forms.Padding(4);
            this.tbSuprafata.Name = "tbSuprafata";
            this.tbSuprafata.Size = new System.Drawing.Size(132, 22);
            this.tbSuprafata.TabIndex = 6;
            // 
            // lblSuprafata
            // 
            this.lblSuprafata.AutoSize = true;
            this.lblSuprafata.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuprafata.Location = new System.Drawing.Point(19, 49);
            this.lblSuprafata.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuprafata.Name = "lblSuprafata";
            this.lblSuprafata.Size = new System.Drawing.Size(79, 19);
            this.lblSuprafata.TabIndex = 5;
            this.lblSuprafata.Text = "Suprafata";
            this.lblSuprafata.UseMnemonic = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(19, 119);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(73, 19);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id livada\r\n";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(23, 142);
            this.tbId.Margin = new System.Windows.Forms.Padding(4);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(132, 22);
            this.tbId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 486);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 5;
            // 
            // lblErori
            // 
            this.lblErori.AutoSize = true;
            this.lblErori.Location = new System.Drawing.Point(53, 532);
            this.lblErori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErori.Name = "lblErori";
            this.lblErori.Size = new System.Drawing.Size(0, 16);
            this.lblErori.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.pictureBox1.Image = global::InterfataUtilizator_WindowsForms.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btCauta);
            this.panel2.Controls.Add(this.tbCauta);
            this.panel2.Controls.Add(this.lblLivada);
            this.panel2.ForeColor = System.Drawing.Color.PaleGreen;
            this.panel2.Location = new System.Drawing.Point(104, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 135);
            this.panel2.TabIndex = 7;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.PaleGreen;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(128, 77);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 35);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btCauta
            // 
            this.btCauta.BackColor = System.Drawing.Color.PaleGreen;
            this.btCauta.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCauta.ForeColor = System.Drawing.Color.Black;
            this.btCauta.Location = new System.Drawing.Point(18, 77);
            this.btCauta.Name = "btCauta";
            this.btCauta.Size = new System.Drawing.Size(90, 35);
            this.btCauta.TabIndex = 8;
            this.btCauta.Text = "Cauta";
            this.btCauta.UseVisualStyleBackColor = false;
            this.btCauta.Click += new System.EventHandler(this.btCauta_Click);
            // 
            // tbCauta
            // 
            this.tbCauta.Location = new System.Drawing.Point(18, 35);
            this.tbCauta.Margin = new System.Windows.Forms.Padding(4);
            this.tbCauta.Name = "tbCauta";
            this.tbCauta.Size = new System.Drawing.Size(132, 22);
            this.tbCauta.TabIndex = 7;
            // 
            // lblLivada
            // 
            this.lblLivada.AutoSize = true;
            this.lblLivada.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLivada.ForeColor = System.Drawing.Color.Black;
            this.lblLivada.Location = new System.Drawing.Point(14, 12);
            this.lblLivada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLivada.Name = "lblLivada";
            this.lblLivada.Size = new System.Drawing.Size(73, 19);
            this.lblLivada.TabIndex = 6;
            this.lblLivada.Text = "Id livada\r\n";
            // 
            // btStergere
            // 
            this.btStergere.BackColor = System.Drawing.Color.PaleGreen;
            this.btStergere.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStergere.Location = new System.Drawing.Point(270, 215);
            this.btStergere.Name = "btStergere";
            this.btStergere.Size = new System.Drawing.Size(94, 28);
            this.btStergere.TabIndex = 8;
            this.btStergere.Text = "Sterge";
            this.btStergere.UseVisualStyleBackColor = false;
            this.btStergere.Click += new System.EventHandler(this.btStergere_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::InterfataUtilizator_WindowsForms.Properties.Resources.green1__1_1;
            this.ClientSize = new System.Drawing.Size(1295, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblErori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLivezi);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivezi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvLivezi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.TextBox tbSuprafata;
        private System.Windows.Forms.Label lblSuprafata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErori;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btCauta;
        private System.Windows.Forms.TextBox tbCauta;
        private System.Windows.Forms.Label lblLivada;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btStergere;
    }
}