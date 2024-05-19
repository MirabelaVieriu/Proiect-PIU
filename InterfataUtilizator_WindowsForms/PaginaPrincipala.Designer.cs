namespace InterfataUtilizator_WindowsForms
{
    partial class PaginaPrincipala
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
            this.Livezi = new System.Windows.Forms.Button();
            this.Pomi = new System.Windows.Forms.Button();
            this.titlu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Livezi
            // 
            this.Livezi.BackColor = System.Drawing.Color.Transparent;
            this.Livezi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Livezi.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Livezi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Livezi.Image = global::InterfataUtilizator_WindowsForms.Properties.Resources._6929089__1_;
            this.Livezi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Livezi.Location = new System.Drawing.Point(342, 272);
            this.Livezi.Name = "Livezi";
            this.Livezi.Size = new System.Drawing.Size(182, 78);
            this.Livezi.TabIndex = 1;
            this.Livezi.Text = "Livezi";
            this.Livezi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Livezi.UseVisualStyleBackColor = false;
            this.Livezi.Click += new System.EventHandler(this.Livezi_Click);
            // 
            // Pomi
            // 
            this.Pomi.BackColor = System.Drawing.Color.Transparent;
            this.Pomi.BackgroundImage = global::InterfataUtilizator_WindowsForms.Properties.Resources.tree__2_;
            this.Pomi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Pomi.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Pomi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pomi.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pomi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Pomi.Location = new System.Drawing.Point(50, 272);
            this.Pomi.Name = "Pomi";
            this.Pomi.Size = new System.Drawing.Size(155, 78);
            this.Pomi.TabIndex = 0;
            this.Pomi.Text = "Pomi";
            this.Pomi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Pomi.UseVisualStyleBackColor = false;
            this.Pomi.Click += new System.EventHandler(this.Pomi_Click);
            // 
            // titlu
            // 
            this.titlu.AutoSize = true;
            this.titlu.BackColor = System.Drawing.Color.Transparent;
            this.titlu.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu.ForeColor = System.Drawing.Color.Black;
            this.titlu.Location = new System.Drawing.Point(12, 34);
            this.titlu.Name = "titlu";
            this.titlu.Size = new System.Drawing.Size(542, 84);
            this.titlu.TabIndex = 2;
            this.titlu.Text = "Aceasta este aplicatia mea pentru\r\n             gestionarea livezii";
            this.titlu.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.titlu.Click += new System.EventHandler(this.label1_Click);
            // 
            // PaginaPrincipala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfataUtilizator_WindowsForms.Properties.Resources.pngtree_simple_green_big_tree_background_material_picture_image_1127751__2_;
            this.ClientSize = new System.Drawing.Size(929, 403);
            this.Controls.Add(this.titlu);
            this.Controls.Add(this.Livezi);
            this.Controls.Add(this.Pomi);
            this.Name = "PaginaPrincipala";
            this.Text = "PaginaPrincipala";
            this.Load += new System.EventHandler(this.PaginaPrincipala_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Pomi;
        private System.Windows.Forms.Button Livezi;
        private System.Windows.Forms.Label titlu;
    }
}