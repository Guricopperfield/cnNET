using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;
namespace cnnet
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void addNewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox5.Visible = false;
            textBox4.Visible = false;
            groupBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionstr = "server=198.50.180.227;database=connectf_cnnet;userid=connectf_cnnet;password=guriguri1;";
            MySqlConnection connect = new MySqlConnection(connectionstr);
            connect.Open();
            MySqlCommand comm = connect.CreateCommand();
            comm.CommandText = "INSERT INTO Info(Title,Description,Status) VALUES(@Title, @Description,@Status)";
            comm.Parameters.AddWithValue("@Title", textBox2.Text);
            comm.Parameters.AddWithValue("@Description", textBox1.Text);
            comm.Parameters.AddWithValue("@Status", textBox3.Text);
            comm.ExecuteNonQuery();
            connect.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox5.Visible = false;
            groupBox1.Visible = false;
            textBox4.Visible = true;
            string sql2 = "SELECT * FROM Users";
            MySqlConnection con2 = new MySqlConnection("server=198.50.180.227;database=connectf_cnnet;userid=connectf_cnnet;password=guriguri1;");
            MySqlCommand cmd2 = new MySqlCommand(sql2, con2);
            con2.Open();
            MySqlDataReader reader2 = cmd2.ExecuteReader();
            if (reader2.Read())
            {
                string passwords2 = reader2.GetString("Password");
                string emails2 = reader2.GetString("Email");
                textBox4.Text = emails2;

            }
            con2.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5.Visible = true;
            try
            {
                string sql3 = "DELETE FROM Info where Title='" + textBox5.Text + "';";
                MySqlConnection con3 = new MySqlConnection("server=198.50.180.227;database=connectf_cnnet;userid=connectf_cnnet;password=guriguri1;");
                MySqlCommand cmd3 = new MySqlCommand(sql3, con3);
                MySqlDataReader MyReader3;
                con3.Open();
                MyReader3 = cmd3.ExecuteReader();
                if (textBox5.Text == "")
                {
                    MessageBox.Show("Empty seat in textbox.");
                }
                else
                { 
                MessageBox.Show("Data Deleted");
                }
                while (MyReader3.Read())
                {
                }
                con3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox6.Visible = true;
            string sql4 = "SELECT * FROM Statuses";
            MySqlConnection con4 = new MySqlConnection("server=198.50.180.227;database=connectf_cnnet;userid=connectf_cnnet;password=guriguri1;");
            MySqlCommand cmd4 = new MySqlCommand(sql4, con4);
            con4.Open();
            MySqlDataReader reader4 = cmd4.ExecuteReader();
            if (reader4.Read())
            {
                string status4 = reader4.GetString("status");
                string name4 = reader4.GetString("name");
                string emails4 = reader4.GetString("email");
                textBox6.Text = emails4;
            }
            con4.Close();
        }
    }
}

