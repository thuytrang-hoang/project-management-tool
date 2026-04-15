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
using Programmierprojekt.Übersicht;
using Programmierprojekt.Sidebars;
using Programmierprojekt.Homepage;

namespace Programmierprojekt.Datenbank
{
    public partial class ProjectMenu : Form //Assignee: Ugur Bektas; Developer of GUI and functionality: Ugur Bektas; Translator: Languagemodel-Chat-GPT
    {

        private readonly IConfiguration Configuration;
        public ProjectMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Center window

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
            this.Activated += (s, e) => LoadDataToListView();

            //// Sidebar hinzufügen
            //pre_Sidebar preSidebar = new pre_Sidebar();
            //preSidebar.Dock = DockStyle.Left; // Sidebar links andocken
            //this.Controls.Add(preSidebar);
        }

        /*Handles the Event to Creat another Project.
         *Redirects To SubFormProject
         */
        private void addProjectButton_Click(object sender, EventArgs e)
        {

            if (FormManager.SubProjectMenuInstance == null || FormManager.SubProjectMenuInstance.IsDisposed)
            {
                FormManager.SubProjectMenuInstance = new SubFormProject();
            }
            FormManager.SubProjectMenuInstance.Show();
        }

        /* Loads project data from the database into the projectListViewBox. 
         * Fetching distinct projects  where the user is associated with the groupe/project.
         * Populates the projectListViewBox with projectName, creationDateProject and updatedDateProject
         */
        private void LoadDataToListView()
        {
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            string query = @"SELECT DISTINCT p.projectName, p.createdDate, p.updatedDate  FROM Projects p INNER JOIN Groups g ON p.groupId = g.groupId INNER JOIN UserGroups ug ON g.groupId = ug.groupId WHERE ug.userId = @userId;";


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Benutzer-ID des aktuell eingeloggten Benutzers übergeben
                        cmd.Parameters.AddWithValue("@userId", UserSession.Instance.UserId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            projectListViewBox.Items.Clear(); // Vorherige Einträge löschen

                            while (reader.Read())
                            {
                                // Ein neues ListViewItem für die aktuelle Zeile erstellen
                                ListViewItem item = new ListViewItem(reader["projectName"].ToString());

                                // Subitems für zusätzliche Spalten hinzufügen
                                item.SubItems.Add(Convert.ToDateTime(reader["createdDate"]).ToString("dd/MM/yyyy"));
                                item.SubItems.Add(Convert.ToDateTime(reader["updatedDate"]).ToString("dd/MM/yyyy"));

                                // Das ListViewItem zur ListView hinzufügen
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

        /*  These button click event handlers (groupFormButtonClick and profileMenuButtonBlick) enable navigation between different forms within the application.
         *  They handle redirection by showing the new form and hiding the current form.
         *  Additionally, they manage the correct closure of the current form when the new form is closed.
         */
        private void groupFormsButton_Click(object sender, EventArgs e)
        {
            if (FormManager.GroupMenuInstance == null || FormManager.GroupMenuInstance.IsDisposed)
            {
                FormManager.GroupMenuInstance = new GroupMenu();
                FormManager.GroupMenuInstance.FormClosed += (s, args) => this.Close();
            }

            FormManager.GroupMenuInstance.Show();
            FormManager.GroupMenuInstance.BringToFront();
            this.Hide();
        }

        private void profileMenuButton_Click(object sender, EventArgs e)
        {
            if (FormManager.AccountMenuInstance == null || FormManager.AccountMenuInstance.IsDisposed)
            {
                FormManager.AccountMenuInstance = new AccountMenu();
                FormManager.AccountMenuInstance.FormClosed += (s, args) => this.Close();
            }

            FormManager.AccountMenuInstance.Show();
            FormManager.AccountMenuInstance.BringToFront();
            this.Hide();
        }

        /* Checks if an item in the projectListViewBox is selected and then redirects the user appropriately.
         */
        private void projektListe_ItemActivate(object sender, EventArgs e)
        {
            if (projectListViewBox.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = projectListViewBox.SelectedItems[0];
                string projectName = selectedItem.Text;
                FormManager.CurrentProjectName = projectName;

                if (FormManager.StepsOverviewFormInstance == null || FormManager.StepsOverviewFormInstance.IsDisposed)
                {
                    FormManager.StepsOverviewFormInstance = new StepsOverviewForm();

                }
                this.Hide();
                FormManager.StepsOverviewFormInstance.Show();
             //   FormManager.StepsOverviewFormInstance.FormClosed += (s, args) => this.Show();
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
