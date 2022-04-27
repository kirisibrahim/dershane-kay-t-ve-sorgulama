
namespace DershaneProj
{
    partial class KursKayitIslemleri
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
            this.P4 = new System.Windows.Forms.Panel();
            this.Kaydet = new System.Windows.Forms.Button();
            this.Sil = new System.Windows.Forms.Button();
            this.Temizle = new System.Windows.Forms.Button();
            this.Raporla = new System.Windows.Forms.Button();
            this.P1 = new System.Windows.Forms.Panel();
            this.KAYIT_NO = new System.Windows.Forms.TextBox();
            this.L_KAYIT_NO = new System.Windows.Forms.Label();
            this.L_KAYIT_TARIHI = new System.Windows.Forms.Label();
            this.KAYIT_TARIHI = new System.Windows.Forms.DateTimePicker();
            this.L_KURS_TIPI = new System.Windows.Forms.Label();
            this.KURS_TIPI = new System.Windows.Forms.ComboBox();
            this.KURS_UCRETI = new System.Windows.Forms.TextBox();
            this.L_KURS_UCRETI = new System.Windows.Forms.Label();
            this.KAYIT_YILI = new System.Windows.Forms.TextBox();
            this.L_KAYIT_YILI = new System.Windows.Forms.Label();
            this.TC_NO_2 = new System.Windows.Forms.TextBox();
            this.L_TC_NO_2 = new System.Windows.Forms.Label();
            this.GridKursKayit = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.P4.SuspendLayout();
            this.P1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridKursKayit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.P4);
            this.panel1.Controls.Add(this.P1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 183);
            this.panel1.TabIndex = 1;
            // 
            // P4
            // 
            this.P4.Controls.Add(this.Kaydet);
            this.P4.Controls.Add(this.Sil);
            this.P4.Controls.Add(this.Temizle);
            this.P4.Controls.Add(this.Raporla);
            this.P4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P4.Location = new System.Drawing.Point(596, 0);
            this.P4.Name = "P4";
            this.P4.Size = new System.Drawing.Size(204, 183);
            this.P4.TabIndex = 14;
            // 
            // Kaydet
            // 
            this.Kaydet.BackColor = System.Drawing.Color.DarkSalmon;
            this.Kaydet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Kaydet.Location = new System.Drawing.Point(0, 0);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(204, 57);
            this.Kaydet.TabIndex = 6;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = false;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // Sil
            // 
            this.Sil.BackColor = System.Drawing.Color.DarkSalmon;
            this.Sil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Sil.Location = new System.Drawing.Point(0, 57);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(204, 42);
            this.Sil.TabIndex = 7;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = false;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Temizle
            // 
            this.Temizle.BackColor = System.Drawing.Color.DarkSalmon;
            this.Temizle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Temizle.Location = new System.Drawing.Point(0, 99);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(204, 42);
            this.Temizle.TabIndex = 8;
            this.Temizle.Text = "Temizle";
            this.Temizle.UseVisualStyleBackColor = false;
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // Raporla
            // 
            this.Raporla.BackColor = System.Drawing.Color.DarkSalmon;
            this.Raporla.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Raporla.Location = new System.Drawing.Point(0, 141);
            this.Raporla.Name = "Raporla";
            this.Raporla.Size = new System.Drawing.Size(204, 42);
            this.Raporla.TabIndex = 9;
            this.Raporla.Text = "Raporla";
            this.Raporla.UseVisualStyleBackColor = false;
            this.Raporla.Click += new System.EventHandler(this.Raporla_Click);
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.P1.Controls.Add(this.KAYIT_NO);
            this.P1.Controls.Add(this.L_KAYIT_NO);
            this.P1.Controls.Add(this.L_KAYIT_TARIHI);
            this.P1.Controls.Add(this.KAYIT_TARIHI);
            this.P1.Controls.Add(this.L_KURS_TIPI);
            this.P1.Controls.Add(this.KURS_TIPI);
            this.P1.Controls.Add(this.KURS_UCRETI);
            this.P1.Controls.Add(this.L_KURS_UCRETI);
            this.P1.Controls.Add(this.KAYIT_YILI);
            this.P1.Controls.Add(this.L_KAYIT_YILI);
            this.P1.Controls.Add(this.TC_NO_2);
            this.P1.Controls.Add(this.L_TC_NO_2);
            this.P1.Dock = System.Windows.Forms.DockStyle.Left;
            this.P1.Location = new System.Drawing.Point(0, 0);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(596, 183);
            this.P1.TabIndex = 11;
            // 
            // KAYIT_NO
            // 
            this.KAYIT_NO.Enabled = false;
            this.KAYIT_NO.Location = new System.Drawing.Point(114, 155);
            this.KAYIT_NO.Name = "KAYIT_NO";
            this.KAYIT_NO.Size = new System.Drawing.Size(133, 20);
            this.KAYIT_NO.TabIndex = 5;
            // 
            // L_KAYIT_NO
            // 
            this.L_KAYIT_NO.AutoSize = true;
            this.L_KAYIT_NO.Location = new System.Drawing.Point(26, 158);
            this.L_KAYIT_NO.Name = "L_KAYIT_NO";
            this.L_KAYIT_NO.Size = new System.Drawing.Size(47, 13);
            this.L_KAYIT_NO.TabIndex = 21;
            this.L_KAYIT_NO.Text = "Kayıt No";
            // 
            // L_KAYIT_TARIHI
            // 
            this.L_KAYIT_TARIHI.AutoSize = true;
            this.L_KAYIT_TARIHI.Location = new System.Drawing.Point(25, 134);
            this.L_KAYIT_TARIHI.Name = "L_KAYIT_TARIHI";
            this.L_KAYIT_TARIHI.Size = new System.Drawing.Size(59, 13);
            this.L_KAYIT_TARIHI.TabIndex = 20;
            this.L_KAYIT_TARIHI.Text = "Kayıt Tarihi";
            // 
            // KAYIT_TARIHI
            // 
            this.KAYIT_TARIHI.Location = new System.Drawing.Point(114, 129);
            this.KAYIT_TARIHI.Name = "KAYIT_TARIHI";
            this.KAYIT_TARIHI.Size = new System.Drawing.Size(133, 20);
            this.KAYIT_TARIHI.TabIndex = 4;
            // 
            // L_KURS_TIPI
            // 
            this.L_KURS_TIPI.AutoSize = true;
            this.L_KURS_TIPI.Location = new System.Drawing.Point(26, 54);
            this.L_KURS_TIPI.Name = "L_KURS_TIPI";
            this.L_KURS_TIPI.Size = new System.Drawing.Size(48, 13);
            this.L_KURS_TIPI.TabIndex = 18;
            this.L_KURS_TIPI.Text = "Kurs Tipi";
            // 
            // KURS_TIPI
            // 
            this.KURS_TIPI.FormattingEnabled = true;
            this.KURS_TIPI.Items.AddRange(new object[] {
            "KPSS",
            "DGS"});
            this.KURS_TIPI.Location = new System.Drawing.Point(114, 51);
            this.KURS_TIPI.Name = "KURS_TIPI";
            this.KURS_TIPI.Size = new System.Drawing.Size(133, 21);
            this.KURS_TIPI.TabIndex = 1;
            // 
            // KURS_UCRETI
            // 
            this.KURS_UCRETI.Location = new System.Drawing.Point(114, 81);
            this.KURS_UCRETI.Name = "KURS_UCRETI";
            this.KURS_UCRETI.Size = new System.Drawing.Size(133, 20);
            this.KURS_UCRETI.TabIndex = 2;
            this.KURS_UCRETI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KURS_UCRETI_KeyPress);
            // 
            // L_KURS_UCRETI
            // 
            this.L_KURS_UCRETI.AutoSize = true;
            this.L_KURS_UCRETI.Location = new System.Drawing.Point(26, 81);
            this.L_KURS_UCRETI.Name = "L_KURS_UCRETI";
            this.L_KURS_UCRETI.Size = new System.Drawing.Size(59, 13);
            this.L_KURS_UCRETI.TabIndex = 15;
            this.L_KURS_UCRETI.Text = "Kurs Ücreti";
            // 
            // KAYIT_YILI
            // 
            this.KAYIT_YILI.Location = new System.Drawing.Point(114, 104);
            this.KAYIT_YILI.MaxLength = 4;
            this.KAYIT_YILI.Name = "KAYIT_YILI";
            this.KAYIT_YILI.Size = new System.Drawing.Size(133, 20);
            this.KAYIT_YILI.TabIndex = 3;
            this.KAYIT_YILI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KAYIT_YILI_KeyPress);
            // 
            // L_KAYIT_YILI
            // 
            this.L_KAYIT_YILI.AutoSize = true;
            this.L_KAYIT_YILI.Location = new System.Drawing.Point(26, 107);
            this.L_KAYIT_YILI.Name = "L_KAYIT_YILI";
            this.L_KAYIT_YILI.Size = new System.Drawing.Size(46, 13);
            this.L_KAYIT_YILI.TabIndex = 13;
            this.L_KAYIT_YILI.Text = "Kayıt Yılı";
            // 
            // TC_NO_2
            // 
            this.TC_NO_2.Location = new System.Drawing.Point(114, 22);
            this.TC_NO_2.Name = "TC_NO_2";
            this.TC_NO_2.Size = new System.Drawing.Size(133, 20);
            this.TC_NO_2.TabIndex = 0;
            this.TC_NO_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TC_NO_2_KeyPress);
            this.TC_NO_2.Leave += new System.EventHandler(this.TC_NO_2_Leave);
            // 
            // L_TC_NO_2
            // 
            this.L_TC_NO_2.AutoSize = true;
            this.L_TC_NO_2.Location = new System.Drawing.Point(24, 25);
            this.L_TC_NO_2.Name = "L_TC_NO_2";
            this.L_TC_NO_2.Size = new System.Drawing.Size(44, 13);
            this.L_TC_NO_2.TabIndex = 11;
            this.L_TC_NO_2.Text = "T.C. No";
            // 
            // GridKursKayit
            // 
            this.GridKursKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridKursKayit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridKursKayit.Location = new System.Drawing.Point(0, 183);
            this.GridKursKayit.Name = "GridKursKayit";
            this.GridKursKayit.Size = new System.Drawing.Size(800, 267);
            this.GridKursKayit.TabIndex = 2;
            this.GridKursKayit.DoubleClick += new System.EventHandler(this.GridKursKayit_DoubleClick);
            // 
            // KursKayitIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridKursKayit);
            this.Controls.Add(this.panel1);
            this.Name = "KursKayitIslemleri";
            this.Text = "Kurs Kayıt İşlemleri";
            this.Load += new System.EventHandler(this.KursKayitIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.P4.ResumeLayout(false);
            this.P1.ResumeLayout(false);
            this.P1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridKursKayit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel P4;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.Button Raporla;
        private System.Windows.Forms.Panel P1;
        private System.Windows.Forms.Label L_KAYIT_TARIHI;
        private System.Windows.Forms.DateTimePicker KAYIT_TARIHI;
        private System.Windows.Forms.Label L_KURS_TIPI;
        private System.Windows.Forms.ComboBox KURS_TIPI;
        private System.Windows.Forms.TextBox KURS_UCRETI;
        private System.Windows.Forms.Label L_KURS_UCRETI;
        private System.Windows.Forms.TextBox KAYIT_YILI;
        private System.Windows.Forms.Label L_KAYIT_YILI;
        private System.Windows.Forms.TextBox TC_NO_2;
        private System.Windows.Forms.Label L_TC_NO_2;
        private System.Windows.Forms.TextBox KAYIT_NO;
        private System.Windows.Forms.Label L_KAYIT_NO;
        private System.Windows.Forms.DataGridView GridKursKayit;
    }
}