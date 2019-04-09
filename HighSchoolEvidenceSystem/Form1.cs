using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace HighSchoolEvidenceSystem
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        SqlDataAdapter da;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source = ZAX\LOISLANESQL; Initial Catalog = lois; Integrated Security = True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO LoginPassword (Login, Password) VALUES (@LOGIN, @PASSWORD)", con);
            cmd.Parameters.AddWithValue("@LOGIN", textBox1.Text);
            cmd.Parameters.AddWithValue("@PASSWORD", textBox2.Text);
            cmd.ExecuteNonQuery();
            //this.Hide();
            //SnakeGame.SnakeGame main = new SnakeGame.SnakeGame();
            //main.Show();
        }
    }
}
