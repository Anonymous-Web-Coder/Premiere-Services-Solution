using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;

using System.Data.SqlClient;

namespace Premier_Service_Solutionsv2.Forms
{
   

    public partial class FormClient : Form
    {
        string[] Scopes = { GmailService.Scope.GmailSend };
        string ApplicationName = "GmailSend";
        string connectionString = "Server=DESKTOP-46SGCNR\\MSSQLSERVER02;Database=SEN381_DB_v2;Integrated Security=True;";
        string technicianEmail = "neonkniight@gmail.com";
        public FormClient()
        {
            InitializeComponent();

            // string connectionString = "Server=LAPTOP-5PNMACAU;Database=SEN381_DB_v2;User Id=LAPTOP-5PNMACAU;Password=;";
           // string connectionString = "data source =.; initial catalog = SEN381_DB_v2; persist security info = True; integrated security = True; TrustServerCertificate = True";
           // string connectionString = "Server=DESKTOP-46SGCNR\\MSSQLSERVER02;Database=SEN381_DB_v2;Integrated Security=True;";

            // Create a data table to hold the results
            DataTable clientDataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                // Your database operations go here
                string sqlQuery = "SELECT * FROM Clients";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Execute the query and populate the data table
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(clientDataTable);
                }
            }

            // Bind the DataGridView to the data table
            dataGridView1.DataSource = clientDataTable;

            DataTable technicianDataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Your database operations go here
                string sqlQuery = "SELECT * FROM Technician"; // Modify the query to select technician names

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Execute the query and populate the data table
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(technicianDataTable);
                }
            }
            technicianDataTable.Columns.Add("FullInfo", typeof(string), "'TechnicianID: '+TechnicianID +' Technician Name: '+FirstName + ' ' + LastName");
            // Bind the ComboBox to the data table containing technician names
            cmbTechnician.DataSource = technicianDataTable;
            cmbTechnician.DisplayMember = "FullInfo"; // Display the "TechnicianName" column in the ComboBox
        }

        string Base64UrlEncode(string input)
        {
            var data = Encoding.UTF8.GetBytes(input);
            return Convert.ToBase64String(data).Replace("+", "-").Replace("/", "_").Replace("=", "");
        }

        private void FormContractM_Load(object sender, EventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddExisting_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNatureOfCall_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmitRequest_Click(object sender, EventArgs e)
        {
            // Validation: Check if the Client ID is provided
            if (string.IsNullOrWhiteSpace(tbxClientID.Text))
            {
                MessageBox.Show("Please enter a Client ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop processing if there is an error
            }

            // Validation: Check if a client is selected in the DataGridView
            if (string.IsNullOrWhiteSpace(txbName.Text))
            {
                MessageBox.Show("Please select a client from the list.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop processing if there is an error
            }

            // Validation: Check if Priority is selected
            if (clbPriority.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a priority level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop processing if there is an error
            }

            // Validation: Check if Nature of Call is provided
            if (string.IsNullOrWhiteSpace(txbnature.Text))
            {
                MessageBox.Show("Please enter the nature of the call.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop processing if there is an error
            }

            // Validation: Check if Incident Description is provided
            if (string.IsNullOrWhiteSpace(txbIncidentDescription.Text))
            {
                MessageBox.Show("Please enter the incident description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop processing if there is an error
            }


            // Get other information for the report
            int iIncidentID = 5;
            
            string sNatureOfCall = txbnature.Text;
            string sDescription = txbIncidentDescription.Text;
            string sReciever = technicianEmail;
            string sSubject = $"Premier_Service_Solutions Incident:{iIncidentID}";

            string sPriority = "Highest"; // You have your priority value

            // Iterate through the items in the CheckedListBox
            for (int i = 0; i < clbPriority.Items.Count; i++)
            {
                if (clbPriority.GetItemChecked(i))
                {
                    sPriority = clbPriority.Items[i].ToString();
                    break; // Exit the loop as soon as a checked item is found
                }
            }
            // Fetch client data from the database based on selectedClientId
            string clientDataQuery = $"SELECT * FROM Clients WHERE ClientId = {tbxClientID.Text}";

            // ... (rest of your code)

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(clientDataQuery, connection))
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int clientId = reader.GetInt32(0);
                        string lastName = reader.GetString(1);
                        string firstName = reader.GetString(2);
                        string streetName = reader.GetString(3);
                        string city = reader.GetString(4);
                        string postalCode = reader.GetString(5);
                        string province = reader.GetString(6);
                        string country = reader.GetString(7);
                        string clientType = reader.GetString(8);
                        string phoneNumber = reader.GetString(9);
                        string email = reader.GetString(10);
                        string status = reader.GetString(11);
                        string notes = reader.GetString(12);

                        // Create the message with client information
                        string sMessage = $"<h1>Report</h1><h2>Client info</h2> " +
                            $"<p>Client Id: {clientId}</p>" +
                            $"<p>Last Name: {lastName}</p>" +
                            $"<p>First Name: {firstName}</p>" +
                            $"<p>First Name: {streetName}</p>" +
                            $"<p>City: {city}</p>" +
                            $"<p>Postal Code: {postalCode}</p>" +
                            $"<p>Province: {province}</p>" +
                            $"<p>Country: {country}</p>" +
                            $"<p>Client Type: {clientType}</p>" +
                            $"<p>Phone Number: {phoneNumber}</p>" +
                            $"<p>Email : {email}</p>" +
                            $"<p>Status: {status}</p>" +
                            $"<p>Notes: {notes}</p>" +
                            $"<h2>Incident Info</h2> " +
                            $"<p>Nature of call: {sNatureOfCall}</p>" +
                            $"<p>Incident Description: {sDescription}</p>" +
                            $"<p>Incident Date: {sPriority}</p>" +
                            $"<p>Status: Sent</p>";

                       

                        UserCredential credential;
                        // Read your credentials file
                        using (FileStream stream = new FileStream(Application.StartupPath + @"/credentials.json", FileMode.Open, FileAccess.Read))
                        {
                            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                            path = Path.Combine(path, ".credentials/gmail-dotnet-quickstart.json");
                            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.Load(stream).Secrets, Scopes, "user", CancellationToken.None, new FileDataStore(path, true)).Result;
                        }

                        string message = $"To: {sReciever}\r\nSubject: {sSubject}\r\nContent-Type: text/html;charset=utf-8\r\n\r\n{sMessage}";
                        // Call your Gmail service
                        var service = new GmailService(new BaseClientService.Initializer() { HttpClientInitializer = credential, ApplicationName = ApplicationName });
                        var msg = new Google.Apis.Gmail.v1.Data.Message();
                        msg.Raw = Base64UrlEncode(message.ToString());
                        service.Users.Messages.Send(msg, "me").Execute();
                        MessageBox.Show("Your email has been successfully sent!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Client data not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void lblIncidentDescr_Click(object sender, EventArgs e)
        {

        }
        
       


        // Event handler for the CellClick event
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                // Get the client's name and ID from the selected row
                string clientName = dataGridView1.Rows[e.RowIndex].Cells["FirstName"].Value.ToString(); 
                int clientId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ClientId"].Value); 

                // Set the text boxes with the client's name and ID
                txbName.Text = clientName;
                tbxClientID.Text = clientId.ToString();
            }
        }

        private void clbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cmbTechnician_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = cmbTechnician.SelectedItem as DataRowView;

            if (selectedRow != null)
            {
                // Get the TechnicianID from the selected row
                int technicianID = Convert.ToInt32(selectedRow["TechnicianID"]);

                // Fetch the email address of the technician from the database
                string emailQuery = $"SELECT TechnicianEmail FROM Technician WHERE TechnicianID = {technicianID}";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(emailQuery, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            technicianEmail = reader.GetString(0);
                        }
                    }
                }
            }
        }

    }
}
