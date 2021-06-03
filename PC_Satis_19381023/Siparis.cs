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
	public partial class Siparis : Form
	{
		public Siparis()
		{
			InitializeComponent();
		}

		OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\PC_Satis_19381023.accdb");
		OleDbCommand komut;

		private void Siparis_Load(object sender, EventArgs e) { }

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnmstekle_Click(object sender, EventArgs e)
		{
			if (txtsiparisfiyat.Text.Length > 0 && txtsiparisfiyat.Text != "0")
			{
				connection.Open();
				komut = new OleDbCommand("INSERT INTO Siparis (siparis_MUSTERI_ID,siparis_URUN_ID,siparis_FIYAT,siparis_TARIH,siparis_TESLIM_TARIH,siparis_ADET,siparis_PUAN) values ('" + txtsiparismustid.Text + "','" + txtsiparisurunid.Text + "','" + txtsiparisfiyat.Text + "','" + dateTimePicker1.Value.ToString() + "','" + dateTimePicker2.Value.ToString() + "', '" + txtsiparisadet.Text + "', '" + comboBox1.Text + "')", connection);
				komut.ExecuteNonQuery();
				connection.Close();
			}
			else
			{
				MessageBox.Show("Lütfen geçerli fiyat giriniz.", "Uyarı");
			}
		}

		private void btnmstsil_Click(object sender, EventArgs e)
		{
			if (textBox2.Text.Length > 0 && textBox2.Text != "Sipariş iptal sebebini yazınız...")
			{
				string update = "UPDATE Siparis SET siparis_IPTAL = @siparis_IPTAL WHERE siparis_ID = @id";
				connection.Open();
				OleDbCommand komut = new OleDbCommand(update);
				komut.Connection = connection;
				komut.Parameters.Add("@siparis_IPTAL", textBox2.Text);
				komut.Parameters.Add("@id", textBox3.Text);
				komut.ExecuteNonQuery();
				connection.Close();
			}
			else
			{
				MessageBox.Show("Lütfen sipariş iptal nedenini yazınız...", "Uyarı");
			}
		}

		private void txtsiparisurunid_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox2_MouseClick(object sender, MouseEventArgs e)
		{
			textBox2.Clear();
		}

		private void comboBox1_KeyDown(object sender, KeyEventArgs e)
		{
			e.SuppressKeyPress = true; //COMBOBOX READONLY//     
		}
	}
}