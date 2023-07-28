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
    public partial class Welcome_Form : Form
    {
        DBConnection dbConnection = new DBConnection();

        public Welcome_Form()
        {
            InitializeComponent();
        }

        private void Welcome_Form_Load(object sender, EventArgs e)
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

        public Welcome_Form(string firstName, string lastName)
        {
            InitializeComponent();
            labelFirstName.Text = firstName;
            label_lastname.Text = lastName;
        }

        public string WelcomeMessage
        {
            set { labelWelcome.Text = value; }
        }

        public string FirstNameMessage
        {
            set { labelFirstName.Text = value; }
        }

        public string LastNameMessage
        {
            set { label_lastname.Text = value; }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Login_Form lg = new Login_Form();
            this.Hide();
            lg.Show();

        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }

        private void label_lastname_Click(object sender, EventArgs e)
        {

        }

        private void labelWelcome_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
