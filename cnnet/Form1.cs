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
    public partial class cnNET : Form
    {
        public cnNET()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            bool Internetcheck = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            if (Internetcheck == true)
            {
             
                Panel1.Visible = true;
                Panel2.Visible = false;
                Button6.Visible = false;
                Button7.Visible = false;


            }
            else
            {
               
               
                MessageBox.Show("Internet connections are not available", "Information");
                Button6.Visible = false;
                button10.Visible = false;
                Button7.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                Panel1.Visible = false;
                Panel2.Visible = false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bool Internetcheck = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            if (Internetcheck == true)
            {
                Panel2.Visible = true;
                Panel1.Visible = false;
                Button6.Visible = false;
                Button7.Visible = false;
                button10.Visible = false;
            }
          
                 else
            {
                MessageBox.Show("Internet connection is not available", "Information");
                Button6.Visible = false;
                button10.Visible = false;
                Button7.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                Panel1.Visible = false;
                Panel2.Visible = false;
            }
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            bool Internetcheck = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();

            if (Internetcheck == true)
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                Button6.Visible = true;
                Button7.Visible = true;
                button10.Visible = true;

            }

            else
            {
                MessageBox.Show("Internet connection is not available", "Information");
                Button6.Visible = false;
                button10.Visible = false;
                Button7.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                Panel1.Visible = false;
                Panel2.Visible = false;
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string mail = TextBox2.Text;
            string pass = TextBox3.Text;
   

            if (TextBox3.Text.Length < 8)
            {

                MessageBox.Show("Password is less than 8 symbol. Try Again", "Attention");//some bug here

            }
            else { Panel2.Visible = true;   
                Panel1.Visible = false;
            }
            String connString = "server=198.50.180.227;database=connectf_cnnet;userid=connectf_cnnet;password=guriguri1;";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO Users(Email,Password) VALUES(@Email, @Password)";
            comm.Parameters.AddWithValue("@Email", TextBox2.Text);
            comm.Parameters.AddWithValue("@Password",TextBox3.Text);
            comm.ExecuteNonQuery();
            conn.Close();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Users WHERE Email = '" + TextBox4.Text + "' AND Password = '" + TextBox5.Text + "' LIMIT 1";
            MySqlConnection con = new MySqlConnection("server=198.50.180.227;database=connectf_cnnet;userid=connectf_cnnet;password=guriguri1;");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string passwords = reader.GetString("Password");
                string emails = reader.GetString("Email");

                if (TextBox4.Text == emails && TextBox5.Text == passwords)
                {
                    Form3 f3 = new Form3();
                    this.Visible = false;
                    f3.Show();
                    MessageBox.Show("You Are User. Welcome", "Information");
                }
            }
            else
            {
                string sql1 = "SELECT * FROM Operators WHERE Email = '" + TextBox4.Text + "' AND Password = '" + TextBox5.Text + "' LIMIT 1";
                MySqlConnection con1 = new MySqlConnection("server=198.50.180.227;database=connectf_cnnet;userid=connectf_cnnet;password=guriguri1;");
                MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
                con1.Open();
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    string passwords1 = reader1.GetString("Password");
                    string emails1 = reader1.GetString("Email");
                    if (TextBox4.Text == emails1 && TextBox5.Text == passwords1)
                    {
                        MessageBox.Show("You Are Operator. Welcome", "Information");

                        Form2 f2 = new Form2();
                        this.Visible = false;
                        f2.Show();
                    }

                    else
                    {
                        MessageBox.Show("Non-Authorized", "Attention");
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Non-Authorized","Attention");
                }


            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
       

















































































        Panel2.Top = 118;
        Panel2.Left = 12;
        Panel1.Top = 118;
        Panel1.Left = 12;
 

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            label11.Visible = true;

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            string url = "www.connectforworld.com";
     System.Diagnostics.Process.Start(url);
}

        private void button10_Click(object sender, EventArgs e)
        {
            label12.Visible = true;

            label12.Text = "How To Get Started.Actually.\n 1. Register and get some rights. Then login. \n 2. If you want to be operator,send us feedback. \n 3. If you want to be normal user,enjoy the software and join groups,write questions. \n 4. For normal users,it's impossible to add new files or any control functions. \n 5. For Operators,It's Possible to add new files,create groups,control and teach groups and Operators have access on the control system.";
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed By Mirza Jijieshvili,Guri Getsadze,Alexander Gorgadze At hackTBILISI.\n ©2014.","Information");
        }

        private void Button9_Click(object sender, EventArgs e)
        {

        }

 
        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            bool Internetcheck = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();

            if (Internetcheck == true)
            {
                MessageBox.Show("Internet connection is available", "Information");
                Button1.Enabled = true;
                Button2.Enabled = true;
                Button4.Enabled = true;


            }
            else
            {
                Button6.Visible  = false;
                button10.Visible  = false;
                Button7.Visible = false;
                label12.Visible = false;
                label11.Visible = false;

                Button1.Enabled = false;
                Button2.Enabled = false;
                Button4.Enabled = false;

                MessageBox.Show("Internet connection is not available", "Information");
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
        }

        }

    }
