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
    public partial class KursKayitIslemleri : Form
    {
        public KursKayitIslemleri()
        {
            InitializeComponent();
        }

        SqlDataAdapter DAdapter;
        SqlDataReader DReader;
        SqlCommand CCommand;
        SqlConnection CConnect;
        DataSet DDataSet;

        private const string CCString = @"server='(localdb)\MSSQLLocalDB'; Initial Catalog=DBDERSHANE;Integrated Security=SSPI";

        private void KursKayitIslemleri_Load(object sender, EventArgs e)
        {
            CConnect = new SqlConnection(CCString);
        }

        public void YeniKayitKontrol()
        {
            //Ekrandaki değerlerin temizlenmesi için alanlar boşaltılıyor.
            TC_NO_2.Text = "";
            KURS_TIPI.Text = "";
            KURS_UCRETI.Text = "";
            KAYIT_YILI.Text = "";
            KAYIT_TARIHI.Text = "";
            KAYIT_NO.Text = "";

            DAdapter = new SqlDataAdapter("SELECT TC_NO,KURS_TIPI,KURS_UCRETI,KAYIT_YILI,KAYIT_TARIHI,KAYIT_NO FROM VI_DETAY_LIST", CConnect);
            DDataSet = new DataSet();
            CConnect.Open();
            DAdapter.Fill(DDataSet, "VI_DETAY_LIST");
            GridKursKayit.DataSource = DDataSet.Tables["VI_DETAY_LIST"];
            CConnect.Close();
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            YeniKayitKontrol();
        }

        private void Raporla_Click(object sender, EventArgs e)
        {
            DAdapter = new SqlDataAdapter("SELECT TC_NO,KURS_TIPI,KURS_UCRETI,KAYIT_YILI,KAYIT_TARIHI,KAYIT_NO FROM VI_DETAY_LIST", CConnect);
            DDataSet = new DataSet();
            CConnect.Open();
            DAdapter.Fill(DDataSet, "VI_DETAY_LIST");
            GridKursKayit.DataSource = DDataSet.Tables["VI_DETAY_LIST"];
            CConnect.Close();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            //Boş olmaması gereken alanlar kontrol ediliyor
            if (TC_NO_2.Text == "" || KURS_TIPI.Text == "" || KAYIT_YILI.Text == "")
            {
                MessageBox.Show("TC No - Kurs Tipi - Kayıt Yılı alanları boş olamaz!", "Boş Alan Kontrolü", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (KAYIT_NO.Text == "")
            {
                CCommand = new SqlCommand();
                CConnect.Open();
                CCommand.Connection = CConnect;
                // Procedure kaydetme işlemi için gidiliyor. Tarih alanı MSSQL uygun şekilde çevriliyor.
                CCommand.CommandText = @" DECLARE @KAYIT_TARIHI DATE = CONVERT(DATE, '" + KAYIT_TARIHI.Value + "', 104)"
                + "Execute PR_DETAY_KAYIT '" + TC_NO_2.Text + "','"+KURS_TIPI.Text+"','" + KAYIT_YILI.Text + "',@KAYIT_TARIHI," + KURS_UCRETI.Text + "";
                CCommand.ExecuteNonQuery();
                CConnect.Close();
            }
            else
            {
                CCommand = new SqlCommand();
                CConnect.Open();
                CCommand.Connection = CConnect;
                // Kayıt varsa güncelleme işlemi yapılıyor.
                CCommand.CommandText = @" DECLARE @KAYIT_TARIHI DATE = CONVERT(DATE, '" + KAYIT_TARIHI.Value + "', 104) "
                 + "Execute PR_DETAY_UPDATE " + KAYIT_NO.Text +",'" + TC_NO_2.Text + "','" + KURS_TIPI.Text + "','" + KAYIT_YILI.Text + "',@KAYIT_TARIHI," + KURS_UCRETI.Text + "";
                CCommand.ExecuteNonQuery();
                CConnect.Close();
            }

            MessageBox.Show("Kurs Kayıt Edildi.", "Kayıt Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YeniKayitKontrol();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (KAYIT_NO.Text == "")
            {
                MessageBox.Show("Lütfen Silinecek Kaydı Seçiniz", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CCommand = new SqlCommand();
            CConnect.Open();
            CCommand.Connection = CConnect;
            CCommand.CommandText = "EXEC PR_DETAY_DELETE " + KAYIT_NO.Text;
            CCommand.ExecuteNonQuery();
            CConnect.Close();
            MessageBox.Show("Silme İşlemi başarılı", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YeniKayitKontrol();
        }

        private void TC_NO_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void KURS_UCRETI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void KAYIT_YILI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void GridKursKayit_DoubleClick(object sender, EventArgs e)
        {
            TC_NO_2.Text = GridKursKayit.CurrentRow.Cells[0].Value.ToString();
            KURS_TIPI.Text = GridKursKayit.CurrentRow.Cells[1].Value.ToString();
            KURS_UCRETI.Text = GridKursKayit.CurrentRow.Cells[2].Value.ToString();
            KAYIT_YILI.Text = GridKursKayit.CurrentRow.Cells[3].Value.ToString();
            KAYIT_TARIHI.Text = GridKursKayit.CurrentRow.Cells[4].Value.ToString();
            KAYIT_NO.Text = GridKursKayit.CurrentRow.Cells[5].Value.ToString();
        }

        private void TC_NO_2_Leave(object sender, EventArgs e)
        {
            if (TC_NO_2.Text == "")
            {
                return;
            }
            int xSorgu_adet;
            //Parametre olarak gelen tablonun primary alanına göre tabloya sorgu çekiliyor.
            CConnect.Open();
            //Connection açılıyor ve sorgu gönderilerek dönen değer sorgu adedi değişkenine atılıyor
            CCommand = new SqlCommand("SELECT COUNT(TC_NO) FROM TOGRENCI WHERE TC_NO ='" + TC_NO_2.Text + "' ", CConnect);

            xSorgu_adet = Convert.ToInt32(CCommand.ExecuteScalar());
            CCommand.Connection = CConnect;
            CConnect.Close();

            if (xSorgu_adet == 0) 
            {
                MessageBox.Show("Lütfen Geçerli TC Numarası kullanınız", "TC Numarası Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
