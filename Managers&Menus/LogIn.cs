using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;
using Programmierprojekt.Datenbank;
using Microsoft.VisualBasic.ApplicationServices;
using System.Transactions;

namespace Programmierprojekt
{
    public partial class LogIn : Form  //Assignee: Ugur Bektas; Developer of GUI and  functionality: Ugur Bektas; Translator: Languagemodel-Chat-GPT
    {

        private readonly IConfiguration Configuration;

        public LogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Center window


            // Sets the application's working directory and loads the configuration file to manage the database connection and other settings. Helper: Chat-GPT Prompt "How to properly handle Connection"

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();

        }


        // Checks if the application is connected to the database.
        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectionString = Configuration.GetConnectionString("DefaultConnection");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connection Successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Connection Failed: {ex.Message}");
                }
            }
        }


        /*Helper: Chat-GPT + w3schools, Intro and Tutorional into SQL-Statements + application.
         * Prompt: "Wie funktionieren SQL Statements in C# bzw. wie implementiert man die"
         * Build the Code based on the Help
         * Checks if the User is registered but also if its the right password. 
         * Saves the neccessary Data in an User Instance
        */
        private void button2_Click(object sender, EventArgs e) // LogIN
        {
            // Fetch Textbox Input
            string username = this.usernameInput.Text.Trim();
            string password = this.passwordInput.Text.Trim();

            // Check if Input is empty
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Bitte geben Sie Benutzername und Passwort ein.");
                return;
            }

            // Loading Connectionconfigurationstring with apsettings.json
            string connectionString = Configuration.GetConnectionString("DefaultConnection");

            // SQL-Statement
            string validateUserQuery = "SELECT COUNT(*) FROM [User] WHERE username = @username AND password = @password";
            string getUserDetailsQuery = "SELECT userId , lastname , firstname FROM [User] WHERE username = @username AND password = @password";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    //User validation
                    using (SqlCommand validateCmd = new SqlCommand(validateUserQuery, conn))
                    {
                        validateCmd.Parameters.AddWithValue("@username", username);
                        validateCmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(validateCmd.ExecuteScalar());

                        if (count == 1)
                        {
                            //Fetch Userinformation
                            using (SqlCommand getUserCmd = new SqlCommand(getUserDetailsQuery, conn))
                            {
                                getUserCmd.Parameters.AddWithValue("@username", username);
                                getUserCmd.Parameters.AddWithValue("@password", password);


                                using (SqlDataReader reader = getUserCmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {

                                        int userId = reader.GetInt32(0);
                                        string lastname = reader.GetString(1);
                                        string firstname = reader.GetString(2);

                                        // Save logged in Userinformation in UserSession (Singleton)
                                        UserSession.Instance.Username = username;
                                        UserSession.Instance.UserId = userId;
                                        UserSession.Instance.Lastname = lastname;
                                        UserSession.Instance.Firstname = firstname;



                                        // Redirect to Projectmenu
                                        ProjectMenu projektMenu = new ProjectMenu();
                                        projektMenu.Show();
                                        this.Hide();
                                        projektMenu.FormClosed += (s, args) => this.Hide();
                                     
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Username or Password is wrong
                            MessageBox.Show("Ungültiger Benutzername oder Passwort.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler bei der Verbindung oder Abfrage: {ex.Message}");
                }
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}