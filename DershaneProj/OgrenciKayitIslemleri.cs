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
    public partial class OgrenciKayitIslemleri : Form
    {
        SqlDataAdapter DAdapter;
        SqlDataReader DReader;
        SqlCommand CCommand;
        SqlConnection CConnect;
        DataSet DDataSet;

        public OgrenciKayitIslemleri()
        {
            InitializeComponent();
        }
       
        private const string CCString = @"server='(localdb)\MSSQLLocalDB'; Initial Catalog=DBDERSHANE;Integrated Security=SSPI";

        private void OgrenciKayitIslemleri_Load(object sender, EventArgs e)
        {
            CConnect = new SqlConnection(CCString);
        }

        public int Kayit_varmi_kontrol(string xTCNum)
        {
            int xSorgu_adet;
            //Parametre olarak gelen tablonun primary alanına göre tabloya sorgu çekiliyor.
            CConnect.Open();
            //Connection açılıyor ve sorgu gönderilerek dönen değer sorgu adedi değişkenine atılıyor
            CCommand = new SqlCommand("SELECT COUNT(TC_NO) FROM TOGRENCI WHERE TC_NO ='" + xTCNum + "' ", CConnect);

            xSorgu_adet = Convert.ToInt32(CCommand.ExecuteScalar());
            CCommand.Connection = CConnect;
            CConnect.Close();

            return xSorgu_adet;
        }

        public void YeniKayitKontrol()
        {
            //Ekrandaki değerlerin temizlenmesi için alanlar boşaltılıyor.
            TC_NO.Text = "";
            AD.Text = "";
            SOYAD.Text = "";
            CINSIYET.Text = "";
            ANNE_ADI.Text = "";
            BABA_ADI.Text = "";
            TELEFON.Text = "";
            IL.Text = "";
            ILCE.Text = "";
            ADRES.Text = "";

            DAdapter = new SqlDataAdapter("SELECT TC_NO,AD,SOYAD,CINSIYET,DOGUM_TARIHI,ANNE_ADI,BABA_ADI,TELEFON,IL,ILCE,ADRES FROM VI_OGRENCI_LIST", CConnect);
            DDataSet = new DataSet();
            CConnect.Open();
            DAdapter.Fill(DDataSet, "VI_OGRENCI_LIST");
            GridOgrenci.DataSource = DDataSet.Tables["VI_OGRENCI_LIST"];
            CConnect.Close();
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            YeniKayitKontrol();
        }

        private void Raporla_Click(object sender, EventArgs e)
        {
            DAdapter = new SqlDataAdapter("SELECT TC_NO,AD,SOYAD,CINSIYET,DOGUM_TARIHI,ANNE_ADI,BABA_ADI,TELEFON,IL,ILCE,ADRES FROM VI_OGRENCI_LIST", CConnect);
            DDataSet = new DataSet();
            CConnect.Open();
            DAdapter.Fill(DDataSet, "VI_OGRENCI_LIST");
            GridOgrenci.DataSource = DDataSet.Tables["VI_OGRENCI_LIST"];
            CConnect.Close();
        }

        private void Kaydet_Click(object sender, EventArgs e)
        {
            //Boş olmaması gereken alanlar kontrol ediliyor
            if (TC_NO.Text == "" || AD.Text == "" || SOYAD.Text == "")
            {
                MessageBox.Show("TC No - Ad - Soyad alanları boş olamaz!", "Boş Alan Kontrolü", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (Kayit_varmi_kontrol(TC_NO.Text) == 0)
            {
                CCommand = new SqlCommand();
                CConnect.Open();
                CCommand.Connection = CConnect;
                // Procedure kaydetme işlemi için gidiliyor. Tarih alanı MSSQL uygun şekilde çevriliyor.
                CCommand.CommandText = @" DECLARE @DOGUM_TARIHI DATE = CONVERT(DATE, '" + DOGUM_TARIHI.Value + "', 104) "
                + "Execute PR_OGRENCI_KAYIT " + TC_NO.Text + ",'" + AD.Text + "','" + SOYAD.Text + "','" + CINSIYET.Text + "','" + BABA_ADI.Text + "','"
                + ANNE_ADI.Text + "','" + ADRES.Text + "','" + IL.Text + "','" + ILCE.Text + "','" + TELEFON.Text + "',@DOGUM_TARIHI";
                CCommand.ExecuteNonQuery();
                CConnect.Close();
            }
            else
            {
                CCommand = new SqlCommand();
                CConnect.Open();
                CCommand.Connection = CConnect;
                // Kayıt varsa güncelleme işlemi yapılıyor.
                CCommand.CommandText = @" DECLARE @DOGUM_TARIHI DATE = CONVERT(DATE, '" + DOGUM_TARIHI.Value + "', 104) "
                + "Execute PR_OGRENCI_UPDATE " + TC_NO.Text + ",'" + AD.Text + "','" + SOYAD.Text + "','" + CINSIYET.Text + "','" + BABA_ADI.Text + "','"
                + ANNE_ADI.Text + "','" + ADRES.Text + "','" + IL.Text + "','" + ILCE.Text + "','" + TELEFON.Text + "',@DOGUM_TARIHI";
                CCommand.ExecuteNonQuery();
                CConnect.Close();
            }
           
            MessageBox.Show("Öğrenci Kayıt Edildi.", "Kayıt Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YeniKayitKontrol();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            if (TC_NO.Text == "")
            {
                MessageBox.Show("Lütfen Silinecek TC Numarası bilgisini giriniz", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Kayit_varmi_kontrol(TC_NO.Text) == 0)
            {
                MessageBox.Show("Girilen bilgilere ait TC Numarası bulunulamadı.", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CCommand = new SqlCommand();
            CConnect.Open();
            CCommand.Connection = CConnect;
            CCommand.CommandText = "EXEC PR_OGRENCI_DELETE " + TC_NO.Text;
            CCommand.ExecuteNonQuery();
            CConnect.Close();
            MessageBox.Show("Silme İşlemi başarılı", "Silme İşlemi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            YeniKayitKontrol();
        }
        //Sayısal alanlara sadece sayısal değer girilmesi sağlanıyor.
        private void TC_NO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TELEFON_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void GridOgrenci_DoubleClick(object sender, EventArgs e)
        {
            TC_NO.Text = GridOgrenci.CurrentRow.Cells[0].Value.ToString();
            AD.Text = GridOgrenci.CurrentRow.Cells[1].Value.ToString();
            SOYAD.Text = GridOgrenci.CurrentRow.Cells[2].Value.ToString();
            CINSIYET.Text = GridOgrenci.CurrentRow.Cells[3].Value.ToString();
            DOGUM_TARIHI.Text = GridOgrenci.CurrentRow.Cells[4].Value.ToString();
            ANNE_ADI.Text = GridOgrenci.CurrentRow.Cells[5].Value.ToString();
            BABA_ADI.Text = GridOgrenci.CurrentRow.Cells[6].Value.ToString();
            TELEFON.Text = GridOgrenci.CurrentRow.Cells[7].Value.ToString();
            IL.Text = GridOgrenci.CurrentRow.Cells[8].Value.ToString();
            ILCE.Text = GridOgrenci.CurrentRow.Cells[9].Value.ToString();
            ADRES.Text = GridOgrenci.CurrentRow.Cells[10].Value.ToString();
        }
    }
}
