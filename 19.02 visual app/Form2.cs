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

namespace _19._02_visual_app
{
    public partial class Form2 : Form
    {
        string conn_string = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Education=19.02 Тульгук\visual app\19.02.mdf;Integrated Security=True;Pooling=False";

        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmd_text = "SELECT * FROM 11_02.доклад WHERE Дата_доклада = 1999;";
            SqlConnection con = new SqlConnection(conn_string);
            SqlCommand sql_comm = new SqlCommand(cmd_text, con);
            con.Open();
            sql_comm.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmd_text = "SELECT * FROM 11_02.конференции;";
            SqlConnection con = new SqlConnection(conn_string);
            SqlCommand sql_comm = new SqlCommand(cmd_text, con);
            con.Open();
            sql_comm.ExecuteNonQuery();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cmd_text = "SELECT * FROM 11_02.учёные WHERE idКонференции IS NOT NULL;";
            SqlConnection con = new SqlConnection(conn_string);
            SqlCommand sql_comm = new SqlCommand(cmd_text, con);
            con.Open();
            sql_comm.ExecuteNonQuery();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cmd_text = "SELECT * FROM 11_02.конференции WHERE Место_проведения IS NOT NULL; ";
            SqlConnection con = new SqlConnection(conn_string);
            SqlCommand sql_comm = new SqlCommand(cmd_text, con);
            con.Open();
            sql_comm.ExecuteNonQuery();
            con.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
