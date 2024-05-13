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
using static Alıştırma.Finance;

namespace Alıştırma
{
    public partial class Mesaiİslemleri : Form
    {
        public Mesaiİslemleri()
        {
            InitializeComponent();

        }
        ConnectClass Cnc = new ConnectClass();
        private void Mesaiİslemleri_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Cnc.ConnectAdress);
                conn.Open();
                string sorgu = "select top 7 Günler from Mesai";
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBoxGün.Items.Add(reader[0]);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Cnc.ConnectAdress);
                conn.Open();
                double maas = (double)numericUpDownMaas.Value;
                double saatlikFiyat = maas / 240;
                double maasSaatCarpilmisHali;
                double mesai;

                if (comboBoxGün.SelectedItem.ToString() == "Pazar")
                {
                    maasSaatCarpilmisHali = (double)numericUpDownSaat.Value * 2;
                    mesai = maasSaatCarpilmisHali * saatlikFiyat;
                    numericUpDownGunDeger.Value = ((decimal)mesai);

                }
                else
                {
                    maasSaatCarpilmisHali = (double)numericUpDownSaat.Value * 1.5;
                    mesai = maasSaatCarpilmisHali * saatlikFiyat;
                    numericUpDownGunDeger.Value = ((decimal)mesai);
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void BtnTabloyaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Cnc.ConnectAdress);
                conn.Open();
                string sorgu = "insert into Mesai(Günler,[Mesai Saati],[Mesai Parası],Tarih) values (@P1,@P2,@P3,@P4)";
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@P1", comboBoxGün.Text);
                cmd.Parameters.AddWithValue("@P2", numericUpDownSaat.Value);
                cmd.Parameters.AddWithValue("@P3", numericUpDownGunDeger.Value);
                cmd.Parameters.AddWithValue("@P4", txtTarih.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşlem Başarıyla Tamamlandı.");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btnAylıkDegerler_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Cnc.ConnectAdress);

                conn.Open();
                DateTime now = DateTime.Now;
                DateTime ay = new DateTime(now.Year, now.Month, 1);
                DateTime aysonu = ay.AddMonths(1).AddDays(-1);
                string sorgu2 = "select sum([Mesai Parası]) from Mesai where tarih between @P1 and @P2";
                SqlCommand cmd2 = new SqlCommand(sorgu2, conn);
                cmd2.Parameters.AddWithValue("@P1", ay);
                cmd2.Parameters.AddWithValue("@P2", aysonu);
                cmd2.ExecuteNonQuery();
                SqlDataReader reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    txtAyDeger.Text = reader[0].ToString();
                }
                conn.Close();

                conn.Open();
                string sorgu3 = "select sum([Mesai Saati]) from Mesai";
                SqlCommand cmd3 = new SqlCommand(sorgu3, conn);
                SqlDataReader reader2 = cmd3.ExecuteReader();
                while (reader2.Read())
                {
                    txtAylıkSaat.Text = reader2[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void buttonBackward_Click(object sender, EventArgs e)
        {
            Finance anasayfa = new Finance();
            anasayfa.Show();
            this.Close();
        }
    }
}
