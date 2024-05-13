using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alıştırma
{
    public partial class Finance : Form
    {

        public Finance()
        {

            InitializeComponent();

        }

        ConnectClass Cnc = new ConnectClass();


        private void btnGelirEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Cnc.ConnectAdress);
                conn.Open();
                string sorgu = "insert into tblGelir (Tarih,Maas,Altın,Borsa,Mesai,[Döviz Geliri]) values (@P1,@P2,@P3,@P4,@P5,@P6)";
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@P1", txtTarih.Text);
                cmd.Parameters.AddWithValue("@P2", numericUpDownMaas.Value);
                cmd.Parameters.AddWithValue("@P3", numericUpDownAltın.Value);
                cmd.Parameters.AddWithValue("@P4", numericUpDownBorsa.Value);
                cmd.Parameters.AddWithValue("@P5", numericUpDownMesai.Value);
                cmd.Parameters.AddWithValue("@P6", numericUpDownDövizGelir.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşlem Başarılı");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }


        private void btnGiderEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Cnc.ConnectAdress);
                conn.Open();
                string sorgu = "insert into tblGider (Kira,Sigara,Ulaşım,[Borsa Gideri],Altın,[Elektrik Faturası],[Doğalgaz Faturası],[Su Faturası],Eğlence,Tarih,[Telefon Faturası],[İnternet Faturası]) values(@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9,@P10,@P11,@P12)";
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@P1", numericUpDownKira.Value);
                cmd.Parameters.AddWithValue("@P2", numericUpDownSigara.Value);
                cmd.Parameters.AddWithValue("@P3", numericUpDownUlasim.Value);
                cmd.Parameters.AddWithValue("@P4", numericUpDownBorsaGider.Value);
                cmd.Parameters.AddWithValue("@P5", numericUpDownAltınGider.Value);
                cmd.Parameters.AddWithValue("@P6", numericUpDownElkFatura.Value);
                cmd.Parameters.AddWithValue("@P7", numericUpDownDgazFat.Value);
                cmd.Parameters.AddWithValue("@P8", numericUpDownSuFat.Value);
                cmd.Parameters.AddWithValue("@P9", numericUpDownEglence.Value);
                cmd.Parameters.AddWithValue("@P10", textBoxTarih.Text);
                cmd.Parameters.AddWithValue("@P11", numericUpDownTlfFatura.Value);
                cmd.Parameters.AddWithValue("@P12", numericUpDownIntFatura.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşlem Başarılı");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void buttonToplamGider_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Cnc.ConnectAdress);
                conn.Open();
                DateTime bugün = DateTime.Today;
                string sorgu = "SELECT SUM(Kira) + SUM(Sigara) + SUM(Ulaşım) + SUM([Borsa Gideri]) + SUM(Altın) + SUM([Elektrik Faturası]) + SUM([Su Faturası]) + SUM([Doğalgaz Faturası]) + SUM(Eğlence)+SUM([Telefon Faturası]) + SUM([İnternet Faturası]) FROM tblGider WHERE Tarih = @P1";
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@P1", bugün);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBoxToplamGider.Text = reader[0].ToString() + " TL";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }



        private void BtnAylkGidr_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Cnc.ConnectAdress);
                conn.Open();
                DateTime now = DateTime.Now;
                DateTime ay = new DateTime(now.Year, now.Month, 1);
                DateTime aySonu = ay.AddMonths(1).AddDays(-1);
                string sorgu = "SELECT SUM(Kira) + SUM(Sigara) + SUM(Ulaşım) + SUM([Borsa Gideri]) + SUM(Altın) + SUM([Elektrik Faturası]) + SUM([Su Faturası]) + SUM([Doğalgaz Faturası]) + SUM(Eğlence)+SUM([Telefon Faturası]) + SUM([İnternet Faturası]) FROM tblGider WHERE Tarih Between @P1 and @P2";
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@P1", ay);
                cmd.Parameters.AddWithValue("@P2", aySonu);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBoxAylıkGider.Text = reader[0].ToString() + " TL";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btnGünlükGelir_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Cnc.ConnectAdress);
                conn.Open();

                string sorgu = "select sum(Maas)+sum(Altın)+sum(Borsa)+Sum(Mesai) from tblGelir where Tarih=@P1";
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@P1", DateTime.Today);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBoxGünlükGelir.Text = dr[0].ToString() + " TL";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btnAylıkGelir_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Cnc.ConnectAdress);
                conn.Open();
                DateTime now = DateTime.Now;
                DateTime ay = new DateTime(now.Year, now.Month, 1);
                DateTime aysonu = ay.AddMonths(1).AddDays(-1);
                string sorgu = "select sum(Maas)+sum(Maas)+sum(Altın)+sum(Borsa)+sum(Borsa)+Sum(Mesai) from tblGelir where Tarih between @P1 and @P2";
                SqlCommand cmd = new SqlCommand(sorgu, conn);

                cmd.Parameters.AddWithValue("@P1", ay);
                cmd.Parameters.AddWithValue("@P2", aysonu);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    textBoxAylıkGelir.Text = dr[0].ToString();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }


        private void btnGelir_Click(object sender, EventArgs e)
        {
            Tablolar tbl = new Tablolar();
            tbl.Show();
            this.Hide();
        }

        private void btnAltınİslemleri_Click(object sender, EventArgs e)
        {
            Altınİslemleri alt = new Altınİslemleri();
            alt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mesaiİslemleri mi = new Mesaiİslemleri();
            mi.Show();
            this.Hide();
        }


    }
}
