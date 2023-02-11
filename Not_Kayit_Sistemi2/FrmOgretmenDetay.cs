using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Kayit_Sistemi2
{
	public partial class FrmOgretmenDetay : Form
	{

		SqlConnection baglanti = new SqlConnection(@"Data Source=CEMC\SQLEXPRESS01;Initial Catalog=DbNotKayit;Integrated Security=True");


		public FrmOgretmenDetay()
		{
			InitializeComponent();
		}

		private void FrmOgretmenDetay_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dbNotKayitDataSet.TBLDERS' table. You can move, or remove it, as needed.
			this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);
			

		}


		private void button1_Click(object sender, EventArgs e)
		{

			baglanti.Open();
			SqlCommand komut = new SqlCommand("insert into TBLDERS (OGRNUMARA,OGRAD,OGRSOYAD) VALUES (@p1,@p2,@p3)", baglanti);
			komut.Parameters.AddWithValue("@p1", MskNumara.Text);
			komut.Parameters.AddWithValue("@p2", TxtAd.Text);
			komut.Parameters.AddWithValue("@p3", TxtSoyad.Text);
			komut.ExecuteNonQuery();
			baglanti.Close();
			MessageBox.Show("Öğrenci Sisteme Eklendi","Uyarı");
			MskNumara.Clear();
			TxtAd.Clear();
			TxtSoyad.Clear();
			this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int secilen = dataGridView1.SelectedCells[0].RowIndex;

			MskNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
			TxtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
			TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

			TxtSinav1.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
			TxtSinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
			TxtSinav3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			double ortalama, s1, s2, s3;
			string durum;
			s1 =Convert.ToDouble(TxtSinav1.Text);
			s2=Convert.ToDouble(TxtSinav2.Text);
			s3=Convert.ToDouble(TxtSinav3.Text);

			ortalama=(s1+s2+s3)/3;
			LblOrtalama.Text = ortalama.ToString("##,00");

			if (ortalama>=70)
			{
				durum = "True";
			}
			else
			{
				durum = "False";
			}

			baglanti.Open();
			SqlCommand komut = new SqlCommand("update TBLDERS set OGRS1=@p1, OGRS2=@p2,OGRS3=@p3,ORTALAMA=@p4,DURUM=@p5 where OGRNUMARA=@p6", baglanti);
			komut.Parameters.AddWithValue("@p1", TxtSinav1.Text);
			komut.Parameters.AddWithValue("@p2", TxtSinav2.Text);
			komut.Parameters.AddWithValue("@p3", TxtSinav3.Text);
			komut.Parameters.AddWithValue("@p4", decimal.Parse(LblOrtalama.Text));
			komut.Parameters.AddWithValue("@p5", durum);
			komut.Parameters.AddWithValue("@p6", MskNumara.Text);
			komut.ExecuteNonQuery();

			MessageBox.Show("Öğrenci Notları Güncellendi", "Bilgi");

			SqlCommand gectiSayisi = new SqlCommand("select count(*) from TBLDERS where DURUM=1", baglanti);
			SqlDataReader gecenOkuma = gectiSayisi.ExecuteReader();

			while (gecenOkuma.Read() )
			{
				LblGecenSayisi.Text = gecenOkuma[0].ToString();
			}
			baglanti.Close();
			baglanti.Open();

			SqlCommand kalanSayisi = new SqlCommand("select count(*) from TBLDERS where DURUM=0", baglanti);
			SqlDataReader kalanOkuma = kalanSayisi.ExecuteReader();


			while (kalanOkuma.Read())
			{
				LblKalanSayisi.Text = kalanOkuma[0].ToString();
			}

			this.tBLDERSTableAdapter.Fill(this.dbNotKayitDataSet.TBLDERS);
			baglanti.Close();
		}

	}
}
