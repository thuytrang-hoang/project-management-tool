using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Programmierprojekt.Homepage;

namespace Programmierprojekt.Datenbank
{
    public partial class GroupMenu : Form //Assignee: Ugur Bektas; Developer of GUI: Trang created it and Ugur Bektas adjusted  it; Functionality: Ugur Bektas; Translator: Languagemodel-Chat-GPT
    {
        /* Similiar Methods to ProjectMenu so the comments are short.
         */

        private readonly IConfiguration Configuration;
        public GroupMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Center window

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
            this.Activated += (s, e) => updateGroupListViewBox();
        }

        // Return ProjektMenu
        private void returnProjectMenuButton_Click(object sender, EventArgs e)
        {
            if (FormManager.ProjectMenuInstance == null || FormManager.ProjectMenuInstance.IsDisposed)
            {
                FormManager.ProjectMenuInstance = new ProjectMenu();
                FormManager.ProjectMenuInstance.FormClosed += (s, args) => this.Close();
            }
            this.Hide();
            FormManager.ProjectMenuInstance.Show();
        }


        /* Helper: Chat-GPT, w3schools Promp: "What SQL-Statement to have an User specific Interface"
         * Based Code on the Help
         * Loads project data from the database into the projectListViewBox. 
         * Fetches all groups associated with the currently logged-in user by querying the Groups and UserGroups tables.
         * Populates the projectListViewBox with projectName, creationDateProject and updatedDateProject
         */
        private void updateGroupListViewBox()
        {
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            string query = @"SELECT g.groupId, g.groupName FROM Groups g INNER JOIN UserGroups ug ON g.groupId = ug.groupId WHERE ug.userId = @userId; ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", UserSession.Instance.UserId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            groupListViewBox.Items.Clear();

                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["groupName"].ToString());
                                groupListViewBox.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler beim Laden der Gruppen: {ex.Message}");
                }
            }

        }

        //Redirects the User after clicking on an item in the groupListViewBox
        private void groupListViewBox_ItemActivate(object sender, EventArgs e)
        {
            if (groupListViewBox.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = groupListViewBox.SelectedItems[0];
                string groupName = selectedItem.Text;
                FormManager.CurrentGroupName = groupName;
                if (FormManager.SubFormGroupInstance == null || FormManager.SubFormGroupInstance.IsDisposed)
                {
                    FormManager.SubFormGroupInstance = new SubFormGroup();
                }
                FormManager.SubFormGroupInstance.Show();
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
    }
}
