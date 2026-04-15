using Programmierprojekt.Datenbank;
using Programmierprojekt.DiagramManagement;
using Programmierprojekt.Managers_Menus.FilesOfCode;
using Programmierprojekt.Übersicht;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmierprojekt
{
    /*
    * Source: Youtube Tutorial: https://www.youtube.com/watch?v=nwtPnmPzJcY, 10.12.2024
    * Notiz: Hat Probleme und für Ansatz geholfen wie man ein Usercontrol verwendet und richtig erstellt.
    */
    public partial class Sidebar : UserControl
    {
        public Sidebar()
        {
            InitializeComponent();

            if (!DesignMode) // Check if the designer is currently active | annoying error message fixed
            {
                this.Dock = DockStyle.Left;
            }

            // Label changes to current Projectname, if its empty -> shows "Team Fuchs as example"
            if (string.IsNullOrWhiteSpace(FormManager.CurrentProjectName))
            {
                lblProjName.Text = "Team Fuchs";
            }

            else
            {
                lblProjName.Text = $"{FormManager.CurrentProjectName}";

            }
        }

        // Gruppe
        // Copied from other Buttons with opening function
        private void btnGroup_Click(object sender, EventArgs e)
        {
            // Close
            Form currentForm = this.FindForm(); // Ensures where Sidebar is located at
            if (currentForm != null)
            {
                currentForm.Hide(); // With Hide, because issue with closing whole program

                // Open
                if (FormManager.GroupMenuInstance == null || FormManager.GroupMenuInstance.IsDisposed)
                {
                    FormManager.GroupMenuInstance = new GroupMenu();

                }  // Checks if an  AccountMenuInstance is selected and exists then redirects the user appropriately.
                  FormManager.GroupMenuInstance.Show();
            }
        }
        // Highlight (Underline)
        private void btnGroup_MouseEnter(object sender, EventArgs e)
        {
            btnGroup.Font = new Font(btnGroup.Font, FontStyle.Underline);

        }

        private void btnGroup_MouseLeave(object sender, EventArgs e)
        {
            btnGroup.Font = new Font(btnGroup.Font, FontStyle.Regular);

        }

        // KI-Assitent
        // Copied from other Buttons with opening function
        private void btnAssistant_Click(object sender, EventArgs e)
        {
            // Close
            Form currentForm = this.FindForm(); // Ensures where Sidebar is located at
            if (currentForm != null)
            {
                currentForm.Hide(); // With Hide, because issue with closing whole program

                // Open
                if (FormManager.AssistanceFormInstance == null || FormManager.AssistanceFormInstance.IsDisposed)
                {
                    FormManager.AssistanceFormInstance = new AssistanceForm();

                }  // Checks if an  AccountMenuInstance is selected and exists then redirects the user appropriately.
                FormManager.AssistanceFormInstance.Show();
            }
        }
        // Highlight (Underline)
        private void btnAssistant_MouseEnter(object sender, EventArgs e)
        {
            btnAssistant.Font = new Font(btnGroup.Font, FontStyle.Underline);
        }

        private void btnAssistant_MouseLeave(object sender, EventArgs e)
        {
            btnAssistant.Font = new Font(btnGroup.Font, FontStyle.Regular);
        }

        // Deine Schritte
        // Copied from other Buttons with opening function
        private void btnSteps_Click(object sender, EventArgs e)
        {
            // Close
            Form currentForm = this.FindForm(); // Ensures where Sidebar is located at
            if (currentForm != null)
            {
                currentForm.Hide(); // With Hide, because issue with closing whole program

                // Open
                if (FormManager.StepsOverviewFormInstance == null || FormManager.StepsOverviewFormInstance.IsDisposed)
                {
                    FormManager.StepsOverviewFormInstance = new StepsOverviewForm();

                }  // Checks if an  AccountMenuInstance is selected and exists then redirects the user appropriately.
                FormManager.StepsOverviewFormInstance.Show();
            }
        }
        // Highlight (Underline)
        private void btnSteps_MouseEnter(object sender, EventArgs e)
        {
            btnSteps.Font = new Font(btnGroup.Font, FontStyle.Underline);
        }

        private void btnSteps_MouseLeave(object sender, EventArgs e)
        {
            btnSteps.Font = new Font(btnGroup.Font, FontStyle.Regular);
        }

        // Thema
        // Copied from other Buttons with opening function
        private void btnTopic_Click(object sender, EventArgs e)
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
        // Highlight (Underline)
        private void btnTopic_MouseEnter(object sender, EventArgs e)
        {
            btnTopic.Font = new Font(btnTopic.Font, btnTopic.Font.Style | FontStyle.Underline);
        }

        private void btnTopic_MouseLeave(object sender, EventArgs e)
        {
            btnTopic.Font = new Font(btnTopic.Font, btnTopic.Font.Style & ~FontStyle.Underline); // & ~ for Bitmanipulation (turns ~// off)
        }

        private void btnTechsp_Click(object sender, EventArgs e)
        {
            // Close
            Form currentForm = this.FindForm(); // Ensures where Sidebar is located at
            if (currentForm != null)
            {
                currentForm.Hide(); // With Hide, because issue with closing whole program

                // Open
                if (FormManager.TechnischeSpezifikationenDiagrammeInstance == null || FormManager.TechnischeSpezifikationenDiagrammeInstance.IsDisposed)
                {
                    FormManager.TechnischeSpezifikationenDiagrammeInstance = new TechnischeSpezifikationenDiagramme();

                }  // Checks if an  AccountMenuInstance is selected and exists then redirects the user appropriately.
                FormManager.TechnischeSpezifikationenDiagrammeInstance.Show();
            }
        }
        // Highlight (Underline)
        private void btnTechsp_MouseEnter(object sender, EventArgs e)
        {
            btnTechsp.Font = new Font(btnTechsp.Font, btnTechsp.Font.Style | FontStyle.Underline);
        }

        private void btnTechsp_MouseLeave(object sender, EventArgs e)
        {
            btnTechsp.Font = new Font(btnTechsp.Font, btnTechsp.Font.Style & ~FontStyle.Underline); // & ~ for Bitmanipulation (turns ~// off)
        }

        // Zeitplan- und Einteilung
        // Copied from other Buttons with opening function
        private void btnbtnTimeTable(object sender, EventArgs e)
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
        // Highlight (Underline)
        private void btnTimeTable_MouseEnter(object sender, EventArgs e)
        {
            btnTimeTable.Font = new Font(btnTimeTable.Font, btnTimeTable.Font.Style | FontStyle.Underline);
        }

        private void btnTimeTable_MouseLeave(object sender, EventArgs e)
        {
            btnTimeTable.Font = new Font(btnTimeTable.Font, btnTimeTable.Font.Style & ~FontStyle.Underline); // & ~ for Bitmanipulation (turns ~// off)
        }

        // Code-Übersicht
        // Copied from other Buttons with opening function
        private void btnCodeOverview_Click(object sender, EventArgs e)
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
        // Highlight (Underline)
        private void btnCodeOverview_MouseEnter(object sender, EventArgs e)
        {
            btnCodeOverview.Font = new Font(btnCodeOverview.Font, btnCodeOverview.Font.Style | FontStyle.Underline);
        }

        private void btnCodeOverview_MouseLeave(object sender, EventArgs e)
        {
            btnCodeOverview.Font = new Font(btnCodeOverview.Font, btnCodeOverview.Font.Style & ~FontStyle.Underline); // & ~ for Bitmanipulation (turns ~// off)
        }
    }
}
