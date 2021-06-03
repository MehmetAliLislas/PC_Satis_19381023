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
	public partial class Stok : Form
	{
		public Stok()
		{
			InitializeComponent();
		}

		OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\PC_Satis_19381023.accdb");
		OleDbCommand komut;

		private void Stok_Load(object sender, EventArgs e) { }

		private void btnstkkyt_Click(object sender, EventArgs e)
		{
			if (txtstokadet.Text.Length > 0 && txtstokadet.Text != "0")
			{
				connection.Open();
				komut = new OleDbCommand("INSERT INTO Stok (stok_urun_ID,stok_ALIM_TARIH,stok_ALIM_ADET,stok_ALIM_FIYAT) values ('" + txtstokid.Text + "','" + dateTimePicker1.Value.ToString() + "','" + txtstokadet.Text + "','" + txtstokfiyat.Text + "')", connection);
				komut.ExecuteNonQuery();
				connection.Close();
			}
			else
			{
				MessageBox.Show("Stok miktarını yazınız...", "Uyarı");
			}
		}
	}
}