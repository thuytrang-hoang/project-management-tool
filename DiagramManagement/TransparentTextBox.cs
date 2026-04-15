using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmierprojekt.DiagramManagement
{
    // Custom transparent text box for overlaying text on diagrams
    public class TransparentTextBox : TextBox
    {
        // This Code was partially constructed with the help of ChatGPT4.o
        // Description: Support at the constructoin and optimization at "AddTextBox", "TextBoxClickHandler" and "TransparentTextBox"
        // The generated Code was revised by the programmer after feedback and adjustment was given.

        // Message displayed when prompting the user to place a text box
        public const string StartMessage = "Klicken Sie auf die Stelle, an der die TextBox erstellt werden soll.";


        // Moves the text box by a given x and y offset
        public void Move(int deltaX, int deltaY)
        {
            Location = new System.Drawing.Point(Location.X + deltaX, Location.Y + deltaY);
        }

        // Constructor initializing a transparent text box
        public TransparentTextBox()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
            BorderStyle = BorderStyle.None;
            ForeColor = Color.Black;
        }

        // Adds a transparent text box at the specified location
        public static void AddTextBox(Control parentControl, System.Drawing.Point location, string placeholderText = "")
        {
            // Create a new transparent text box
            TransparentTextBox textBox = new TransparentTextBox
            {
                Width = 200, // Set the width of the text box
                Height = 30, // Set the height of the text box
                Location = location, // Set the location of the text box
                Text = placeholderText, // Set optional placeholder text
                ReadOnly = false // default: editable
            };

            // Event handler for text changes
            textBox.TextChanged += (sender, e) =>
                {
                    TransparentTextBox tb = sender as TransparentTextBox;
                    Console.WriteLine($"Text geändert: {tb?.Text}");  // Log the changed text
                };

            // Add the text box to the parent control
            parentControl.Controls.Add(textBox);
        }

        // Handles user clicks to add a text box at the clicked position
        public static ClickResult TextBoxClickHandler(
                System.Drawing.Point clickPoint,
                MouseButtons buttons,
                int screenHeight,
                out string statusMessage)
        {
            ClickResult result = ClickResult.Canceled;
            statusMessage = string.Empty;

            if (buttons == MouseButtons.Left)
            {
                // Add a new TextBox to the specified parent control
                AddTextBox(Application.OpenForms[0].Controls["pictureBox"], clickPoint, "Neue TextBox");

                result = ClickResult.Created;
                statusMessage = "TextBox wurde erfolgreich hinzugefügt.";
            }
            else if (buttons == MouseButtons.Right)
            {
                // Cancel the action if the right mouse button is clicked
                result = ClickResult.Canceled;
                statusMessage = "Aktion abgebrochen.";
            }
            return result;
        }
    }
}
