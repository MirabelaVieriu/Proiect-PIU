namespace InterfataUtilizator_WindowsForms
{
    partial class FormaPomi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblAn = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbvisin = new System.Windows.Forms.RadioButton();
            this.rbnuc = new System.Windows.Forms.RadioButton();
            this.rbgutui = new System.Windows.Forms.RadioButton();
            this.rbpiersic = new System.Windows.Forms.RadioButton();
            this.rbcais = new System.Windows.Forms.RadioButton();
            this.rbCires = new System.Windows.Forms.RadioButton();
            this.rbMar = new System.Windows.Forms.RadioButton();
            this.rbPrun = new System.Windows.Forms.RadioButton();
            this.rbPar = new System.Windows.Forms.RadioButton();
            this.lblErori = new System.Windows.Forms.Label();
            this.dgvPomi = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ckbVisin = new System.Windows.Forms.CheckBox();
            this.ckbNuc = new System.Windows.Forms.CheckBox();
            this.ckbGutui = new System.Windows.Forms.CheckBox();
            this.ckbPiersic = new System.Windows.Forms.CheckBox();
            this.ckbCais = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.ckbCires = new System.Windows.Forms.CheckBox();
            this.ckbPrun = new System.Windows.Forms.CheckBox();
            this.ckbPar = new System.Windows.Forms.CheckBox();
            this.ckbMar = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRaport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPomi)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnRaport);
            this.panel1.Controls.Add(this.btnAdauga);
            this.panel1.Controls.Add(this.lblAn);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblCantitate);
            this.panel1.Controls.Add(this.tbCantitate);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(776, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 422);
            this.panel1.TabIndex = 1;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdauga.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(29, 336);
            this.btnAdauga.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(112, 38);
            this.btnAdauga.TabIndex = 2;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAn.Location = new System.Drawing.Point(29, 249);
            this.lblAn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(116, 19);
            this.lblAn.TabIndex = 2;
            this.lblAn.Text = "Anul Plantarii";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(33, 276);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantitate.Location = new System.Drawing.Point(37, 177);
            this.lblCantitate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(78, 19);
            this.lblCantitate.TabIndex = 2;
            this.lblCantitate.Text = "Cantitate";
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(33, 204);
            this.tbCantitate.Margin = new System.Windows.Forms.Padding(4);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(155, 22);
            this.tbCantitate.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbvisin);
            this.groupBox1.Controls.Add(this.rbnuc);
            this.groupBox1.Controls.Add(this.rbgutui);
            this.groupBox1.Controls.Add(this.rbpiersic);
            this.groupBox1.Controls.Add(this.rbcais);
            this.groupBox1.Controls.Add(this.rbCires);
            this.groupBox1.Controls.Add(this.rbMar);
            this.groupBox1.Controls.Add(this.rbPrun);
            this.groupBox1.Controls.Add(this.rbPar);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(447, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tip";
            // 
            // rbvisin
            // 
            this.rbvisin.AutoSize = true;
            this.rbvisin.Location = new System.Drawing.Point(138, 53);
            this.rbvisin.Name = "rbvisin";
            this.rbvisin.Size = new System.Drawing.Size(66, 23);
            this.rbvisin.TabIndex = 8;
            this.rbvisin.TabStop = true;
            this.rbvisin.Text = "visin";
            this.rbvisin.UseVisualStyleBackColor = true;
            // 
            // rbnuc
            // 
            this.rbnuc.AutoSize = true;
            this.rbnuc.Location = new System.Drawing.Point(82, 53);
            this.rbnuc.Name = "rbnuc";
            this.rbnuc.Size = new System.Drawing.Size(56, 23);
            this.rbnuc.TabIndex = 7;
            this.rbnuc.TabStop = true;
            this.rbnuc.Text = "nuc";
            this.rbnuc.UseVisualStyleBackColor = true;
            // 
            // rbgutui
            // 
            this.rbgutui.AutoSize = true;
            this.rbgutui.Location = new System.Drawing.Point(7, 53);
            this.rbgutui.Name = "rbgutui";
            this.rbgutui.Size = new System.Drawing.Size(69, 23);
            this.rbgutui.TabIndex = 6;
            this.rbgutui.TabStop = true;
            this.rbgutui.Text = "gutui";
            this.rbgutui.UseVisualStyleBackColor = true;
            // 
            // rbpiersic
            // 
            this.rbpiersic.AutoSize = true;
            this.rbpiersic.Location = new System.Drawing.Point(351, 23);
            this.rbpiersic.Name = "rbpiersic";
            this.rbpiersic.Size = new System.Drawing.Size(82, 23);
            this.rbpiersic.TabIndex = 5;
            this.rbpiersic.TabStop = true;
            this.rbpiersic.Text = "piersic";
            this.rbpiersic.UseVisualStyleBackColor = true;
            // 
            // rbcais
            // 
            this.rbcais.AutoSize = true;
            this.rbcais.Location = new System.Drawing.Point(286, 23);
            this.rbcais.Name = "rbcais";
            this.rbcais.Size = new System.Drawing.Size(59, 23);
            this.rbcais.TabIndex = 4;
            this.rbcais.TabStop = true;
            this.rbcais.Text = "cais";
            this.rbcais.UseVisualStyleBackColor = true;
            // 
            // rbCires
            // 
            this.rbCires.AutoSize = true;
            this.rbCires.Location = new System.Drawing.Point(212, 23);
            this.rbCires.Margin = new System.Windows.Forms.Padding(4);
            this.rbCires.Name = "rbCires";
            this.rbCires.Size = new System.Drawing.Size(67, 23);
            this.rbCires.TabIndex = 3;
            this.rbCires.TabStop = true;
            this.rbCires.Text = "cires";
            this.rbCires.UseVisualStyleBackColor = true;
            // 
            // rbMar
            // 
            this.rbMar.AutoSize = true;
            this.rbMar.Location = new System.Drawing.Point(8, 23);
            this.rbMar.Margin = new System.Windows.Forms.Padding(4);
            this.rbMar.Name = "rbMar";
            this.rbMar.Size = new System.Drawing.Size(60, 23);
            this.rbMar.TabIndex = 0;
            this.rbMar.TabStop = true;
            this.rbMar.Text = "mar";
            this.rbMar.UseVisualStyleBackColor = true;
            // 
            // rbPrun
            // 
            this.rbPrun.AutoSize = true;
            this.rbPrun.Location = new System.Drawing.Point(139, 23);
            this.rbPrun.Margin = new System.Windows.Forms.Padding(4);
            this.rbPrun.Name = "rbPrun";
            this.rbPrun.Size = new System.Drawing.Size(65, 23);
            this.rbPrun.TabIndex = 2;
            this.rbPrun.TabStop = true;
            this.rbPrun.Text = "prun";
            this.rbPrun.UseVisualStyleBackColor = true;
            // 
            // rbPar
            // 
            this.rbPar.AutoSize = true;
            this.rbPar.Location = new System.Drawing.Point(76, 23);
            this.rbPar.Margin = new System.Windows.Forms.Padding(4);
            this.rbPar.Name = "rbPar";
            this.rbPar.Size = new System.Drawing.Size(55, 23);
            this.rbPar.TabIndex = 1;
            this.rbPar.TabStop = true;
            this.rbPar.Text = "par";
            this.rbPar.UseVisualStyleBackColor = true;
            // 
            // lblErori
            // 
            this.lblErori.AutoSize = true;
            this.lblErori.ForeColor = System.Drawing.Color.Red;
            this.lblErori.Location = new System.Drawing.Point(72, 532);
            this.lblErori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErori.Name = "lblErori";
            this.lblErori.Size = new System.Drawing.Size(0, 16);
            this.lblErori.TabIndex = 3;
            // 
            // dgvPomi
            // 
            this.dgvPomi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPomi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPomi.Location = new System.Drawing.Point(16, 49);
            this.dgvPomi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPomi.Name = "dgvPomi";
            this.dgvPomi.RowHeadersWidth = 51;
            this.dgvPomi.Size = new System.Drawing.Size(699, 255);
            this.dgvPomi.TabIndex = 2;
            this.dgvPomi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPomi_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.ckbVisin);
            this.panel2.Controls.Add(this.ckbNuc);
            this.panel2.Controls.Add(this.ckbGutui);
            this.panel2.Controls.Add(this.ckbPiersic);
            this.panel2.Controls.Add(this.ckbCais);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnCauta);
            this.panel2.Controls.Add(this.ckbCires);
            this.panel2.Controls.Add(this.ckbPrun);
            this.panel2.Controls.Add(this.ckbPar);
            this.panel2.Controls.Add(this.ckbMar);
            this.panel2.Location = new System.Drawing.Point(16, 335);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 119);
            this.panel2.TabIndex = 4;
            // 
            // ckbVisin
            // 
            this.ckbVisin.AutoSize = true;
            this.ckbVisin.Location = new System.Drawing.Point(512, 20);
            this.ckbVisin.Margin = new System.Windows.Forms.Padding(4);
            this.ckbVisin.Name = "ckbVisin";
            this.ckbVisin.Size = new System.Drawing.Size(56, 20);
            this.ckbVisin.TabIndex = 10;
            this.ckbVisin.Text = "visin";
            this.ckbVisin.UseVisualStyleBackColor = true;
            // 
            // ckbNuc
            // 
            this.ckbNuc.AutoSize = true;
            this.ckbNuc.Location = new System.Drawing.Point(454, 20);
            this.ckbNuc.Margin = new System.Windows.Forms.Padding(4);
            this.ckbNuc.Name = "ckbNuc";
            this.ckbNuc.Size = new System.Drawing.Size(50, 20);
            this.ckbNuc.TabIndex = 9;
            this.ckbNuc.Text = "nuc";
            this.ckbNuc.UseVisualStyleBackColor = true;
            // 
            // ckbGutui
            // 
            this.ckbGutui.AutoSize = true;
            this.ckbGutui.Location = new System.Drawing.Point(389, 20);
            this.ckbGutui.Margin = new System.Windows.Forms.Padding(4);
            this.ckbGutui.Name = "ckbGutui";
            this.ckbGutui.Size = new System.Drawing.Size(57, 20);
            this.ckbGutui.TabIndex = 8;
            this.ckbGutui.Text = "gutui";
            this.ckbGutui.UseVisualStyleBackColor = true;
            // 
            // ckbPiersic
            // 
            this.ckbPiersic.AutoSize = true;
            this.ckbPiersic.Location = new System.Drawing.Point(312, 20);
            this.ckbPiersic.Margin = new System.Windows.Forms.Padding(4);
            this.ckbPiersic.Name = "ckbPiersic";
            this.ckbPiersic.Size = new System.Drawing.Size(69, 20);
            this.ckbPiersic.TabIndex = 7;
            this.ckbPiersic.Text = "piersic";
            this.ckbPiersic.UseVisualStyleBackColor = true;
            // 
            // ckbCais
            // 
            this.ckbCais.AutoSize = true;
            this.ckbCais.Location = new System.Drawing.Point(250, 20);
            this.ckbCais.Margin = new System.Windows.Forms.Padding(4);
            this.ckbCais.Name = "ckbCais";
            this.ckbCais.Size = new System.Drawing.Size(54, 20);
            this.ckbCais.TabIndex = 6;
            this.ckbCais.Text = "cais";
            this.ckbCais.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.PaleGreen;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(169, 70);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCauta.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.Location = new System.Drawing.Point(25, 70);
            this.btnCauta.Margin = new System.Windows.Forms.Padding(4);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(100, 28);
            this.btnCauta.TabIndex = 4;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // ckbCires
            // 
            this.ckbCires.AutoSize = true;
            this.ckbCires.Location = new System.Drawing.Point(184, 20);
            this.ckbCires.Margin = new System.Windows.Forms.Padding(4);
            this.ckbCires.Name = "ckbCires";
            this.ckbCires.Size = new System.Drawing.Size(58, 20);
            this.ckbCires.TabIndex = 3;
            this.ckbCires.Text = "cires";
            this.ckbCires.UseVisualStyleBackColor = true;
            // 
            // ckbPrun
            // 
            this.ckbPrun.AutoSize = true;
            this.ckbPrun.Location = new System.Drawing.Point(121, 20);
            this.ckbPrun.Margin = new System.Windows.Forms.Padding(4);
            this.ckbPrun.Name = "ckbPrun";
            this.ckbPrun.Size = new System.Drawing.Size(55, 20);
            this.ckbPrun.TabIndex = 2;
            this.ckbPrun.Text = "prun";
            this.ckbPrun.UseVisualStyleBackColor = true;
            // 
            // ckbPar
            // 
            this.ckbPar.AutoSize = true;
            this.ckbPar.Location = new System.Drawing.Point(64, 20);
            this.ckbPar.Margin = new System.Windows.Forms.Padding(4);
            this.ckbPar.Name = "ckbPar";
            this.ckbPar.Size = new System.Drawing.Size(49, 20);
            this.ckbPar.TabIndex = 1;
            this.ckbPar.Text = "par";
            this.ckbPar.UseVisualStyleBackColor = true;
            // 
            // ckbMar
            // 
            this.ckbMar.AutoSize = true;
            this.ckbMar.Location = new System.Drawing.Point(4, 20);
            this.ckbMar.Margin = new System.Windows.Forms.Padding(4);
            this.ckbMar.Name = "ckbMar";
            this.ckbMar.Size = new System.Drawing.Size(52, 20);
            this.ckbMar.TabIndex = 0;
            this.ckbMar.Text = "mar";
            this.ckbMar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfataUtilizator_WindowsForms.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(15, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnRaport
            // 
            this.btnRaport.BackColor = System.Drawing.Color.PaleGreen;
            this.btnRaport.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaport.Location = new System.Drawing.Point(200, 336);
            this.btnRaport.Margin = new System.Windows.Forms.Padding(4);
            this.btnRaport.Name = "btnRaport";
            this.btnRaport.Size = new System.Drawing.Size(112, 38);
            this.btnRaport.TabIndex = 4;
            this.btnRaport.Text = "Raport";
            this.btnRaport.UseVisualStyleBackColor = false;
            this.btnRaport.Click += new System.EventHandler(this.btnRaport_Click);
            // 
            // FormaPomi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.BackgroundImage = global::InterfataUtilizator_WindowsForms.Properties.Resources.green1__1_;
            this.ClientSize = new System.Drawing.Size(1315, 691);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblErori);
            this.Controls.Add(this.dgvPomi);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormaPomi";
            this.Text = "FormaPomi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPomi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbMar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCires;
        private System.Windows.Forms.RadioButton rbPrun;
        private System.Windows.Forms.RadioButton rbPar;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblErori;
        private System.Windows.Forms.DataGridView dgvPomi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox ckbMar;
        private System.Windows.Forms.CheckBox ckbCires;
        private System.Windows.Forms.CheckBox ckbPrun;
        private System.Windows.Forms.CheckBox ckbPar;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbvisin;
        private System.Windows.Forms.RadioButton rbnuc;
        private System.Windows.Forms.RadioButton rbgutui;
        private System.Windows.Forms.RadioButton rbpiersic;
        private System.Windows.Forms.RadioButton rbcais;
        private System.Windows.Forms.CheckBox ckbGutui;
        private System.Windows.Forms.CheckBox ckbPiersic;
        private System.Windows.Forms.CheckBox ckbCais;
        private System.Windows.Forms.CheckBox ckbVisin;
        private System.Windows.Forms.CheckBox ckbNuc;
        private System.Windows.Forms.Button btnRaport;
    }
}