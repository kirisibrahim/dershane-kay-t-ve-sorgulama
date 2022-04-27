
namespace DershaneProj
{
    partial class AnaForm
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MnuOgrenciKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuKursKayit = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuKapat = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSorgular = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu.Font = new System.Drawing.Font("Roboto Bk", 10F);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuOgrenciKayit,
            this.MnuKursKayit,
            this.MnuSorgular,
            this.MnuKapat});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 25);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // MnuOgrenciKayit
            // 
            this.MnuOgrenciKayit.Name = "MnuOgrenciKayit";
            this.MnuOgrenciKayit.Size = new System.Drawing.Size(161, 21);
            this.MnuOgrenciKayit.Text = "Öğrenci Kayıt İşlemleri";
            this.MnuOgrenciKayit.Click += new System.EventHandler(this.MnuOgrenciKayit_Click);
            // 
            // MnuKursKayit
            // 
            this.MnuKursKayit.Name = "MnuKursKayit";
            this.MnuKursKayit.Size = new System.Drawing.Size(141, 21);
            this.MnuKursKayit.Text = "Kurs Kayıt İşlemleri";
            this.MnuKursKayit.Click += new System.EventHandler(this.MnuKursKayit_Click);
            // 
            // MnuKapat
            // 
            this.MnuKapat.ForeColor = System.Drawing.Color.Maroon;
            this.MnuKapat.Name = "MnuKapat";
            this.MnuKapat.Size = new System.Drawing.Size(117, 21);
            this.MnuKapat.Text = "Programı Kapat";
            this.MnuKapat.Click += new System.EventHandler(this.MnuKapat_Click);
            // 
            // MnuSorgular
            // 
            this.MnuSorgular.Name = "MnuSorgular";
            this.MnuSorgular.Size = new System.Drawing.Size(115, 21);
            this.MnuSorgular.Text = "Örnek Sorgular";
            this.MnuSorgular.Click += new System.EventHandler(this.MnuSorgular_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "AnaForm";
            this.Text = "Dershane Kayıt İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem MnuOgrenciKayit;
        private System.Windows.Forms.ToolStripMenuItem MnuKursKayit;
        private System.Windows.Forms.ToolStripMenuItem MnuKapat;
        private System.Windows.Forms.ToolStripMenuItem MnuSorgular;
    }
}

