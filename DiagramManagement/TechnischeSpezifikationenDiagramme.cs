using Programmierprojekt.Datenbank;
using Programmierprojekt.Homepage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programmierprojekt.DiagramManagement
{
    // Form for managing technical specifications of diagrams
    public partial class TechnischeSpezifikationenDiagramme : Form
    {
        // Functions were developed with support from ChatGPT after first implemantation, which provided suggestions and optimizations during the implementation process

        // Constructor initializes the form and centers it on the screen
        public TechnischeSpezifikationenDiagramme()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Center window
        }

        // Handles the creation of a new diagram when the corresponding button is clicked
        private void newDiagrammButton_Click(object sender, EventArgs e)
        {
            var createNewDiagramForm = new CreateNewDiagramm();

            if (createNewDiagramForm.ShowDialog() == DialogResult.OK)
            {
                // Retrieve data from the dialog
                string diagramType = createNewDiagramForm.DiagramType;
                string diagramName = createNewDiagramForm.DiagramName;
                string memberName = createNewDiagramForm.MemberName;
                string currentDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // Create a new item for the ListView
                var item = new ListViewItem(diagramType); // First column: diagram type
                item.SubItems.Add(diagramName);          // Second column: diagram name
                item.SubItems.Add(currentDate);          // Third column: creation date
                item.SubItems.Add(memberName);           // Fourth column: user name

                // Add the new diagram entry to the ListView
                lvDiagrams.Items.Add(item);
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

        private void lblTechnSpez_MouseEnter(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Underline | FontStyle.Italic);
            }
        }

        private void lblTechnSpez_MouseLeave(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Italic);
            }
        }
    }
}
