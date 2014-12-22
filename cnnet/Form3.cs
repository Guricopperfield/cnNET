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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
             
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
  

    

      
    }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string sql5 = "SELECT * FROM Info WHERE Status = 8";
            MySqlConnection con5 = new MySqlConnection("server=198.50.180.227;database=connectf_cnnet;userid=connectf_cnnet;password=guriguri1;");
            MySqlCommand cmd5 = new MySqlCommand(sql5, con5);
            con5.Open();
            MySqlDataReader reader5 = cmd5.ExecuteReader();
            if (reader5.Read())
            {
                string titles5 = reader5.GetString("Title");
                string descriptions5 = reader5.GetString("Description");
                label1.Visible = true;
                label1.Text = descriptions5;
            }
            con5.Close();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                string sql6 = "SELECT * FROM Info WHERE Status = 9";
                MySqlConnection con6 = new MySqlConnection("server=198.50.180.227;database=connectf_cnnet;userid=connectf_cnnet;password=guriguri1;");
                MySqlCommand cmd6 = new MySqlCommand(sql6, con6);
                con6.Open();
                MySqlDataReader reader6 = cmd6.ExecuteReader();
                while (reader6.Read())
                {
                    string descriptions6 = reader6.GetString("Description");
                    label1.Visible = true;
                    label1.Text += "\n\n" + descriptions6;
                }
                con6.Close();
            }
            else if (radioButton3.Checked)
            {
                string sql7 = "SELECT * FROM Info WHERE Status = 1";
                MySqlConnection con7 = new MySqlConnection("server=198.50.180.227;database=connectf_cnnet;userid=connectf_cnnet;password=guriguri1;");
                MySqlCommand cmd7 = new MySqlCommand(sql7, con7);
                con7.Open();
                MySqlDataReader reader7 = cmd7.ExecuteReader();
                while (reader7.Read())
                {
                    string descriptions7 = reader7.GetString("Description");
                    label1.Visible = true;
                    label1.Text += "\n\n" + descriptions7;
                }
                con7.Close();
              }
            else if (radioButton4.Checked)
            {
                string sql8 = "SELECT * FROM Info WHERE Status = 2";
                MySqlConnection con8 = new MySqlConnection("server=198.50.180.227;database=connectf_cnnet;userid=connectf_cnnet;password=guriguri1;");
                MySqlCommand cmd8 = new MySqlCommand(sql8, con8);
                con8.Open();
                MySqlDataReader reader8 = cmd8.ExecuteReader();
                while (reader8.Read())
                {
                    string descriptions8 = reader8.GetString("Description");
                    label1.Visible = true;
                    label1.Text += "\n\n" + descriptions8;
                }
                con8.Close();
            }
            else if (radioButton5.Checked)
            {
                string sql9 = "SELECT * FROM Info WHERE Status = 3";
                MySqlConnection con9 = new MySqlConnection("server=198.50.180.227;database=connectf_cnnet;userid=connectf_cnnet;password=guriguri1;");
                MySqlCommand cmd9 = new MySqlCommand(sql9, con9);
                con9.Open();
                MySqlDataReader reader9 = cmd9.ExecuteReader();
                while (reader9.Read())
                {
                    string descriptions9 = reader9.GetString("Description");
                    label1.Visible = true;
                    label1.Text += "\n\n" + descriptions9;
                }
                con9.Close();
            }
            else if (radioButton6.Checked)
            {
                string sql10 = "SELECT * FROM Info WHERE Status = 4";
                MySqlConnection con10 = new MySqlConnection("server=198.50.180.227;database=connectf_cnnet;userid=connectf_cnnet;password=guriguri1;");
                MySqlCommand cmd10 = new MySqlCommand(sql10, con10);
                con10.Open();
                MySqlDataReader reader10 = cmd10.ExecuteReader();
                while (reader10.Read())
                {
                    string descriptions10 = reader10.GetString("Description");
                    label1.Visible = true;
                    label1.Text += "\n\n" + descriptions10;
                }
                con10.Close();
            }
            else if (radioButton7.Checked)
            {
                string sql11 = "SELECT * FROM Info WHERE Status = 5";
                MySqlConnection con11 = new MySqlConnection("server=198.50.180.227;database=connectf_cnnet;userid=connectf_cnnet;password=guriguri1;");
                MySqlCommand cmd11 = new MySqlCommand(sql11, con11);
                con11.Open();
                MySqlDataReader reader11 = cmd11.ExecuteReader();
                while (reader11.Read())
                {
                    string descriptions11 = reader11.GetString("Description");
                    label1.Visible = true;
                    label1.Text += "\n\n" + descriptions11;
                }
                con11.Close();
            }
            else if (radioButton7.Checked)
            {
                string sql12 = "SELECT * FROM Info WHERE Status = 7";
                MySqlConnection con12 = new MySqlConnection("server=198.50.180.227;database=connectf_cnnet;userid=connectf_cnnet;password=guriguri1;");
                MySqlCommand cmd12 = new MySqlCommand(sql12, con12);
                con12.Open();
                MySqlDataReader reader12 = cmd12.ExecuteReader();
                while (reader12.Read())
                {
                    string descriptions12 = reader12.GetString("Description");
                    label1.Visible = true;
                    label1.Text += "\n\n" + descriptions12;
                }
                con12.Close();
            }
            else if (radioButton8.Checked)
            {
                string sql13 = "SELECT * FROM Info WHERE Status = 10";
                MySqlConnection con13 = new MySqlConnection("server=198.50.180.227;database=connectf_cnnet;userid=connectf_cnnet;password=guriguri1;");
                MySqlCommand cmd13 = new MySqlCommand(sql13, con13);
                con13.Open();
                MySqlDataReader reader13 = cmd13.ExecuteReader();
                while (reader13.Read())
                {
                    string descriptions13 = reader13.GetString("Description");
                    label1.Visible = true;
                    label1.Text += "\n\n" + descriptions13;
                }
                con13.Close();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
   
    }
}  