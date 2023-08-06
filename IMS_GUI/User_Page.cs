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


namespace IMS_GUI
{
    public partial class User_Page : UserControl
    {
        IDBConnection dbConnection = new DBConnection();

        public User_Page()
        {
            InitializeComponent();
        }

        private void User_Page_Load(object sender, EventArgs e)
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

                user_dgv.DataSource = dataTable;
            }
            dbConnection.CloseConnection();
        }

    }
}
