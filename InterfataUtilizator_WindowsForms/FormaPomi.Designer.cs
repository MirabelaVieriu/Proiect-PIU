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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCires = new System.Windows.Forms.RadioButton();
            this.rbMar = new System.Windows.Forms.RadioButton();
            this.rbPrun = new System.Windows.Forms.RadioButton();
            this.rbPar = new System.Windows.Forms.RadioButton();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblAn = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdauga);
            this.panel1.Controls.Add(this.lblAn);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblCantitate);
            this.panel1.Controls.Add(this.txtCantitate);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(738, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 344);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCires);
            this.groupBox1.Controls.Add(this.rbMar);
            this.groupBox1.Controls.Add(this.rbPrun);
            this.groupBox1.Controls.Add(this.rbPar);
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
            this.rbCires.Size = new System.Drawing.Size(54, 19);
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
            this.rbMar.Size = new System.Drawing.Size(50, 19);
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
            this.rbPrun.Size = new System.Drawing.Size(53, 19);
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
            this.rbPar.Size = new System.Drawing.Size(46, 19);
            this.rbPar.TabIndex = 1;
            this.rbPar.TabStop = true;
            this.rbPar.Text = "par";
            this.rbPar.UseVisualStyleBackColor = true;
            // 
            // txtCantitate
            // 
            this.txtCantitate.Location = new System.Drawing.Point(25, 166);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(117, 20);
            this.txtCantitate.TabIndex = 2;
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Location = new System.Drawing.Point(28, 144);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(69, 19);
            this.lblCantitate.TabIndex = 2;
            this.lblCantitate.Text = "Cantitate";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 224);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(22, 202);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(99, 19);
            this.lblAn.TabIndex = 2;
            this.lblAn.Text = "Anul Plantarii";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(22, 273);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 2;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            // 
            // FormaPomi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormaPomi";
            this.Text = "FormaPomi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbMar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCires;
        private System.Windows.Forms.RadioButton rbPrun;
        private System.Windows.Forms.RadioButton rbPar;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.Button btnAdauga;
    }
}