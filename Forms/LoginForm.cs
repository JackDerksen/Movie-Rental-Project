using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MovieRentalProject
{
    static class Global
    {
        private static string _globalEmpID = "";
        private static string _globalCustID = "";
        private static string _globalMovieID = "";
        private static string _globalMovieName = "";
        private static int _globalMovieCopies = 0;
        private static int _globalMovieAvailability = 1;

        public static string GlobalEmpID
        {
            get { return _globalEmpID; }
            set { _globalEmpID = value; }
        }

        public static string GlobalCustID
        {
            get { return _globalCustID; }
            set { _globalCustID = value; }
        }

        public static string GlobalMovieID
        {
            get { return _globalMovieID; }
            set { _globalMovieID = value; }
        }

        public static string GlobalMovieName
        {
            get { return _globalMovieName; }
            set { _globalMovieName = value; }
        }

        public static int GlobalMovieCopies
        {
            get { return _globalMovieCopies; }
            set { _globalMovieCopies = value; }
        }

        public static int GlobalMovieAvailability
        {
            get { return _globalMovieAvailability; }
            set { _globalMovieAvailability = value; }
        }
    }

    public partial class LoginForm : Form
    {
        // Fetch the connection string from App.config
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MovieRental"].ConnectionString;
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void UserBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string employeeID = UserBox.Text;
            string password = PassBox.Text;

            if (string.IsNullOrEmpty(employeeID) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Employee ID and Password.");
                return;
            }

            if (AuthenticateUser(employeeID, password))
            {
                Global.GlobalEmpID = employeeID;

                MessageBox.Show("Login successful!");
                // After successful login, open the MenuForm
                MenuForm menuForm = new MenuForm();
                menuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Employee ID or Password.");
            }
        }

        private bool AuthenticateUser(string employeeID, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Hash the entered password and get it as a byte array
                    byte[] hashedPassword = HashPassword(password);

                    // Prepare the SQL query to check if the user exists with the given EmployeeID and hashed password
                    string query = "SELECT COUNT(*) FROM Employee WHERE EmployeeID = @EmployeeID AND Userpass = @Userpass";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@EmployeeID", employeeID);
                        command.Parameters.AddWithValue("@Userpass", hashedPassword); // Compare as byte array

                        // Execute the query and check if any matching record is found
                        int count = (int)command.ExecuteScalar();

                        // Return true if there's at least one matching record
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        private byte[] HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                return sha256.ComputeHash(bytes); // Return the hash as a byte array
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}