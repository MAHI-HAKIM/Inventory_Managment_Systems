using IMS_DataAccess;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IMS_GUI
{
    public partial class User_Page : UserControl
    {
        IDBConnection dbConnection = new DBConnection();
        User_Mg_control userManagement = new User_Mg_control();

        public User_Page()
        {
            InitializeComponent();
        }
        private void User_Page_Load(object sender, EventArgs e)
        {
            // Retrieve user details from the database
            LoadUser();

            flowLayoutPanel.WrapContents = false; // Prevents horizontal wrapping

            LoadUsersinlabel();
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

                user_dgv.DataSource = dataTable;
            }
            dbConnection.CloseConnection();
        }
        // Method to load users and add panels
        private void LoadUsersinlabel()
        {
            foreach (UserDetail user in userManagement.GetAllUsers())
            {
                User_Panel userPanel = new User_Panel(user.UserID);

                // Set the properties you've exposed
                userPanel.FullName = user.FirstName + " " + user.LastName;
                userPanel.PhoneNumber = user.PhoneNumber;

                // Add the shadow panel to the flow panel
                flowLayoutPanel.Controls.Add(userPanel);
            }
        }
        public void RefreshPage()
        {
            this.Hide();
            //this.Show();
        }
    }
}
