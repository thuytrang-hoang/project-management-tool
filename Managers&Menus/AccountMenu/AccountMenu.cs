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
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Programmierprojekt.Homepage;

namespace Programmierprojekt.Datenbank
{
    public partial class AccountMenu : Form //Assignee: Ugur Bektas; Developer of GUI and functionality: Ugur Bektas; Translator: Languagemodel-Chat-GPT
    {
        private readonly IConfiguration Configuration;
        public AccountMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Center window

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();

            if (UserSession.Instance.UserId != 1)
            {
                this.deleteInformationFromTables.Hide();
            }
        }

        /*
         *LogOut function
         *Added Method to Reset User to ensure no conflicts. Same with FormManager Instances.
         */
        private void logOutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchtest du dich wirklich abmelden?", "Abmeldung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UserSession.Instance.ResetUser();
                FormManager.CloseAllForms();
                LogIn newLogin = new LogIn();
                FormManager.LogInInstance = newLogin;
                newLogin.Show();
            }
        }



        /* Helper: Chat-GPT  Prompt: "I want to click on a label and change the text with an Input."
         * Code Based on Helped Output; 
         * display Methods based on the first display Method "displayFirstNameLabel_Click", so no further comments
         * Handles the click event on a label to allow editing of the displayed first name.
         *  Converts the clicked label into a RichTextBox for editable input, preserving the original appearance and location.
         *  Commits the updated first name to the User session and the database when the Enter key is pressed.
         *  Updates the label text with the new first name and removes the RichTextBox from the display.
         *   The RichTextBox is also removed if it loses focus, and the original label is made visible again.
         */
        private void displayFirstNameLabel_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            RichTextBox richTextBox = new RichTextBox();

            richTextBox.Text = clickedLabel.Text;
            richTextBox.Location = clickedLabel.Location;
            richTextBox.Size = clickedLabel.Size;
            richTextBox.Font = clickedLabel.Font;
            this.Controls.Add(richTextBox);
            richTextBox.BringToFront();
            richTextBox.Focus();


            richTextBox.KeyDown += (s, args) =>
            {
                if (args.KeyCode == Keys.Enter)
                {
                    UserSession.Instance.Firstname = richTextBox.Text.Trim();
                    clickedLabel.Text = richTextBox.Text.Trim();
                    this.Controls.Remove(richTextBox);
                    clickedLabel.Show();
                    string firstname = clickedLabel.Text;
                    string connectionString = Configuration.GetConnectionString("DefaultConnection");
                    string updateQueryLoggedFirstName = "UPDATE [User] SET firstname = @firstname WHERE userId = @userId";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            using (SqlCommand updatedFirstNameCmd = new SqlCommand(updateQueryLoggedFirstName, conn))
                            {
                                updatedFirstNameCmd.Parameters.AddWithValue("@firstname", firstname);
                                updatedFirstNameCmd.Parameters.AddWithValue("@userId", UserSession.Instance.UserId);
                                int rowsAffected = updatedFirstNameCmd.ExecuteNonQuery();
                                if (rowsAffected != 0)
                                {
                                    MessageBox.Show("Firstname successfully updated.");
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update the firstname. User not found.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Fehler beim Ändern des Vornamen: {ex.Message}");
                        }
                    }
                }
            };
            richTextBox.LostFocus += (s, args) =>
            {
                this.Controls.Remove(richTextBox);
                clickedLabel.Show();
            };
            clickedLabel.Hide();
        }

        private void displayLastNameLabel_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            RichTextBox richTextBox = new RichTextBox();

            richTextBox.Text = clickedLabel.Text;
            richTextBox.Location = clickedLabel.Location;
            richTextBox.Size = clickedLabel.Size;
            richTextBox.Font = clickedLabel.Font;
            this.Controls.Add(richTextBox);
            richTextBox.BringToFront();
            richTextBox.Focus();
            richTextBox.KeyDown += (s, args) =>
            {
                if (args.KeyCode == Keys.Enter)
                {
                    UserSession.Instance.Lastname = richTextBox.Text.Trim();
                    clickedLabel.Text = richTextBox.Text.Trim();
                    this.Controls.Remove(richTextBox);
                    clickedLabel.Show();
                    string lastname = clickedLabel.Text;
                    string connectionString = Configuration.GetConnectionString("DefaultConnection");
                    string updateQueryLoggedLastName = "UPDATE [User] SET lastname = @lastname WHERE userId = @userId";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();

                            using (SqlCommand updatedLastNameCmd = new SqlCommand(updateQueryLoggedLastName, conn))
                            {
                                updatedLastNameCmd.Parameters.AddWithValue("@lastname", lastname);
                                updatedLastNameCmd.Parameters.AddWithValue("@userId", UserSession.Instance.UserId);
                                int rowsAffected = updatedLastNameCmd.ExecuteNonQuery();

                                if (rowsAffected != 0)
                                {
                                    MessageBox.Show("Lastname successfully updated.");
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update the lastname. User not found.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Fehler beim Ändern des Nachnamen: {ex.Message}");
                        }
                    }
                }
            };
            richTextBox.LostFocus += (s, args) =>
            {
                this.Controls.Remove(richTextBox);
                clickedLabel.Show();
            };
            clickedLabel.Hide();
        }

        private void displayUserNameLabel_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Text = clickedLabel.Text;
            richTextBox.Location = clickedLabel.Location;
            richTextBox.Size = clickedLabel.Size;
            richTextBox.Font = clickedLabel.Font;
            this.Controls.Add(richTextBox);
            richTextBox.BringToFront();
            richTextBox.Focus();
            richTextBox.KeyDown += (s, args) =>
            {
                if (args.KeyCode == Keys.Enter)
                {
                    UserSession.Instance.Username = richTextBox.Text.Trim();
                    clickedLabel.Text = richTextBox.Text.Trim();
                    this.Controls.Remove(richTextBox);
                    clickedLabel.Show();
                    string username = clickedLabel.Text;
                    string connectionString = Configuration.GetConnectionString("DefaultConnection");
                    string updateQueryLoggedUserName = "UPDATE [User] SET username = @username WHERE userId = @userId";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();

                            using (SqlCommand updatedUserNameCmd = new SqlCommand(updateQueryLoggedUserName, conn))
                            {
                                updatedUserNameCmd.Parameters.AddWithValue("@username", username);
                                updatedUserNameCmd.Parameters.AddWithValue("@userId", UserSession.Instance.UserId);
                                int rowsAffected = updatedUserNameCmd.ExecuteNonQuery();
                                if (rowsAffected != 0)
                                {
                                    MessageBox.Show("Username successfully updated.");
                                }
                                else
                                {
                                    MessageBox.Show("Failed to update the username. User not found.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Fehler beim Ändern des Benutzernamen: {ex.Message}");
                        }
                    }
                }
            };
            richTextBox.LostFocus += (s, args) =>
            {
                this.Controls.Remove(richTextBox);
                clickedLabel.Show();
            };
            clickedLabel.Hide();
        }

        // Returns you to the ProjectMenu 
        private void returnToProjectMenuButton_Click(object sender, EventArgs e)
        {
            if (FormManager.ProjectMenuInstance == null || FormManager.ProjectMenuInstance.IsDisposed)
            {
                FormManager.ProjectMenuInstance = new ProjectMenu();
                FormManager.ProjectMenuInstance.FormClosed += (s, args) => this.Close();
            }

            this.Hide();
            FormManager.ProjectMenuInstance.Show();

        }

        /* This method handles the click event for deleting information from specific database tables.
         * Only User Information isnt deleted.
         */

        private void deleteInformationFromTables_Click(object sender, EventArgs e)
        {


            string connectionString = Configuration.GetConnectionString("DefaultConnection");

            string[] deleteQueries =
            {
                "DELETE FROM [PROJECTS];",
                "DELETE FROM [USERGROUPS];",
                "DELETE FROM [TEMPORARYUSERLIST];",
                "DELETE FROM [GROUPS];",
                "DELETE FROM [TODO];",
                "DELETE FROM [TIMETABLE];",
                "DELETE FROM [UPLOADEDCODEFILES];"
            };

            using (SqlConnection conn = new SqlConnection(connectionString))
            {


                conn.Open();

                foreach (string deleteQuery in deleteQueries)
                {
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show($"Erfolgreich gesäubert");

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

        private void lblProfil_MouseEnter(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Underline | FontStyle.Italic);
            }
        }

        private void lblProfil_MouseLeave(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Italic);
            }
        }

    }
}
