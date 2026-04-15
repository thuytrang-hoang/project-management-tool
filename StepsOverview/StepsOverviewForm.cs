using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Options;
using Programmierprojekt.Datenbank;
using Programmierprojekt.DiagramManagement;
using Programmierprojekt.Homepage;
using Programmierprojekt.Managers_Menus.FilesOfCode;

namespace Programmierprojekt.Übersicht
{
    public partial class StepsOverviewForm : Form
    {
        public StepsOverviewForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Center window

        }
        private async void stepName1_Click(object sender, EventArgs e)
        {
            TopicForm topicForm = new TopicForm();
            topicForm.Show();
        }
        private async void stepName3_Click(object sender, EventArgs e)
        {
            TimeTableForm zeitplanForm = new TimeTableForm();
            zeitplanForm.Show();
        }

        private void stepName4_Click(object sender, EventArgs e)
        {
            UploadedCodeMenu uploadedCodeMenu = new UploadedCodeMenu();
            uploadedCodeMenu.Show();
        }

        // Developer returnProjectButton_Click Method: Ugur Bektas
        private void returnToProjectButton_Click(object sender, EventArgs e)
        {
            if (FormManager.ProjectMenuInstance == null || FormManager.ProjectMenuInstance.IsDisposed)
            {
                FormManager.ProjectMenuInstance = new ProjectMenu();
                FormManager.ProjectMenuInstance.FormClosed += (s, args) => this.Close();
            }
            this.Hide();
            FormManager.ProjectMenuInstance.Show();
        }

        // Copied from old Label
        private void lblThema_MouseEnter(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Bold | FontStyle.Underline);
            }
        }

        // Copied from old Label
        private void lblThema_MouseLeave(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Bold);
            }
        }

        // Thema
        // Copied from Sidebar
        private void lblThema_Click(object sender, EventArgs e)
        {
            // Close
            Form currentForm = this.FindForm(); // Ensures where Sidebar is located at
            if (currentForm != null)
            {
                currentForm.Hide(); // With Hide, because issue with closing whole program

                // Open
                if (FormManager.TopicFormInstance == null || FormManager.TopicFormInstance.IsDisposed)
                {
                    FormManager.TopicFormInstance = new TopicForm();

                }  // Checks if an  AccountMenuInstance is selected and exists then redirects the user appropriately.
                FormManager.TopicFormInstance.Show();
            }
        }

        private void lblTechnischeSpez_MouseEnter(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Bold | FontStyle.Underline);
            }
        }

        private void lblTechnischeSpez_MouseLeave(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Bold);
            }
        }

        private void lblTechnischeSpez_Click(object sender, EventArgs e)
        {
            if (FormManager.TechnischeSpezifikationenDiagrammeInstance == null || FormManager.TechnischeSpezifikationenDiagrammeInstance.IsDisposed)
            {
                FormManager.TechnischeSpezifikationenDiagrammeInstance = new TechnischeSpezifikationenDiagramme();
                FormManager.TechnischeSpezifikationenDiagrammeInstance.FormClosed += (s, args) => this.Close();
            }

            FormManager.TechnischeSpezifikationenDiagrammeInstance.Show();
            FormManager.TechnischeSpezifikationenDiagrammeInstance.BringToFront();
            this.Hide();
        }

        // Zeitplan und  -einteilung
        // Copied from Sidebar
        private void lblZeitplan_Click(object sender, EventArgs e)
        {
            // Close
            Form currentForm = this.FindForm(); // Ensures where Sidebar is located at
            if (currentForm != null)
            {
                currentForm.Hide(); // With Hide, because issue with closing whole program

                // Open
                if (FormManager.TimeTableFormInstance == null || FormManager.TimeTableFormInstance.IsDisposed)
                {
                    FormManager.TimeTableFormInstance = new TimeTableForm();

                }  // Checks if an  AccountMenuInstance is selected and exists then redirects the user appropriately.
                FormManager.TimeTableFormInstance.Show();
            }
        }

        private void lblZeitplan_MouseEnter(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Bold | FontStyle.Underline);
            }
        }

        private void lblZeitplan_MouseLeave(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Bold);
            }
        }

        // Code Übersicht
        // Copied from Sidebar
        private void lblCode_Click(object sender, EventArgs e)
        {
            // Close
            Form currentForm = this.FindForm(); // Ensures where Sidebar is located at
            if (currentForm != null)
            {
                currentForm.Hide(); // With Hide, because issue with closing whole program

                // Open
                if (FormManager.UploadedCodeMenuInstance == null || FormManager.UploadedCodeMenuInstance.IsDisposed)
                {
                    FormManager.UploadedCodeMenuInstance = new UploadedCodeMenu();

                }  // Checks if an  AccountMenuInstance is selected and exists then redirects the user appropriately.
                FormManager.UploadedCodeMenuInstance.Show();
            }
        }

        private void lblCode_MouseEnter(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Bold | FontStyle.Underline);
            }
        }

        private void lblCode_MouseLeave(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Bold);
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

        private void lblDeineSchritte_MouseEnter(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Underline | FontStyle.Italic);
            }
        }

        private void lblDeineSchritte_MouseLeave(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Italic);
            }
        }

        // Add picture design for the overview
        private void StepsOverviewForm_Load(object sender, EventArgs e)
        {
            string imagePath = @"Images\StepsOverview-Pfeile.png"; // Image path

            if (File.Exists(imagePath))
            {
                PictureBox pictureBox = new PictureBox
                {
                    Image = Image.FromFile(imagePath),
                    Location = new System.Drawing.Point(239, 224), // Position
                    Size = new System.Drawing.Size(736, 246),     // Size
                    SizeMode = PictureBoxSizeMode.Zoom,           // Adjust scaling
                    BorderStyle = BorderStyle.None               // Remove border
                };

                this.Controls.Add(pictureBox); // Add PictureBox to Form
                pictureBox.SendToBack();       // Send PictureBox to the background
            }
            else
            {
                MessageBox.Show("Bild nicht gefunden: " + imagePath, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
