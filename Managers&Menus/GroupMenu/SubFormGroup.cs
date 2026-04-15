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
using Programmierprojekt.Homepage;

namespace Programmierprojekt.Datenbank
{
    public partial class SubFormGroup : Form //Assignee: Ugur Bektas; Developer of GUI: Trang created it and Ugur Bektas adjusted  it; Functionality: Ugur Bektas; Translator: Languagemodel-Chat-GPT
    {

        // Similar methods exist in other classes. A base implementation already exists, which I adjusted to suit this class. For example, methods like LoadGroupProjects. Therefore, some comments are kept brief.
        private readonly IConfiguration Configuration;
        public SubFormGroup()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Center window

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
            this.Activated += (s, e) => LoadGroupProjects();
            this.Activated += (s, e) => LoadGroupMembers();
        }
        /* Loads project data associated with a specific group into the projectListViewBox.
         * Retrieves the group ID using the GetGroupId method and fetches project names and creation dates from the database.
         * Populates the ListView with the project name and its creation date, formatted as "dd.MM.yyyy."
         */
        private void LoadGroupProjects()
        {
            int groupId = GetGroupId();
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            string query = @"SELECT projectName, createdDate FROM Projects WHERE groupId = @groupId";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@groupId", groupId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            projectListViewBox.Items.Clear();

                            while (reader.Read())
                            {

                                ListViewItem item = new ListViewItem(reader["projectName"].ToString());
                                item.SubItems.Add(Convert.ToDateTime(reader["createdDate"]).ToString("dd.MM.yyyy"));
                                projectListViewBox.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Laden der Projekte: {ex.Message}");
                }
            }
        }
        private void addGroupMemberButton_Click(object sender, EventArgs e)
        {
            LoadUsersToListView();
        }

        /* Adds a user to a specified group in the database.
         * Executes an INSERT operation into the UserGroups table with the user ID, group ID, and the current timestamp.
         */
        private void AddUserToGroup(int userId, int groupId)
        {

            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            string query = "INSERT INTO UserGroups (userId, groupId, createdDate) VALUES (@userId, @groupId, @createdDate)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@groupId", groupId);
                        cmd.Parameters.AddWithValue("@createdDate", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Benutzer konnte zur Gruppe hinzugefügt werden.");

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Fehler beim Hinzufügen des Benutzers: {ex.Message}");
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Fehler: {ex.Message}");
                }
            }
        }
        /* Handles the activation event (e.g., double-click) of an item in the userListView.
         *  Retrieves the selected user's username, group ID, and user ID based on the selection.
         *  Adds the selected user to the current group by calling the AddUserToGroup method.
         *  Hides the userListView after successfully adding the user to the group.
         */
        private void userListView_ItemActivate(object sender, EventArgs e)
        {
            ListView userListViewBox = sender as ListView;
            if (userListViewBox?.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = userListViewBox.SelectedItems[0];
                string username = selectedItem.Text;

                int groupId = GetGroupId();
                int userId = GetUserId(username);

                AddUserToGroup(userId, groupId);
                userListViewBox.Hide();

            }
        }
        /*  Creates and populates a ListView with user data retrieved from the database.
         *  Configures the ListView to display usernames, with columns and properties for detailed and interactive views.
         *   Attaches an event handler (userListView_ItemActivate) to handle actions when a user clicks on a ListView item.
         *   Queries the database for all usernames in the [User] table and populates the ListView with the results.
         *   Adds the ListView to the form's controls.
         */
        private void LoadUsersToListView()
        {

            ListView userListViewBox = new ListView
            {
                View = View.Details,
                FullRowSelect = true,
                GridLines = true,
                Location = new Point((this.ClientSize.Width - 400) / 2, (this.ClientSize.Height - 300) / 2),
                Size = new Size(400, 300),
            };
  

            userListViewBox.Columns.Add("Aktive Nutzer", 300);
            userListViewBox.ItemActivate += userListView_ItemActivate;
            this.Controls.Add(userListViewBox);
            userListViewBox.BringToFront();
            userListViewBox.Focus();
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
                            while (reader.Read())
                            {

                                ListViewItem item = new ListViewItem(reader["username"].ToString());
                                userListViewBox.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Laden der Benutzer: {ex.Message}");
                }
            }
        }
        /* Handles the click event for removing a group member from the groupMemberListViewBox.
         * Retrieves the username of the selected user, the current group ID, and the user ID associated with the username.
         * Executes a DELETE query to remove the user from the UserGroups table in the database.
         */
        private void removeGroupMemberButton_Click(object sender, EventArgs e)
        {

            if (groupMemberListViewBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte wählen Sie ein Gruppenmitglied aus.", "Hinweis");
                return;
            }


            ListViewItem selectedItem = groupMemberListViewBox.SelectedItems[0];
            string username = selectedItem.Text;


            int groupId = this.GetGroupId();
            int userId = GetUserId(username);

            if (userId == -1)
            {
                MessageBox.Show("Benutzer konnte nicht gefunden werden.", "Fehler");
                return;
            }

            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            string deleteQuery = "DELETE FROM UserGroups WHERE userId = @userId AND groupId = @groupId";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@groupId", groupId);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {

                            groupMemberListViewBox.Items.Remove(selectedItem);
                        }
                        else
                        {
                            MessageBox.Show("Der Benutzer ist möglicherweise nicht mehr in dieser Gruppe.", "Fehler");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Entfernen des Benutzers: {ex.Message}");
                }
            }
        }
        /*  Retrieves the user ID associated with a given username from the database.
         *  Executes a SELECT query to fetch the userId from the [User] table based on the provided username.
         *  Returns the user ID in int.
         */
        public int GetUserId(string username)
        {
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            string selectQuery = "SELECT userId FROM [User] WHERE username= @username";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, conn))
                    {
                        selectCmd.Parameters.AddWithValue("@username", username);
                        object result = selectCmd.ExecuteScalar();
                        int userId = (int)result;
                        return userId;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler: {ex.Message}");
                    return -1;
                }
            }
        }
        /* Loads the members of a specific group into the groupMemberListViewBox.
         * Retrieves the group ID using the GetGroupId method and fetches user data associated with that group  by executing a database query that joins the [USER], UserGroups, and Groups tables.
         */
        private void LoadGroupMembers()
        {
            int groupId = GetGroupId();
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            string query = @"SELECT u.userId, u.username FROM [USER] u INNER JOIN UserGroups ug ON u.userId = ug.userId INNER JOIN Groups g ON ug.groupId = g.groupId WHERE g.groupId = @groupId; "; // select u.Userid,u.username from user u, UserGroups ug, group g where u.userId=ug.userId and ug.groupId=g.groupId and g.groupId = @groupId  

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@groupId", groupId);


                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            groupMemberListViewBox.Items.Clear(); // ListView für Mitglieder leeren
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["username"].ToString());
                                groupMemberListViewBox.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Laden der Mitglieder: {ex.Message}");
                }
            }
        }
        /*  Retrieves the group ID associated with the current group's name from the database.
         *  Executes a SELECT query to fetch the groupId from the [Groups] table based on the group name stored in FormManager.CurrentGroupName.
         *  Returns the group ID int  
         */
        private int GetGroupId()
        {
            string groupName = FormManager.CurrentGroupName;
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            string selectQuery = "SELECT groupId FROM [Groups] WHERE groupName = @groupName";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, conn))
                    {
                        selectCmd.Parameters.AddWithValue("@groupName", groupName);
                        object result = selectCmd.ExecuteScalar();
                        int groupId = (int)result;
                        return groupId;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler: {ex.Message}");
                    return -1;
                }
            }
        }
        /* Handles the click event for the "Leave Group" button.
         * Removes the currently logged-in user from the selected group by deleting their record from the UserGroups table in the database.
         * Retrieves the group ID using the GetGroupId method and the user ID from the UserSession instance.
         * Ensures the GroupMenu form is either created or reused before redirecting the user to it.
         */
        private void leaveGroupButton_Click(object sender, EventArgs e)
        {

            int groupId = GetGroupId();
            int userId = UserSession.Instance.UserId;
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            string query = "DELETE FROM UserGroups WHERE userId = @userId AND groupId = @groupId";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@groupId", groupId);

                        cmd.ExecuteNonQuery();

                        if (FormManager.GroupMenuInstance == null || FormManager.GroupMenuInstance.IsDisposed)
                        {
                            FormManager.GroupMenuInstance = new GroupMenu();
                            FormManager.GroupMenuInstance.FormClosed += (s, args) => this.Close();
                        }

                        this.Hide();
                        FormManager.GroupMenuInstance.Show();


                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Fehler: {ex.Message}");
                }

            }
        }

        private void lblHomepage_Click(object sender, EventArgs e)
        {
            // Close
            Form currentForm = this.FindForm(); // Ensures where Topbar is located at
            if (currentForm != null)
            {
                currentForm.Hide(); // With Hide, because issue with closing whole program

                // Open
                if (FormManager.HomepageFormInstance == null || FormManager.HomepageFormInstance.IsDisposed)
                {
                    FormManager.HomepageFormInstance = new HomepageForm();

                }  // Checks if an  ProjectMenuInstance is selected and exists then redirects the user appropriately.
                FormManager.HomepageFormInstance.Show();
            }
        }

        private void lblHomepage_MouseEnter(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Underline | FontStyle.Italic);
            }
        }

        private void lblHomepage_MouseLeave(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Italic);
            }
        }

        private void lblProjekte_Click(object sender, EventArgs e)
        {
            // Close
            Form currentForm = this.FindForm(); // Ensures where Topbar is located at
            if (currentForm != null)
            {
                currentForm.Hide(); // With Hide, because issue with closing whole program

                // Open
                if (FormManager.ProjectMenuInstance == null || FormManager.ProjectMenuInstance.IsDisposed)
                {
                    FormManager.ProjectMenuInstance = new ProjectMenu();

                }  // Checks if an  ProjectMenuInstance is selected and exists then redirects the user appropriately.
                FormManager.ProjectMenuInstance.Show();
            }
        }

        private void lblProjekte_MouseEnter(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Underline | FontStyle.Italic);
            }
        }

        private void lblProjekte_MouseLeave(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Italic);
            }
        }

        private void lblGroup_MouseEnter(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Underline | FontStyle.Italic);
            }
        }

        private void lblGroup_MouseLeave(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Italic);
            }
        }
    }
}
