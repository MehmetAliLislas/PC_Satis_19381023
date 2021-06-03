using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PC_Satis_19381023
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public void DataGridviewTasarim(DataGridView dataGridView)  //TASARIM//
		{
			dataGridView1.AllowUserToResizeRows = false;
			dataGridView1.AllowUserToResizeColumns = false;
			dataGridView.ForeColor = Color.Snow;
			dataGridView.RowHeadersVisible = false;
			dataGridView.BorderStyle = BorderStyle.None;
			dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(42, 47, 50);
			dataGridView.DefaultCellStyle.SelectionBackColor = Color.Black;
			dataGridView.EnableHeadersVisualStyles = false;
			dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
			dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(42, 47, 50);
			dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Snow;
			dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			DataGridviewTasarim(dataGridView1);
			this.Size = new Size(1475, 630);
			this.CenterToScreen();
			btnsiplist.BackColor = this.BackColor;
			btnsiplist.ForeColor = Color.Snow;
			btnurunlist.BackColor = this.BackColor;
			btnurunlist.ForeColor = Color.Snow;
			btnmustlist.BackColor = this.BackColor;
			btnmustlist.ForeColor = Color.Snow;
			btnstoklist.BackColor = this.BackColor;
			btnstoklist.ForeColor = Color.Snow;
		}

		OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\PC_Satis_19381023.accdb");
		OleDbCommand komut;
		OleDbDataAdapter adtr;
		DataTable table = new DataTable();

		private void textBox12_Click(object sender, EventArgs e)
		{
			txtkayitarama.Clear();
		}

		private void btnmustlist_MouseEnter(object sender, EventArgs e)
		{
			btnmustlist.BackColor = Color.Lavender;
			btnmustlist.ForeColor = Color.Black;
		}

		private void btnsiplist_MouseEnter(object sender, EventArgs e)
		{
			btnsiplist.BackColor = Color.Lavender;
			btnsiplist.ForeColor = Color.Black;
		}

		private void btnurunlist_MouseEnter(object sender, EventArgs e)
		{
			btnurunlist.BackColor = Color.Lavender;
			btnurunlist.ForeColor = Color.Black;
		}

		private void btnstoklist_MouseEnter(object sender, EventArgs e)
		{
			btnstoklist.BackColor = Color.Lavender;
			btnstoklist.ForeColor = Color.Black;
		}

		private void btnmustlist_MouseLeave(object sender, EventArgs e)
		{
			btnmustlist.BackColor = this.BackColor;
			btnmustlist.ForeColor = Color.Snow;
		}

		private void btnurunlist_MouseLeave(object sender, EventArgs e)
		{
			btnurunlist.BackColor = this.BackColor;
			btnurunlist.ForeColor = Color.Snow;
		}

		private void btnstoklist_MouseLeave(object sender, EventArgs e)
		{
			btnstoklist.BackColor = this.BackColor;
			btnstoklist.ForeColor = Color.Snow;
		}

		private void btnsiplist_MouseLeave(object sender, EventArgs e)
		{
			btnsiplist.BackColor = this.BackColor;
			btnsiplist.ForeColor = Color.Snow;
		}

		//GLOBAL DEĞİŞKEN TANIMLAMA//
		int musteri;
		int urunid;
		int siparisid;
		//GLOBAL DEĞİŞKEN TANIMLAMA//

		private void btnsiparisekran_Click(object sender, EventArgs e)
		{
			Siparis siparis = new Siparis();
			siparis.txtsiparismustid.Text = musteri.ToString();
			siparis.txtsiparisurunid.Text = urunid.ToString();
			siparis.textBox1.Text = urunid.ToString();
			siparis.textBox3.Text = siparisid.ToString();   //SİPARİŞ FORMUNDA İPTAL NEDENİNDE KULLANILACAK OLAN SIPARIS ID VERİSİ//
			if (dataGridView1.AccessibleName == "siparis")
			{
				int siparisid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["siparis_ID"].Value.ToString());
				siparis.textBox3.Text = siparisid.ToString();
			}

			siparis.Show();
		}

		private void btnstokpanel_Click(object sender, EventArgs e)
		{
			Stok stok = new Stok();
			stok.Show();
			if (dataGridView1.AccessibleName == "ürün")
			{
				int siparis = Convert.ToInt32(dataGridView1.CurrentRow.Cells["urun_ID"].Value.ToString());
				stok.txtstokid.Text = siparis.ToString();
			}
		}

		private void btnmustlist_Click(object sender, EventArgs e)
		{
			dataGridView1.AccessibleName = "musteri";
			musterilistele();
			dataGridView1.Columns[0].Visible = false;
			//dataGridView1.Columns[0].HeaderText = "Müşteri ID";
			dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
			dataGridView1.Columns[2].HeaderText = "Müşteri Soyadı";
			dataGridView1.Columns[3].HeaderText = "Müşteri Telefon";
			dataGridView1.Columns[4].HeaderText = "Müşteri Adres";
		}

		private void btnurunlist_Click(object sender, EventArgs e)
		{
			dataGridView1.AccessibleName = "ürün";
			urunlistele();
			dataGridView1.Columns[0].Visible = true;
			dataGridView1.Columns[0].HeaderText = "Ürün ID";
			dataGridView1.Columns[1].HeaderText = "Ürün Adı";
			dataGridView1.Columns[2].HeaderText = "Ürün Stok";
			dataGridView1.Columns[3].HeaderText = "Ürün Fiyat";
			dataGridView1.Columns[4].HeaderText = "Ürün CPU";
			dataGridView1.Columns[5].HeaderText = "Ürün GPU";
			dataGridView1.Columns[6].HeaderText = "Ürün RAM";
			dataGridView1.Columns[7].HeaderText = "Ürün Disk";
			dataGridView1.Columns[0].Width = 60;
		}

		private void btnstoklist_Click(object sender, EventArgs e)
		{
			stoklistele();
			dataGridView1.Columns[0].Visible = false;
			// dataGridView1.Columns[0].HeaderText = "STOK ID";
			dataGridView1.Columns[1].HeaderText = "Ürün ID";
			dataGridView1.Columns[2].HeaderText = "Alım Tarihi";
			dataGridView1.Columns[3].HeaderText = "Alım Adedi";
			dataGridView1.Columns[4].HeaderText = "Alım Fiyatı";
		}

		private void musterilistele() 
		{
			table.Clear();
			connection.Open();
			komut = new OleDbCommand("Select *from Musteri ", connection);
			DataTable tablemusteri = new DataTable();
			adtr = new OleDbDataAdapter(komut);
			adtr.Fill(tablemusteri);
			dataGridView1.DataSource = tablemusteri;
			connection.Close();
		}

		public int count(string telefonno) //MUKERRER KAYIT ENGELLEME//
		{
			int sonuc;
			connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\PC_Satis_19381023.accdb");
			string sorgu = "Select COUNT (musteri_TELNO) from Musteri WHERE musteri_TELNO='" + telefonno + "'";
			komut = new OleDbCommand(sorgu, connection);
			connection.Open();
			sonuc = Convert.ToInt32(komut.ExecuteScalar());
			connection.Close();
			return sonuc;
		}

		private void btnmstekle_Click(object sender, EventArgs e)
		{
			if (txtmustad.Text.Length == 0 || txtmustno.Text.Length == 0 || txtmustsehir.Text.Length == 0 || txtmustsoyad.Text.Length == 0)
			{
				MessageBox.Show("Lütfen bütün gerekli alanları doldurunuz...", "Uyarı");
			}
			else if (count(txtmustno.Text) != 0)//AYNI MUSTERI VAR İSE ===>
			{
				MessageBox.Show("Bu telefon numarası ile daha önce kayıt yapılmış...", "Uyarı");
			}
			else
			{
				connection.Open();
				komut = new OleDbCommand("INSERT INTO Musteri (musteri_AD,musteri_SOYAD,musteri_TELNO,musteri_ADRES) values ('" + txtmustad.Text + "','" + txtmustsoyad.Text + "','" + txtmustno.Text + "','" + txtmustsehir.Text + "')", connection);
				komut.ExecuteNonQuery();
				connection.Close();
				musterilistele();
				txtmustad.Clear();
				txtmustno.Clear();
				txtmustsoyad.Clear();
				txtmustsehir.Clear();
			}
		}

		private void btnmstsil_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
				{
					int mustid = Convert.ToInt32(drow.Cells[0].Value);
					MusteriSil(mustid);
				}

				musterilistele();
			}
			else
			{
				MessageBox.Show("Lütfen silinecek satırı seçiniz..");
			}

			return;
		}

		private void txtkayitarama_TextChanged(object sender, EventArgs e)
		{
			table.Clear();
			connection.Open();
			komut = new OleDbCommand("Select * from Musteri where musteri_AD like '" + txtkayitarama.Text + "%' or musteri_ID like '" + txtkayitarama.Text + "%'", connection);
			DataTable table2 = new DataTable();
			adtr = new OleDbDataAdapter(komut);
			adtr.Fill(table2);
			dataGridView1.DataSource = table2;
			connection.Close();
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridView1.AccessibleName == "musteri")
			{
				string musteriad = dataGridView1.CurrentRow.Cells["musteri_AD"].Value.ToString();
				string musterisoyad = dataGridView1.CurrentRow.Cells["musteri_SOYAD"].Value.ToString();
				string musterino = dataGridView1.CurrentRow.Cells["musteri_TELNO"].Value.ToString();
				string musterisehir = dataGridView1.CurrentRow.Cells["musteri_ADRES"].Value.ToString();
				string musteriid = dataGridView1.CurrentRow.Cells["musteri_ID"].Value.ToString();

				txtmustad.Text = musteriad;
				txtmustsoyad.Text = musterisoyad;
				txtmustno.Text = musterino;
				txtmustsehir.Text = musterisehir;
				txtid.Text = musteriid;
				musteri = Convert.ToInt32(dataGridView1.CurrentRow.Cells["musteri_ID"].Value.ToString());
			}

			if (dataGridView1.AccessibleName == "ürün")
			{
				txturunid.Text = dataGridView1.CurrentRow.Cells["urun_ID"].Value.ToString();
				txturunad.Text = dataGridView1.CurrentRow.Cells["urun_AD"].Value.ToString();
				txturuncpu.Text = dataGridView1.CurrentRow.Cells["urun_CPU"].Value.ToString();
				txturundisk.Text = dataGridView1.CurrentRow.Cells["urun_DISK"].Value.ToString();
				txturunfiyat.Text = dataGridView1.CurrentRow.Cells["urun_FIYAT"].Value.ToString();
				txturunram.Text = dataGridView1.CurrentRow.Cells["urun_RAM"].Value.ToString();
				txturungpu.Text = dataGridView1.CurrentRow.Cells["urun_GPU"].Value.ToString();
				txturunstok.Text = dataGridView1.CurrentRow.Cells["urun_STOK"].Value.ToString();
				urunid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["urun_ID"].Value.ToString());
			}
		}

		private void urunlistele()
		{
			table.Clear();
			connection.Open();
			komut = new OleDbCommand("Select *from Urun ", connection);
			DataTable tableurun = new DataTable();
			adtr = new OleDbDataAdapter(komut);
			adtr.Fill(tableurun);
			dataGridView1.DataSource = tableurun;
			connection.Close();
		}

		private void siparislistele()
		{
			table.Clear();
			connection.Open();
			komut = new OleDbCommand("Select *from Siparis ", connection);
			DataTable tablesiparis = new DataTable();
			adtr = new OleDbDataAdapter(komut);
			adtr.Fill(tablesiparis);
			dataGridView1.DataSource = tablesiparis;
			connection.Close();
		}

		private void stoklistele()
		{
			table.Clear();
			connection.Open();
			komut = new OleDbCommand("Select *from Stok ", connection);
			DataTable tablestok = new DataTable();
			adtr = new OleDbDataAdapter(komut);
			adtr.Fill(tablestok);
			dataGridView1.DataSource = tablestok;
			connection.Close();
		}

		private void btnurnekle_Click(object sender, EventArgs e)
		{
			if (txturunad.Text.Length == 0 || txturuncpu.Text.Length == 0 || txturundisk.Text.Length == 0 || txturungpu.Text.Length == 0 || txturunram.Text.Length == 0 || txturunfiyat.Text.Length == 0 || txturunstok.Text.Length == 0)
			{
				MessageBox.Show("Lütfen bütün gerekli alanları doldurunuz...", "Uyarı");
			}
			else
			{
				connection.Open();
				komut = new OleDbCommand("INSERT INTO Urun (urun_AD,urun_STOK,urun_FIYAT,urun_CPU,urun_GPU,urun_RAM,urun_DISK) values ('" + txturunad.Text + "','" + txturunstok.Text + "','" + txturunfiyat.Text + "','" + txturuncpu.Text + "','" + txturungpu.Text + "', '" + txturunram.Text + "', '" + txturundisk.Text + "')", connection);
				komut.ExecuteNonQuery();
				connection.Close();
				urunlistele();
				txturunad.Clear();
				txturuncpu.Clear();
				txturundisk.Clear();
				txturungpu.Clear();
				txturunram.Clear();
				txturunstok.Clear();
				txturunfiyat.Clear();
			}
		}

		private void btnsiplist_Click(object sender, EventArgs e)
		{
			dataGridView1.AccessibleName = "siparis";
			siparislistele();
			dataGridView1.Columns[0].Visible = false;
			// dataGridView1.Columns[0].HeaderText = "Sipariş ID";
			dataGridView1.Columns[1].HeaderText = "Müşteri ID";
			dataGridView1.Columns[2].HeaderText = "Ürün ID";
			dataGridView1.Columns[3].HeaderText = "Sipariş Fiyatı";
			dataGridView1.Columns[4].HeaderText = "Sipariş Edilen Tarih";
			dataGridView1.Columns[5].HeaderText = "Teslim Tarihi";
			dataGridView1.Columns[6].HeaderText = "Sipariş Adedi";
			dataGridView1.Columns[7].HeaderText = "Sipariş Puan";
			dataGridView1.Columns[8].HeaderText = "Sipariş İptal Nedeni";
			dataGridView1.Columns[1].Width = 60;
			dataGridView1.Columns[2].Width = 60;
			dataGridView1.Columns[3].Width = 100;
			dataGridView1.Columns[6].Width = 60;
			dataGridView1.Columns[7].Width = 60;
		}

		void UrunSil(int num)
		{
			string oledb = "DELETE FROM Urun WHERE urun_ID=@urun_ID";
			komut = new OleDbCommand(oledb, connection);
			komut.Parameters.AddWithValue("@num", num);
			connection.Open();
			komut.ExecuteNonQuery();
			connection.Close();
		}

		private void btnmstgnc_Click(object sender, EventArgs e)
		{
			if (txtmustad.Text.Length == 0 || txtmustno.Text.Length == 0 || txtmustsehir.Text.Length == 0 || txtmustsoyad.Text.Length == 0)
			{
				MessageBox.Show("Lütfen bütün alanları doldurunuz...", "Uyarı");
			}
			else
			{
				connection.Open();
				komut = new OleDbCommand("UPDATE Musteri SET musteri_AD='" + txtmustad.Text + "', musteri_SOYAD='" + txtmustsoyad.Text + "', musteri_TELNO= '" + txtmustno.Text + "',  musteri_ADRES='" + txtmustsehir.Text + "' where musteri_ID=" + txtid.Text + "", connection);
				komut.ExecuteNonQuery();
				connection.Close();
				musterilistele();
				txtmustad.Clear();
				txtmustno.Clear();
				txtmustsoyad.Clear();
				txtmustsehir.Clear();
			}
		}

		private void btnurnsil_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
				{
					int numara = Convert.ToInt32(drow.Cells[0].Value);
					UrunSil(numara);
				}

				urunlistele();
			}
			else MessageBox.Show("Lütfen silinecek satırı seçiniz..");
		}

		void MusteriSil(int num)
		{
			string oledb = "DELETE FROM Musteri WHERE musteri_ID=@musteri_ID";
			komut = new OleDbCommand(oledb, connection);
			komut.Parameters.AddWithValue("@num", num);
			connection.Open();
			komut.ExecuteNonQuery();
			connection.Close();
		}

		private void btnurngnc_Click(object sender, EventArgs e)
		{
			if (txturunad.Text.Length == 0 || txturuncpu.Text.Length == 0 || txturundisk.Text.Length == 0 || txturungpu.Text.Length == 0 || txturunram.Text.Length == 0 || txturunfiyat.Text.Length == 0 || txturunstok.Text.Length == 0)
			{
				MessageBox.Show("Lütfen bütün gerekli alanları doldurunuz...", "Uyarı");
			}
			else
			{
				string urungunc = "UPDATE Urun SET urun_AD = @adi, urun_STOK = @stok, urun_FIYAT= @fiyat, urun_CPU=@cpu, urun_GPU=@gpu, urun_RAM=@ram, urun_DISK=@disk WHERE urun_ID = @id ";
				connection.Open();
				OleDbCommand komut = new OleDbCommand(urungunc);
				komut.Connection = connection;
				komut.Parameters.Add("@adi", txturunad.Text);
				komut.Parameters.Add("@stok", txturunstok.Text);
				komut.Parameters.Add("@fiyat", txturunfiyat.Text);
				komut.Parameters.Add("@cpu", txturuncpu.Text);
				komut.Parameters.Add("@gpu", txturungpu.Text);
				komut.Parameters.Add("@ram", txturunram.Text);
				komut.Parameters.Add("@disk", txturundisk.Text);
				komut.Parameters.Add("@id", txturunid.Text);
				komut.ExecuteNonQuery();
				connection.Close();
				urunlistele();
				txturunad.Clear();
				txturuncpu.Clear();
				txturundisk.Clear();
				txturungpu.Clear();
				txturunram.Clear();
				txturunstok.Clear();
				txturunfiyat.Clear();
			}
		}
	}
}