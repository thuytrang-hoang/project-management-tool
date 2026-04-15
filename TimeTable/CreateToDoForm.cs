using Microsoft.VisualBasic;
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
    public partial class CreateToDoForm : Form
    {
        public string TaskName { get; private set; }
        public string TaskDescription { get; private set; }
        public string Responsible { get; private set; }
        public DateTime? Deadline { get; private set; }
        //set - only be changed within this class

        public CreateToDoForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Center window

            dtpDeadline.Enabled = true;
            dtpDeadlineTime.Enabled = true;
            btnToggleDeadline.Text = "Keine Frist";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskName.Text))
            {
                // Show error message -> if no name was entered
                MessageBox.Show("Bitte geben Sie einen Namen für die Aufgabe ein.",
                                "Fehler",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtResponsible.Text))
            {
                // -"-
                MessageBox.Show("Bitte geben Sie einen Verantwortlichen an.",
                        "Fehler",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                // -"-
                MessageBox.Show("Bitte geben Sie eine Beschreibung für die Aufgabe ein.",
                                "Fehler",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // Only combine if the deadline is active
            if (dtpDeadline.Enabled && dtpDeadlineTime.Enabled)
            {
                DateTime selectedDate = dtpDeadline.Value.Date; // Date from DateTimePicker
                DateTime selectedTime = dtpDeadlineTime.Value;// Time from DateTimePicker

                // Create deadline date and time
                Deadline = new DateTime(
                    selectedDate.Year,
                    selectedDate.Month,
                    selectedDate.Day,
                    selectedTime.Hour,
                    selectedTime.Minute,
                    0 // Set seconds to 0
                );
            }
            else
            {
                Deadline = null; // No deadline 
            }

            // Save values
            TaskName = txtTaskName.Text; // Save task name
            TaskDescription = txtDescription.Text; // Save description
            Responsible = txtResponsible.Text; // Save responsible person
            //Deadline = dtpDeadline.Enabled ? dtpDeadline.Value : (DateTime?)null; //wenn dtpDeadline.Enabled == true, dann dtpDeadline.Value, sonst null 

            // Close dialog / pass data
            this.DialogResult = DialogResult.OK; // Indicates that the dialog was successful
            this.Close();
        }

        private void txtTaskName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResponsible_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDeadline_ValueChanged(object sender, EventArgs e)
        {

        }

        // Button for Turning deadline on/off
        private void btnToggleDeadline_Click(object sender, EventArgs e)
        {
            // Check if the deadline is active
            if (dtpDeadline.Enabled)
            {
                // Deactivate deadline
                dtpDeadline.Enabled = false;
                dtpDeadlineTime.Enabled = false;
                Deadline = null;

                // Gray
                dtpDeadline.BackColor = Color.LightGray;
                dtpDeadlineTime.BackColor = Color.LightGray;

                // Change button text
                btnToggleDeadline.Text = "Frist setzen";
            }
            else
            {
                // Activate deadline
                dtpDeadline.Enabled = true;
                dtpDeadlineTime.Enabled = true;

                // Set default values
                dtpDeadline.Value = DateTime.Now.Date;
                dtpDeadlineTime.Value = DateTime.Now;

                dtpDeadline.BackColor = SystemColors.Window;
                dtpDeadlineTime.BackColor = SystemColors.Window;

                btnToggleDeadline.Text = "Keine Frist";
            }
        }
    }
}
