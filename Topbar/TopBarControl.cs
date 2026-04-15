using Programmierprojekt.Datenbank;
using Programmierprojekt.Homepage;
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

namespace Programmierprojekt.Topbar
{
    public partial class TopBarControl : UserControl
    {
        public TopBarControl()
        {
            InitializeComponent();

            if (!DesignMode)
            {
            }

            /*
            * Source: ChatGPT 4.0, 19.01.2024
            * Prompt: Help me fix this error message in c# visual studio: 
            * Das Steuerelement "System.Windows.Forms.PictureBox" hat eine unbehandelte Ausnahme im Designer ausgelöst und wurde deaktiviert.
            * Ausnahme: Object reference not set to an instance of an object.
            * Stapelüberwachung: at System.Windows.Forms.PictureBox.OnPaint(PaintEventArgs pe)
            * Notiz: Fehlermeldung somit aufgehoben. Problem war, dass wenn kein Username eingegeben dieser leer ist.
            */
            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime) // LicenseManager.UsageMode specifies the mode in which the application runs -> prevents designer crashes by executing certain sections of code only at runtime

            {
                // Ensure that UserSession.Instance exists before accessing it
                if (UserSession.Instance != null)
                {
                    btnName.Text = $"{UserSession.Instance.Firstname} {UserSession.Instance.Lastname}";
                }
                else
                {
                    btnName.Text = "Vorname Nachname"; 
                }
            }
        }

        // Homepage Button
        private void btnHomepage_Click(object sender, EventArgs e)
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

                }  // Checks if an  ProjectMenuInstance is selected and exists then redirects the user appropriately
                FormManager.HomepageFormInstance.Show();
            }
        }

        // Vorname Nachname Button
        private void btnName_Click(object sender, EventArgs e)
        {
            // Close
            Form currentForm = this.FindForm(); // Ensures where Topbar is located at
            if (currentForm != null)
            {
                currentForm.Hide(); // With Hide, because issue with closing whole program

                // Open
                if (FormManager.AccountMenuInstance == null || FormManager.AccountMenuInstance.IsDisposed)
                {
                    FormManager.AccountMenuInstance = new AccountMenu();

                }  // Checks if an  AccountMenuInstance is selected and exists then redirects the user appropriately.
                FormManager.AccountMenuInstance.Show();


            }
        }

        /*
        * Source: ChatGPT 4.0, 16.12.2024
        * Prompt: Help me to create a simple round Icon.
        * Notiz: ChatGPT für das Verständnis der Zeichnungen verwendet.
        */
        private void pictureBoxHomepage_Paint(object sender, PaintEventArgs e)
        {
            // Round shape
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // AntiAlias provides soft edges

            // Define colors
            Color outerCircleColor = Color.FromArgb(146, 136, 196); // rgb (146,136,196)
            Color innerCircleColor = Color.FromArgb(173, 166, 209); // rgb (173,166,209)
            Color textColor = Color.White; // Weiß bleibt für das "H"

            // Draw inner circle
            using (Brush innerBrush = new SolidBrush(innerCircleColor)) // Using to make it disappear again
            {
                e.Graphics.FillEllipse(innerBrush, 0, 0, 37, 37);
            }

            // Draw outer circle (frame)
            using (Pen outerPen = new Pen(outerCircleColor, 2)) // Thickness 2px
            {
                e.Graphics.DrawEllipse(outerPen, 1, 1, 35, 35); // Thin frame inside
            }

            using (Font font = new Font("Arial", 12, FontStyle.Italic))
            using (Brush textBrush = new SolidBrush(Color.White)) // Textcolor
            {
                StringFormat sf = new StringFormat // Alignment of the text
                {
                    Alignment = StringAlignment.Center, // Horizontally centered
                    LineAlignment = StringAlignment.Center // Vertically centered
                };
                e.Graphics.DrawString("H", font, textBrush, new RectangleF(0, 0, 37, 37), sf);
            }
        }

        private void pictureBoxVN_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Farben für den Kreis
            Color outerCircleColor = Color.FromArgb(146, 136, 196);
            Color innerCircleColor = Color.FromArgb(173, 166, 209);
            Color textColor = Color.White;

            // Inner circle
            using (Brush innerBrush = new SolidBrush(innerCircleColor))
            {
                e.Graphics.FillEllipse(innerBrush, 0, 0, 37, 37);
            }

            // Outer circle 
            using (Pen outerPen = new Pen(outerCircleColor, 2))
            {
                e.Graphics.DrawEllipse(outerPen, 1, 1, 35, 35);
            }

            // Make sure that Firstname and Lastname are not null
            string initials = "??"; // Fallback value

            if (UserSession.Instance != null &&
                !string.IsNullOrEmpty(UserSession.Instance.Firstname) &&
                !string.IsNullOrEmpty(UserSession.Instance.Lastname))
            {
                initials = $"{UserSession.Instance.Firstname[0]}{UserSession.Instance.Lastname[0]}";
            }

            // VN
            using (Font font = new Font("Arial", 10, FontStyle.Italic))
            using (Brush textBrush = new SolidBrush(textColor))
            {
                StringFormat sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                e.Graphics.DrawString(initials, font, textBrush, new RectangleF(0, 0, 37, 37), sf);
            }
        }

        // Vorname Nachname Icon
        // Copied from "Vorname Nachname"
        private void pictureBoxVN_Click(object sender, EventArgs e)
        {
            // Close
            Form currentForm = this.FindForm(); // Ensures where Topbar is located at
            if (currentForm != null)
            {
                currentForm.Hide(); // With Hide, because issue with closing whole program

                // Open
                if (FormManager.AccountMenuInstance == null || FormManager.AccountMenuInstance.IsDisposed)
                {
                    FormManager.AccountMenuInstance = new AccountMenu();

                }  // Checks if an  AccountMenuInstance is selected and exists then redirects the user appropriately.
                FormManager.AccountMenuInstance.Show();


            }
        }

        // Homepage Icon
        private void pictureBoxHomepage_Click(object sender, EventArgs e)
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
    }
}
