namespace Malisek_projekt_RVP
{
    partial class Admin
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
            this.SU = new System.Windows.Forms.Button();
            this.SZ = new System.Windows.Forms.Button();
            this.Konec = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SU
            // 
            this.SU.Location = new System.Drawing.Point(117, 179);
            this.SU.Name = "SU";
            this.SU.Size = new System.Drawing.Size(167, 46);
            this.SU.TabIndex = 0;
            this.SU.Text = "Správa uživatelů";
            this.SU.UseVisualStyleBackColor = true;
            this.SU.Click += new System.EventHandler(this.button1_Click);
            // 
            // SZ
            // 
            this.SZ.Location = new System.Drawing.Point(310, 179);
            this.SZ.Name = "SZ";
            this.SZ.Size = new System.Drawing.Size(167, 46);
            this.SZ.TabIndex = 1;
            this.SZ.Text = "Správa vozidel";
            this.SZ.UseVisualStyleBackColor = true;
            this.SZ.Click += new System.EventHandler(this.SZ_Click);
            // 
            // Konec
            // 
            this.Konec.Location = new System.Drawing.Point(713, 415);
            this.Konec.Name = "Konec";
            this.Konec.Size = new System.Drawing.Size(75, 23);
            this.Konec.TabIndex = 2;
            this.Konec.Text = "KONEC";
            this.Konec.UseVisualStyleBackColor = true;
            this.Konec.Click += new System.EventHandler(this.Konec_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Správa rezervací";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Konec);
            this.Controls.Add(this.SZ);
            this.Controls.Add(this.SU);
            this.Name = "Admin";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SU;
        private System.Windows.Forms.Button SZ;
        private System.Windows.Forms.Button Konec;
        private System.Windows.Forms.Button button1;
    }
}