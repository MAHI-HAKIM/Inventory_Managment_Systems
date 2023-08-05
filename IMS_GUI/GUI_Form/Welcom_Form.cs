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
using IMS_DataAccess;

namespace IMS_GUI.GUI_Form
{
    public partial class Welcom_Form : Form
    {
        IDBConnection dbConnection = new DBConnection();

        public Welcom_Form()
        {
            InitializeComponent();

        }
        public Welcom_Form(string firstName, string lastName)
        {
            InitializeComponent();
            lable_Firstname.Text = firstName;
            label_lastname.Text = lastName;
        }
        public string WelcomeMessage
        {
            set { labelWelcome.Text = value; }
        }

        public string FirstNameMessage
        {
            set { lable_Firstname.Text = value; }
        }

        public string LastNameMessage
        {
            set { label_lastname.Text = value; }
        }
        private void Welcom_Form_Load(object sender, EventArgs e)
        {
            LoadUser();

        }
        public void LoadUser()
        {
            string query = "SELECT FirstName, LastName, PhoneNo , Address FROM ContactInfo";

            dbConnection.OpenConnection();

            using (SqlCommand command = new SqlCommand(query, dbConnection.Connection))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                userDataGridView.DataSource = dataTable;
            }
            dbConnection.CloseConnection();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Login_Form lg = new Login_Form();
            lg.FormClosed += (s, args) => this.Close();
            this.Hide();
            lg.Show();
        }
    }
}
