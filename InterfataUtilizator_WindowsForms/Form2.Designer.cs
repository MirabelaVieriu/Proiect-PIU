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
            this.btnAdauga = new System.Windows.Forms.Button();
            this.tbSuprafata = new System.Windows.Forms.TextBox();
            this.lblSuprafata = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErori = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivezi)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLivezi
            // 
            this.dgvLivezi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivezi.Location = new System.Drawing.Point(43, 45);
            this.dgvLivezi.Name = "dgvLivezi";
            this.dgvLivezi.RowHeadersWidth = 51;
            this.dgvLivezi.Size = new System.Drawing.Size(427, 199);
            this.dgvLivezi.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnAdauga);
            this.panel1.Controls.Add(this.tbSuprafata);
            this.panel1.Controls.Add(this.lblSuprafata);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Controls.Add(this.tbId);
            this.panel1.Location = new System.Drawing.Point(627, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 323);
            this.panel1.TabIndex = 4;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdauga.Location = new System.Drawing.Point(27, 245);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 5;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // tbSuprafata
            // 
            this.tbSuprafata.Location = new System.Drawing.Point(18, 62);
            this.tbSuprafata.Name = "tbSuprafata";
            this.tbSuprafata.Size = new System.Drawing.Size(100, 20);
            this.tbSuprafata.TabIndex = 6;
            // 
            // lblSuprafata
            // 
            this.lblSuprafata.AutoSize = true;
            this.lblSuprafata.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuprafata.Location = new System.Drawing.Point(14, 40);
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
            this.lblId.Location = new System.Drawing.Point(14, 97);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(73, 19);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id livada\r\n";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(18, 119);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 20);
            this.tbId.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfataUtilizator_WindowsForms.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 5;
            // 
            // lblErori
            // 
            this.lblErori.AutoSize = true;
            this.lblErori.Location = new System.Drawing.Point(40, 432);
            this.lblErori.Name = "lblErori";
            this.lblErori.Size = new System.Drawing.Size(0, 15);
            this.lblErori.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 482);
            this.Controls.Add(this.lblErori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLivezi);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivezi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}