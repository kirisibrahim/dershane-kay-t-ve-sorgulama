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
    public partial class OrnekSorgular : Form
    {
        public OrnekSorgular()
        {
            InitializeComponent();
        }

        SqlDataAdapter DAdapter;
        SqlDataReader DReader;
        SqlCommand CCommand;
        SqlConnection CConnect;
        DataSet DDataSet;
        DataTable DDTable;

        //Connection String değeri dolduruluyor.
        private const string CCString = @"server='(localdb)\MSSQLLocalDB'; Initial Catalog=DBDERSHANE;Integrated Security=SSPI";


        private void OrnekSorgular_Load(object sender, EventArgs e)
        {
            CConnect = new SqlConnection(CCString);
            
            DAdapter = new SqlDataAdapter("SELECT * FROM VI_OGRENCI_CINSIYET_ORAN", CConnect);
            DDataSet = new DataSet();
            CConnect.Open();
            DAdapter.Fill(DDataSet, "VI_OGRENCI_CINSIYET_ORAN");
            GridCinsyetOran.DataSource = DDataSet.Tables["VI_OGRENCI_CINSIYET_ORAN"];
            CConnect.Close();

            DDTable = new DataTable();
            string Sorgu = "SELECT CINSIYET ,COUNT(*) AS OGRENCI_SAYISI FROM TOGRENCI WITH (NOLOCK)	GROUP BY CINSIYET";
            CCommand = new SqlCommand(Sorgu, CConnect);
            DAdapter = new SqlDataAdapter(CCommand);
            CConnect.Open();
            DAdapter.Fill(DDTable);
            GridCinsiyetSayilari.DataSource = DDTable;
            CConnect.Close();

            DDTable = new DataTable();
            string Sorgu1 = "SELECT TOP 1 MIN(KURS_UCRETI) AS EN_DUSUK_UCRET FROM TKAYIT";
            CCommand = new SqlCommand(Sorgu1, CConnect);
            DAdapter = new SqlDataAdapter(CCommand);
            CConnect.Open();
            DAdapter.Fill(DDTable);
            GridEnDusukKursUcreti.DataSource = DDTable;
            CConnect.Close();

            DDTable = new DataTable();
            string Sorgu2 = "SELECT TOP 1 MAX(KURS_UCRETI) AS EN_YUKSEK_UCRET FROM TKAYIT";
            CCommand = new SqlCommand(Sorgu2, CConnect);
            DAdapter = new SqlDataAdapter(CCommand);
            CConnect.Open();
            DAdapter.Fill(DDTable);
            GridEnYuksekKursUcreti.DataSource = DDTable;
            CConnect.Close();

            DDTable = new DataTable();
            string Sorgu3 = "SELECT AVG(KURS_UCRETI) AS ORTALAMA_UCRET FROM TKAYIT";
            CCommand = new SqlCommand(Sorgu3, CConnect);
            DAdapter = new SqlDataAdapter(CCommand);
            CConnect.Open();
            DAdapter.Fill(DDTable);
            GridOrtUcret.DataSource = DDTable;
            CConnect.Close();
        }
    }
}
