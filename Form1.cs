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

namespace Inventory_Managment_System
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HP-ENVY-MAHI\MSSQLSERVER03;Initial Catalog=Practice;Integrated Security=True");


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string Username = "", Password = "";

            Username = username_txt.Text;
            Password = password_txt.Text;

            try
            {
                String querry = "Select * From Login Where Username = '" + username_txt.Text + "' AND Password = '" + password_txt.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();

                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    Username = username_txt.Text;
                    Password = password_txt.Text;

                    ////////////////
                    Welcome welc = new Welcome();

                    welc.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //username_txt.Clear();
                    password_txt.Clear();

                    username_txt.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {

            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {

            username_txt.Clear();
            password_txt.Clear();

            username_txt.Focus();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
                username_txt.Focus();
            }
        }
    }
}
