using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Alıştırma.Finance;

namespace Alıştırma
{
    public partial class Altınİslemleri : Form
    {

        public Altınİslemleri()
        {
            InitializeComponent();


        }


        ConnectClass Cnc = new ConnectClass();
        private void Altınİslemleri_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Cnc.ConnectAdress);
                conn.Open();
                SqlCommand cmd = new SqlCommand("select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='tblAltın'", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader[0].ToString());
                    comboBox2.Items.Add(reader[0].ToString());
                }

                conn.Close();

                conn.Open();
                string sorgu = "select sum(CumhuriyetAltını),sum(YarımAltın),sum(CeyrekAltın),sum(GramAltın) from tblAltın";
                SqlCommand cmd2 = new SqlCommand(sorgu, conn);
                SqlDataReader reader1 = cmd2.ExecuteReader();
                while (reader1.Read())
                {
                    chart1.Series["Miktar"].Points.AddXY("Cumhuriyet Altını", reader1[0]);
                    chart1.Series["Miktar"].Points.AddXY("Yarım Altın", reader1[1]);
                    chart1.Series["Miktar"].Points.AddXY("Çeyrek Altın", reader1[2]);
                    chart1.Series["Miktar"].Points.AddXY("Gram Altın", reader1[3]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btnAltınEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Cnc.ConnectAdress);
                conn.Open();
                string secilenAltınTürü = comboBox1.SelectedItem.ToString();
                string sorgu = "Update tblAltın Set " + secilenAltınTürü + "=" + secilenAltınTürü + "+@P1";
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@P1", numericUpDownAltınAdet.Value);
                cmd.ExecuteNonQuery();
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
                if (comboBox2.SelectedItem.ToString() == "CumhuriyetAltını")
                {
                    string sorgu = "select CumhuriyetAltını*@P1 from tblAltın";
                    SqlCommand cmd = new SqlCommand(sorgu, conn);
                    cmd.Parameters.AddWithValue("@P1", numericUpDownCumAltınDeger.Value);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        textBoxHesapla.Text = reader[0].ToString() + " TL";
                    }
                }
                else if (comboBox2.SelectedItem.ToString() == "YarımAltın")
                {
                    string sorgu = "select YarımAltın*@P1 from tblAltın";
                    SqlCommand cmd = new SqlCommand(sorgu, conn);
                    cmd.Parameters.AddWithValue("@P1", numericUpDownYarimDeger.Value);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        textBoxHesapla.Text = reader[0].ToString() + " TL";
                    }
                }
                else if (comboBox2.SelectedItem.ToString() == "CeyrekAltın")
                {
                    string sorgu = "select CeyrekAltın*@P1 from tblAltın";
                    SqlCommand cmd = new SqlCommand(sorgu, conn);
                    cmd.Parameters.AddWithValue("@P1", numericUpDownCeyrekDeger.Value);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        textBoxHesapla.Text = reader[0].ToString() + " TL";
                    }
                }
                else if (comboBox2.SelectedItem.ToString() == "GramAltın")
                {
                    string sorgu = "select GramAltın*@P1 from tblAltın";
                    SqlCommand cmd = new SqlCommand(sorgu, conn);
                    cmd.Parameters.AddWithValue("@P1", numericUpDownGramDeger.Value);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        textBoxHesapla.Text = reader[0].ToString() + " TL";
                    }
                }
                else
                    MessageBox.Show("Yanlış Seçim Yaptınız");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btnToplamHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Cnc.ConnectAdress);
                conn.Open();
                string sorgu = "select sum(CumhuriyetAltını*@P1)+sum(YarımAltın*@P2)+sum(CeyrekAltın*@P3)+sum(GramAltın*@P4) from tblAltın";
                SqlCommand cmd = new SqlCommand(sorgu, conn);
                cmd.Parameters.AddWithValue("@P1", numericUpDownCumAltınDeger.Value);
                cmd.Parameters.AddWithValue("@P2", numericUpDownYarimDeger.Value);
                cmd.Parameters.AddWithValue("@P3", numericUpDownCeyrekDeger.Value);
                cmd.Parameters.AddWithValue("@P4", numericUpDownGramDeger.Value);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    textBoxToplamHesapla.Text = reader[0].ToString() + " TL";
                }
                conn.Close();
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
