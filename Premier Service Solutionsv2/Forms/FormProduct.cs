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
namespace Premier_Service_Solutionsv2.Forms
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            // string connectionString = "Server=LAPTOP-5PNMACAU;Database=SEN381_DB_v2;User Id=LAPTOP-5PNMACAU;Password=;";
            //string connectionString = "data source =.; initial catalog = SEN381_DB_v2; persist security info = True; integrated security = True; TrustServerCertificate = True";
            string connectionString = "Server=DESKTOP-46SGCNR\\MSSQLSERVER02;Database=SEN381_DB_v2;Integrated Security=True;";

            // Create a data table to hold the results
            DataTable clientDataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Your database operations go here
                string sqlQuery = "SELECT * FROM ServiceContracts";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Execute the query and populate the data table
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(clientDataTable);
                }
            }

            // Bind the DataGridView to the data table
            dataGridView2.DataSource = clientDataTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormProduct_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
