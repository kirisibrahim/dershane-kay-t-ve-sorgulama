using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DershaneProj
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void MnuOgrenciKayit_Click(object sender, EventArgs e)
        {
            OgrenciKayitIslemleri ogr = new OgrenciKayitIslemleri();
            ogr.MdiParent = this;
            ogr.Show();
        }

        private void MnuKursKayit_Click(object sender, EventArgs e)
        {
            KursKayitIslemleri kurs = new KursKayitIslemleri();
            kurs.MdiParent = this;
            kurs.Show();
        }

        private void MnuKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnuSorgular_Click(object sender, EventArgs e)
        {
            OrnekSorgular sorgu = new OrnekSorgular();
            sorgu.MdiParent = this;
            sorgu.Show();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
