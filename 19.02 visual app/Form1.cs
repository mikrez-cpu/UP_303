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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.докладTableAdapter.Fill(this._19_02DataSet.Доклад);
            this.организацияTableAdapter.Fill(this._19_02DataSet.организация);
            this.конференцииTableAdapter.Fill(this._19_02DataSet.конференции);
            this.учёныеTableAdapter.Fill(this._19_02DataSet.учёные);

        }
        Form2 form2 = new Form2();

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
