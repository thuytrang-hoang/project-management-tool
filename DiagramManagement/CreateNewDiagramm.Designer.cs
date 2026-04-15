namespace Programmierprojekt.DiagramManagement
{
    partial class CreateNewDiagramm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UseCaseButton = new RadioButton();
            KlassendiagrammButton = new RadioButton();
            KomponentendiagrammButton = new RadioButton();
            diagramName = new TextBox();
            confirmButton = new Button();
            NeuesDiagrammÜberschrift = new Label();
            NamenDesDiagrammes = new Label();
            DiagrammAuswählen = new Label();
            SuspendLayout();
            // 
            // UseCaseButton
            // 
            UseCaseButton.AutoSize = true;
            UseCaseButton.Font = new Font("Segoe UI", 11F);
            UseCaseButton.Location = new System.Drawing.Point(73, 183);
            UseCaseButton.Name = "UseCaseButton";
            UseCaseButton.Size = new Size(208, 29);
            UseCaseButton.TabIndex = 0;
            UseCaseButton.TabStop = true;
            UseCaseButton.Text = "Use-Case-Diagramm";
            UseCaseButton.UseVisualStyleBackColor = false;
            UseCaseButton.CheckedChanged += UseCaseButton_CheckedChanged;
            // 
            // KlassendiagrammButton
            // 
            KlassendiagrammButton.AutoSize = true;
            KlassendiagrammButton.Font = new Font("Segoe UI", 11F);
            KlassendiagrammButton.Location = new System.Drawing.Point(303, 183);
            KlassendiagrammButton.Name = "KlassendiagrammButton";
            KlassendiagrammButton.Size = new Size(182, 29);
            KlassendiagrammButton.TabIndex = 1;
            KlassendiagrammButton.TabStop = true;
            KlassendiagrammButton.Text = "Klassendiagramm";
            KlassendiagrammButton.UseVisualStyleBackColor = false;
            KlassendiagrammButton.CheckedChanged += KlassendiagrammButton_CheckedChanged;
            // 
            // KomponentendiagrammButton
            // 
            KomponentendiagrammButton.AutoSize = true;
            KomponentendiagrammButton.Font = new Font("Segoe UI", 11F);
            KomponentendiagrammButton.Location = new System.Drawing.Point(507, 183);
            KomponentendiagrammButton.Name = "KomponentendiagrammButton";
            KomponentendiagrammButton.Size = new Size(238, 29);
            KomponentendiagrammButton.TabIndex = 2;
            KomponentendiagrammButton.TabStop = true;
            KomponentendiagrammButton.Text = "Komponentendiagramm";
            KomponentendiagrammButton.UseVisualStyleBackColor = false;
            KomponentendiagrammButton.CheckedChanged += KomponentendiagrammButton_CheckedChanged;
            // 
            // diagramName
            // 
            diagramName.Font = new Font("Segoe UI", 11F);
            diagramName.Location = new System.Drawing.Point(64, 310);
            diagramName.Name = "diagramName";
            diagramName.Size = new Size(681, 32);
            diagramName.TabIndex = 5;
            diagramName.TextChanged += diagramName_TextChanged;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.FromArgb(235, 232, 240);
            confirmButton.Cursor = Cursors.Hand;
            confirmButton.Font = new Font("Segoe UI", 9F);
            confirmButton.Location = new System.Drawing.Point(630, 377);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(115, 29);
            confirmButton.TabIndex = 6;
            confirmButton.Text = "erstellen";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // NeuesDiagrammÜberschrift
            // 
            NeuesDiagrammÜberschrift.AutoSize = true;
            NeuesDiagrammÜberschrift.Font = new Font("Segoe UI", 16F);
            NeuesDiagrammÜberschrift.ForeColor = Color.FromArgb(64, 0, 64);
            NeuesDiagrammÜberschrift.Location = new System.Drawing.Point(64, 61);
            NeuesDiagrammÜberschrift.Name = "NeuesDiagrammÜberschrift";
            NeuesDiagrammÜberschrift.Size = new Size(330, 37);
            NeuesDiagrammÜberschrift.TabIndex = 10;
            NeuesDiagrammÜberschrift.Text = "Neues Diagramm erstellen";
            // 
            // NamenDesDiagrammes
            // 
            NamenDesDiagrammes.AutoSize = true;
            NamenDesDiagrammes.Font = new Font("Segoe UI", 11F);
            NamenDesDiagrammes.Location = new System.Drawing.Point(64, 260);
            NamenDesDiagrammes.Name = "NamenDesDiagrammes";
            NamenDesDiagrammes.Size = new Size(455, 25);
            NamenDesDiagrammes.TabIndex = 13;
            NamenDesDiagrammes.Text = "Bitte fügen Sie hier den Namen des Diagrammes ein:";
            // 
            // DiagrammAuswählen
            // 
            DiagrammAuswählen.AutoSize = true;
            DiagrammAuswählen.Font = new Font("Segoe UI", 11F);
            DiagrammAuswählen.Location = new System.Drawing.Point(64, 139);
            DiagrammAuswählen.Name = "DiagrammAuswählen";
            DiagrammAuswählen.Size = new Size(421, 25);
            DiagrammAuswählen.TabIndex = 14;
            DiagrammAuswählen.Text = "Bitte wählen Sie den Typen des Diagrammes aus:";
            // 
            // CreateNewDiagramm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(DiagrammAuswählen);
            Controls.Add(NamenDesDiagrammes);
            Controls.Add(NeuesDiagrammÜberschrift);
            Controls.Add(confirmButton);
            Controls.Add(diagramName);
            Controls.Add(KomponentendiagrammButton);
            Controls.Add(KlassendiagrammButton);
            Controls.Add(UseCaseButton);
            MaximizeBox = false;
            Name = "CreateNewDiagramm";
            Text = "CreateNewDiagramm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton UseCaseButton;
        private RadioButton KlassendiagrammButton;
        private RadioButton KomponentendiagrammButton;
        private TextBox diagramName;
        private Button confirmButton;
        private Label NeuesDiagrammÜberschrift;
        private Label NamenDesDiagrammes;
        private Label DiagrammAuswählen;
    }
}