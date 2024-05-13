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
    public partial class Tablolar : Form
    {
        public Tablolar()
        {
            InitializeComponent();
        }
        ConnectClass Cnc = new ConnectClass();


        private void Tablolar_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(Cnc.ConnectAdress);
                conn.Open();
                DateTime now = DateTime.Now;
                DateTime ay = new DateTime(now.Year, now.Month, 1);
                DateTime aysonu = ay.AddMonths(1).AddDays(-1);
                string sorgu = "select sum(Maas),sum(Altın),sum(Borsa),Sum(Mesai),Sum([Döviz Geliri]) from tblGelir where Tarih between @P1 and @P2";
                SqlCommand cmd = new SqlCommand(sorgu, conn);

                cmd.Parameters.AddWithValue("@P1", ay);
                cmd.Parameters.AddWithValue("@P2", aysonu);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chart1.Series["Gelir Miktarı"].Points.AddXY("Maas", reader[0]);
                    chart1.Series["Gelir Miktarı"].Points.AddXY("Altın Geliri", reader[1]);
                    chart1.Series["Gelir Miktarı"].Points.AddXY("Borsa Geliri", reader[2]);
                    chart1.Series["Gelir Miktarı"].Points.AddXY("Mesai Geliri", reader[3]);
                    chart1.Series["Gelir Miktarı"].Points.AddXY("Döviz Geliri", reader[4]);

                }
                conn.Close();
                conn.Open();
                DateTime now2 = DateTime.Now;
                DateTime ay2 = new DateTime(now2.Year, now2.Month, 1);
                DateTime aysonu2 = ay2.AddMonths(1).AddDays(-1);
                string sorgu2 = "SELECT SUM(Kira) , SUM(Sigara) , SUM(Ulaşım) , SUM([Borsa Gideri]) , SUM(Altın) , SUM([Elektrik Faturası]) , SUM([Su Faturası]) , SUM([Doğalgaz Faturası]) , SUM(Eğlence), SUM([Telefon Faturası]),SUM([İnternet Faturası]) FROM tblGider WHERE Tarih Between @P1 and @P2";
                SqlCommand cmd2 = new SqlCommand(sorgu2, conn);
                cmd2.Parameters.AddWithValue("@P1", ay2);
                cmd2.Parameters.AddWithValue("@P2", aysonu2);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    chart2.Series["Gider Miktarı"].Points.AddXY("Kira", reader2[0]);
                    chart2.Series["Gider Miktarı"].Points.AddXY("Sigara", reader2[1]);
                    chart2.Series["Gider Miktarı"].Points.AddXY("Ulaşım", reader2[2]);
                    chart2.Series["Gider Miktarı"].Points.AddXY("Borsa Gideri", reader2[3]);
                    chart2.Series["Gider Miktarı"].Points.AddXY("Altın Gideri", reader2[4]);
                    chart2.Series["Gider Miktarı"].Points.AddXY("Elektrik Faturası", reader2[5]);
                    chart2.Series["Gider Miktarı"].Points.AddXY("Doğalgaz Faturası", reader2[6]);
                    chart2.Series["Gider Miktarı"].Points.AddXY("Su Faturası", reader2[7]);
                    chart2.Series["Gider Miktarı"].Points.AddXY("Eğlence", reader2[8]);
                    chart2.Series["Gider Miktarı"].Points.AddXY("Telefon Faturası", reader2[9]);
                    chart2.Series["Gider Miktarı"].Points.AddXY("İnternet Faturası", reader2[10]);

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
