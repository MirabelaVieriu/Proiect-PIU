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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblAn = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCires = new System.Windows.Forms.RadioButton();
            this.rbMar = new System.Windows.Forms.RadioButton();
            this.rbPrun = new System.Windows.Forms.RadioButton();
            this.rbPar = new System.Windows.Forms.RadioButton();
            this.lblErori = new System.Windows.Forms.Label();
            this.dgvPomi = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.ckbCires = new System.Windows.Forms.CheckBox();
            this.ckbPrun = new System.Windows.Forms.CheckBox();
            this.ckbPar = new System.Windows.Forms.CheckBox();
            this.ckbMar = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPomi)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAdauga);
            this.panel1.Controls.Add(this.lblAn);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblCantitate);
            this.panel1.Controls.Add(this.tbCantitate);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(752, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 344);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(138, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Modifica";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(22, 273);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(84, 31);
            this.btnAdauga.TabIndex = 2;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAn.Location = new System.Drawing.Point(22, 202);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(116, 19);
            this.lblAn.TabIndex = 2;
            this.lblAn.Text = "Anul Plantarii";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantitate.Location = new System.Drawing.Point(28, 144);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(78, 19);
            this.lblCantitate.TabIndex = 2;
            this.lblCantitate.Text = "Cantitate";
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(25, 166);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(117, 20);
            this.tbCantitate.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCires);
            this.groupBox1.Controls.Add(this.rbMar);
            this.groupBox1.Controls.Add(this.rbPrun);
            this.groupBox1.Controls.Add(this.rbPar);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 72);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tip";
            // 
            // rbCires
            // 
            this.rbCires.AutoSize = true;
            this.rbCires.Location = new System.Drawing.Point(212, 19);
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
            this.rbMar.Location = new System.Drawing.Point(6, 19);
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
            this.rbPrun.Location = new System.Drawing.Point(135, 19);
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
            this.rbPar.Location = new System.Drawing.Point(71, 19);
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
            this.lblErori.Location = new System.Drawing.Point(54, 432);
            this.lblErori.Name = "lblErori";
            this.lblErori.Size = new System.Drawing.Size(0, 15);
            this.lblErori.TabIndex = 3;
            // 
            // dgvPomi
            // 
            this.dgvPomi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPomi.Location = new System.Drawing.Point(12, 40);
            this.dgvPomi.Name = "dgvPomi";
            this.dgvPomi.RowHeadersWidth = 51;
            this.dgvPomi.Size = new System.Drawing.Size(524, 207);
            this.dgvPomi.TabIndex = 2;
            this.dgvPomi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPomi_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnCauta);
            this.panel2.Controls.Add(this.ckbCires);
            this.panel2.Controls.Add(this.ckbPrun);
            this.panel2.Controls.Add(this.ckbPar);
            this.panel2.Controls.Add(this.ckbMar);
            this.panel2.Location = new System.Drawing.Point(12, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(365, 100);
            this.panel2.TabIndex = 4;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(127, 57);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauta.Location = new System.Drawing.Point(19, 57);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 23);
            this.btnCauta.TabIndex = 4;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // ckbCires
            // 
            this.ckbCires.AutoSize = true;
            this.ckbCires.Location = new System.Drawing.Point(208, 16);
            this.ckbCires.Name = "ckbCires";
            this.ckbCires.Size = new System.Drawing.Size(55, 19);
            this.ckbCires.TabIndex = 3;
            this.ckbCires.Text = "cires";
            this.ckbCires.UseVisualStyleBackColor = true;
            // 
            // ckbPrun
            // 
            this.ckbPrun.AutoSize = true;
            this.ckbPrun.Location = new System.Drawing.Point(148, 16);
            this.ckbPrun.Name = "ckbPrun";
            this.ckbPrun.Size = new System.Drawing.Size(54, 19);
            this.ckbPrun.TabIndex = 2;
            this.ckbPrun.Text = "prun";
            this.ckbPrun.UseVisualStyleBackColor = true;
            // 
            // ckbPar
            // 
            this.ckbPar.AutoSize = true;
            this.ckbPar.Location = new System.Drawing.Point(85, 16);
            this.ckbPar.Name = "ckbPar";
            this.ckbPar.Size = new System.Drawing.Size(47, 19);
            this.ckbPar.TabIndex = 1;
            this.ckbPar.Text = "par";
            this.ckbPar.UseVisualStyleBackColor = true;
            // 
            // ckbMar
            // 
            this.ckbMar.AutoSize = true;
            this.ckbMar.Location = new System.Drawing.Point(28, 16);
            this.ckbMar.Name = "ckbMar";
            this.ckbMar.Size = new System.Drawing.Size(51, 19);
            this.ckbMar.TabIndex = 0;
            this.ckbMar.Text = "mar";
            this.ckbMar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfataUtilizator_WindowsForms.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 12);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormaPomi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1172, 472);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblErori);
            this.Controls.Add(this.dgvPomi);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvPomi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox ckbMar;
        private System.Windows.Forms.CheckBox ckbCires;
        private System.Windows.Forms.CheckBox ckbPrun;
        private System.Windows.Forms.CheckBox ckbPar;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}