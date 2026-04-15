using Programmierprojekt.Datenbank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmierprojekt.Sidebars
{
    public partial class pre_Sidebar : UserControl
    {
        public pre_Sidebar()
        {
            InitializeComponent();

            if (!DesignMode) // Check if the designer is currently active | annoying error message fixed
            {

            }
        }

        // Projekte
        // Copied from other Buttons with opening function
        private void btnProjects_Click(object sender, EventArgs e)
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

        // Gruppen
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

        private void btnProjects_MouseEnter(object sender, EventArgs e)
        {
            btnProjects.Font = new Font(btnProjects.Font, FontStyle.Underline);
        }

        private void btnProjects_MouseLeave(object sender, EventArgs e)
        {
            btnProjects.Font = new Font(btnProjects.Font, FontStyle.Regular);
        }

        private void btnGroup_MouseEnter(object sender, EventArgs e)
        {
            btnGroup.Font = new Font(btnProjects.Font, FontStyle.Underline);
        }

        private void btnGroup_MouseLeave(object sender, EventArgs e)
        {
            btnGroup.Font = new Font(btnProjects.Font, FontStyle.Regular);
        }
    }
}
