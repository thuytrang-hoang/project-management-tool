using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;

namespace Programmierprojekt.Datenbank
{
    public partial class SubFormProject : Form   //Assignee: Ugur Bektas; Developer of GUI and  functionality: Ugur Bektas; Translator: Languagemodel-Chat-GPT
    {
        private readonly IConfiguration Configuration; 
        public SubFormProject()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Center window

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
            this.Activated += (s, e) => LoadDataToListView();
        }
        /* Handles the click event of the create project button.
         * This method validates the projectName input and proceeds to assign or create a group for the project.
         * It then inserts a new project entry into the database with the project name, group ID, and current timestamps for creation and update.
         * If the project is successfully created, it adds the user to the group.
         */
        private void createProjektbutton_Click(object sender, EventArgs e)
        {
            string projectName = this.projectnameInput.Text.Trim();
            int groupId = this.CreateNewGroup();

            if (string.IsNullOrEmpty(projectName))
            {
                MessageBox.Show("Bitte geben Sie einen gültigen Projektnamen ein.", "Fehler");
                return;
            }

            //w3schools mit den SQL Statements
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            string insertQuery = "INSERT INTO [Projects] (projectName, groupId, createdDate, updatedDate) VALUES (@projectName, @groupId, @createdDate, @updatedDate)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@projectName", projectName);
                        cmd.Parameters.AddWithValue("@groupId", groupId);
                        cmd.Parameters.AddWithValue("@createdDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@updatedDate", DateTime.Now);

                        int count = Convert.ToInt32(cmd.ExecuteNonQuery());

                        if (count == 1)
                        {
                            this.AddUserToGroup(groupId);

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Ungültige Eingaben!");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler: {ex.Message}");
                }
            }
        }

        /* Adds the currently logged-in user and users from the temporary user list to a specified group.
         * It first inserts the logged-in user into the UserGroups table with the current date.
         * Then, it retrieves all user IDs from the TemporaryUserList, adds each to the UserGroups table, and clears the TemporaryUserList after successful additions.
         */
        private void AddUserToGroup(int groupId)
        {

            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            string insertQueryLoggedUser = "INSERT INTO [UserGroups] (userId, groupId, createdDate) VALUES (@userId, @groupId, @createdDate)";
            string insertQueryTemporaryList = "INSERT INTO [UserGroups] (userId, groupId, createdDate) VALUES (@userId, @groupId, @createdDate)";
            string selectQueryTemporaryList = "SELECT userId FROM [TemporaryUserList]";
            string deleteQueryTemporaryList = "DELETE FROM [TemporaryUserList]";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(insertQueryLoggedUser, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", UserSession.Instance.UserId);
                        cmd.Parameters.AddWithValue("@groupId", groupId);
                        cmd.Parameters.AddWithValue("@createdDate", DateTime.Now);

                        cmd.ExecuteNonQuery();

                    }

                    List<int> userIds = new List<int>();

                    using (SqlCommand selectCmd = new SqlCommand(selectQueryTemporaryList, conn))
                    {
                        using (SqlDataReader reader = selectCmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                userIds.Add(reader.GetInt32(0));
                            }
                        }
                    }

                    foreach (int userId in userIds)
                    {
                        using (SqlCommand insertCmd = new SqlCommand(insertQueryTemporaryList, conn))
                        {
                            insertCmd.Parameters.AddWithValue("@userId", userId);
                            insertCmd.Parameters.AddWithValue("@groupId", groupId);
                            insertCmd.Parameters.AddWithValue("@createdDate", DateTime.Now);

                            insertCmd.ExecuteNonQuery();
                        }
                    }



                    using (SqlCommand deleteCmd = new SqlCommand(deleteQueryTemporaryList, conn))
                    {
                        deleteCmd.ExecuteNonQuery();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Hinzufügen des Benutzers zur Gruppe: {ex.Message}");
                }
            }
        }

        //Fehlerbehebung von bereit exestierenden Gruppen/ nach langen Versuchen Chat-GPT gefragt 3 Zeilen Code haben gefehlt oder so

        /* Creates a new group based on the input from the user.
         * Checks if a group with the given name already exists. If it does, returns the existing group's ID and notifies the user.
         * If the group does not exist, it inserts a new group into the database with the current date and returns the new group's ID.
         */
        private int CreateNewGroup()
        {
            string groupName = this.groupNameInput.Text.Trim();

            if (string.IsNullOrEmpty(groupName))
            {
                MessageBox.Show("Bitte geben Sie einen gültigen Gruppennamen ein.");
                return -1; 
            }

            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            string selectQuery = "SELECT groupId FROM [Groups] WHERE groupName = @groupName";
            string insertQuery = "INSERT INTO [Groups] (groupName, createdDate) OUTPUT INSERTED.groupId VALUES (@groupName, @createdDate)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Checks if the group already exists and return the groupId
                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, conn))
                    {
                        selectCmd.Parameters.AddWithValue("@groupName", groupName);

                        object result = selectCmd.ExecuteScalar();
                        if (result != null)
                        {
                            int existingGroupId = (int)result;

                            return existingGroupId;
                        }
                    }

                    // Creates new Group if it does not already exist and returns the groupId
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@groupName", groupName);
                        insertCmd.Parameters.AddWithValue("@createdDate", DateTime.Now);

                        int newGroupId = (int)insertCmd.ExecuteScalar(); 

                        return newGroupId;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Erstellen der Gruppe: {ex.Message}");
                    return -1; 
                }
            }
        }

        /* Handles the click event for the add group member button.
         * Validates the username input and checks if the user exists in the database.
         * If the user exists, adds them to the TemporaryUserList table.
         */
        private void addGroupMember_Click(object sender, EventArgs e)
        {
            string username = this.groupmemberInputSearch.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Bitte geben Sie einen gültigen Benutzernamen.", "Fehler");
                return;
            }
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            string selectQueryUser = "SELECT userId FROM [User] WHERE username = @username";
            string insertQuery = "INSERT INTO [TemporaryUserList] (userId, username) VALUES (@userId, @userName)";
            int existingUserId;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand selectCmd = new SqlCommand(selectQueryUser, conn))
                    {
                        selectCmd.Parameters.AddWithValue("@username", username);

                        object result = selectCmd.ExecuteScalar();
                        if (result != null)
                        {
                            existingUserId = (int)result;
                            using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@userId", existingUserId);
                                cmd.Parameters.AddWithValue("@userName", username);

                                cmd.ExecuteNonQuery();
                                MessageBox.Show($"Benutzer hinzugefügt: {username}");
                            }
                        }
                        if (result == null)
                        {
                            MessageBox.Show("Benutzername wurde nicht gefunden. Überprüfen Sie die Eingabe.", "Fehler");
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Hinzufügen des Benutzers zur Gruppe: {ex.Message}");
                }
            }
        }

        /* Loads usernames from the User table in the database and populates the memberList ListView with them.
         * Uses a SqlDataReader to fetch usernames one by one, creating a new ListViewItem for each and adding it to the ListView.
         */
        private void LoadDataToListView()
        {
            string connectionString = Configuration.GetConnectionString("DefaultConnection");

            string query = "SELECT username FROM [User]";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            memberList.Items.Clear();

                            while (reader.Read())
                            {
                               
                                ListViewItem item = new ListViewItem(reader["username"].ToString());


                               
                                memberList.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }
            }
        }
    }
}
