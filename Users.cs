using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CarRentalSystem
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dhair\OneDrive\Desktop\SEM3\Rapid\CarRentalSystem\CarRentalSystem\CarRentalDatabase.mdf;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=True");

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }



        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "" || Uname.Text == "" || Upass.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO [User] (Userid, Username, Password) VALUES ("
                                   + Uid.Text + ",'" + Uname.Text + "','" + Upass.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Added Successfully");
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Uid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}       
