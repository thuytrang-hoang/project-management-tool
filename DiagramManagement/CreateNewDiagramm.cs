using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmierprojekt.DiagramManagement
{
    // Form for creating a new diagram, allowing the user to specify its name and type
    public partial class CreateNewDiagramm : Form
    {
        // Functions were developed with support from ChatGPT after first implematation, which provided suggestions and optimizations during the implementation process

        // Properties for storing user input
        public string DiagramName { get; private set; }
        public string DiagramType { get; private set; }
        public string MemberName { get; private set; }

        private TextBox userInputTextBox;

        // Constructor initializes the form and sets the starting position
        public CreateNewDiagramm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Center window
            userInputTextBox = diagramName;

            userInputTextBox.TextChanged += diagramName_TextChanged;
        }

        // Updates the DiagramName property when the user types in the text box
        private void diagramName_TextChanged(object sender, EventArgs e)
        {
            string currentInput = userInputTextBox.Text;

            System.Diagnostics.Debug.WriteLine($"Aktuelle Eingabe: {currentInput}");

            DiagramName = currentInput;
        }

        // Handles the confirmation button click, setting properties and opening the selected diagram type
        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.DiagramName = userInputTextBox.Text;
            
            // Determine the selected diagram type
            DiagramType = UseCaseButton.Checked ? "Use-Case" :
                          KlassendiagrammButton.Checked ? "Klassendiagramm" :
                          "Komponentendiagramm";
            MemberName = Environment.UserName; // Current user

            DialogResult = DialogResult.OK; // Close window with OK
            Close();

            // Check type of diagramm
            if (UseCaseButton.Checked)
            {
                var useCaseForm = new UseCaseDiagramm(); // create new window for Use-Case-Diagramm
                useCaseForm.Show(); 
            }
            else if (KlassendiagrammButton.Checked)
            {
                var classDiagramForm = new Klassendiagramm(); // create new window for  Klassendiagramm
                classDiagramForm.Show(); 
            }
            else if (KomponentendiagrammButton.Checked)
            {
                var componentDiagramForm = new Komponentendiagramm(); // Ecreate new window for Komponentendiagramm
                componentDiagramForm.Show(); 
            }

            string diagramName = userInputTextBox.Text;
            MessageBox.Show($"Diagrammname: {diagramName}");

        }

        // These event handlers are required but do not need implementation
        private void UseCaseButton_CheckedChanged(object sender, EventArgs e)
        {}
        private void KlassendiagrammButton_CheckedChanged(object sender, EventArgs e)
        {}
        private void KomponentendiagrammButton_CheckedChanged(object sender, EventArgs e)
        {}
    }
}
