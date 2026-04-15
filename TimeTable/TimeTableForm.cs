using Programmierprojekt.Datenbank;
using Programmierprojekt.Homepage;
using Programmierprojekt.TimeTable;
using Programmierprojekt.Topbar;
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
    * Source: ChatGPT 4.0, 04.12.2024
    * Prompt: How do you create a Timetable in C#.
    * Notiz: ChatGPT für das Verständnis der LisView verwendet. Funktionen selber implementiert.
    */
    public partial class TimeTableForm : Form
    {
        public TimeTableForm()
        {
            InitializeComponent(); // Initialize the form and its components
            this.StartPosition = FormStartPosition.CenterScreen; // Center window
        }

        private void btnCreateToDo_Click(object sender, EventArgs e)
        {
            CreateToDoForm createToDoForm = new CreateToDoForm();

            // Open CreateToDoForm as a modal dialog (blocks main form until this form is closed)
            if (createToDoForm.ShowDialog() == DialogResult.OK)
            {
                // Retrieve values entered in the CreateToDoForm
                string name = createToDoForm.TaskName;
                string description = createToDoForm.TaskDescription;
                string responsible = createToDoForm.Responsible;

                DateTime? deadline = createToDoForm.Deadline;

                // Temporary: Add the retrieved values to the ListView
                ListViewItem item = new ListViewItem(name);
                item.SubItems.Add(description);
                item.SubItems.Add(deadline.HasValue ? deadline.Value.ToString("yyyy-MM-dd HH:mm") : "Keine Frist");
                item.SubItems.Add(responsible);
                lvTasks.Items.Add(item);

            }
        }

        private int lastSortedColumn = -1; // Stores the index of the last sorted column
        private bool sortAscending = true; // Determines the sort order (ascending or descending)

        private void lvTasks_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Toggle sort direction if the same column is clicked again
            if (e.Column == lastSortedColumn)
                sortAscending = !sortAscending;
            else
                sortAscending = true; // Default to ascending order for a new column

            lastSortedColumn = e.Column;

            // Set the custom comparer for sorting the ListView
            lvTasks.ListViewItemSorter = new ListViewItemComparer(e.Column, sortAscending);
            lvTasks.Sort(); // Sort the ListView based on the comparer
        }

        private void lvTasks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ListViewItem item = lvTasks.Items[e.Index]; //index of the affected item

            // Cross out when done
            if (e.NewValue == CheckState.Checked)
            {
                // item.BackColor = Color.LightGreen; // Mark as done (old)
                item.Font = new Font(item.Font, FontStyle.Strikeout);
            }
            else
            {
                // item.BackColor = SystemColors.Window; // (old)
                item.Font = new Font(item.Font, FontStyle.Regular); //Back to default color

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

        private void lblZeitplan_MouseEnter(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Underline | FontStyle.Italic);
            }
        }

        private void lblZeitplan_MouseLeave(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Italic);
            }
        }
    }
}
