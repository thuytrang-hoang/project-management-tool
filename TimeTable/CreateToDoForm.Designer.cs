namespace Programmierprojekt
{
    partial class CreateToDoForm
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
            lblTitel = new Label();
            lblTaskName = new Label();
            txtTaskName = new TextBox();
            lblResponsible = new Label();
            txtResponsible = new TextBox();
            lblDeadline = new Label();
            dtpDeadline = new DateTimePicker();
            btnCreate = new Button();
            lblDescription = new Label();
            txtDescription = new TextBox();
            dtpDeadlineTime = new DateTimePicker();
            btnToggleDeadline = new Button();
            SuspendLayout();
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Segoe UI", 16F);
            lblTitel.ForeColor = Color.FromArgb(64, 0, 64);
            lblTitel.Location = new Point(123, 42);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(155, 37);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "neue To-Do";
            // 
            // lblTaskName
            // 
            lblTaskName.AutoSize = true;
            lblTaskName.Location = new Point(127, 89);
            lblTaskName.Name = "lblTaskName";
            lblTaskName.Size = new Size(338, 20);
            lblTaskName.TabIndex = 1;
            lblTaskName.Text = "Bitte fügen Sie hier den Namen Ihrer Aufgabe ein:";
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(131, 112);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(536, 27);
            txtTaskName.TabIndex = 2;
            txtTaskName.TextChanged += txtTaskName_TextChanged;
            // 
            // lblResponsible
            // 
            lblResponsible.AutoSize = true;
            lblResponsible.Location = new Point(127, 276);
            lblResponsible.Name = "lblResponsible";
            lblResponsible.Size = new Size(281, 20);
            lblResponsible.TabIndex = 3;
            lblResponsible.Text = "Wer ist für diese Aufgabe verantwortlich?";
            // 
            // txtResponsible
            // 
            txtResponsible.Location = new Point(131, 299);
            txtResponsible.Name = "txtResponsible";
            txtResponsible.Size = new Size(536, 27);
            txtResponsible.TabIndex = 4;
            txtResponsible.TextChanged += txtResponsible_TextChanged;
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.Location = new Point(127, 347);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(301, 20);
            lblDeadline.TabIndex = 5;
            lblDeadline.Text = "Bitte geben Sie die Frist für die Aufgabe ein:";
            // 
            // dtpDeadline
            // 
            dtpDeadline.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpDeadline.Format = DateTimePickerFormat.Short;
            dtpDeadline.Location = new Point(131, 379);
            dtpDeadline.Name = "dtpDeadline";
            dtpDeadline.Size = new Size(136, 27);
            dtpDeadline.TabIndex = 6;
            dtpDeadline.ValueChanged += dtpDeadline_ValueChanged;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(549, 364);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(118, 42);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "erstellen";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(127, 163);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(173, 20);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Gebe deine Aufgabe ein:";
            lblDescription.Click += label1_Click_1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(131, 186);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(536, 75);
            txtDescription.TabIndex = 10;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // dtpDeadlineTime
            // 
            dtpDeadlineTime.CustomFormat = "HH:mm";
            dtpDeadlineTime.Format = DateTimePickerFormat.Custom;
            dtpDeadlineTime.Location = new Point(273, 379);
            dtpDeadlineTime.Name = "dtpDeadlineTime";
            dtpDeadlineTime.ShowUpDown = true;
            dtpDeadlineTime.Size = new Size(78, 27);
            dtpDeadlineTime.TabIndex = 11;
            // 
            // btnToggleDeadline
            // 
            btnToggleDeadline.Location = new Point(357, 377);
            btnToggleDeadline.Name = "btnToggleDeadline";
            btnToggleDeadline.Size = new Size(94, 29);
            btnToggleDeadline.TabIndex = 12;
            btnToggleDeadline.Text = "keine Frist";
            btnToggleDeadline.UseVisualStyleBackColor = true;
            btnToggleDeadline.Click += btnToggleDeadline_Click;
            // 
            // CreateToDoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnToggleDeadline);
            Controls.Add(dtpDeadlineTime);
            Controls.Add(txtDescription);
            Controls.Add(lblDescription);
            Controls.Add(btnCreate);
            Controls.Add(dtpDeadline);
            Controls.Add(lblDeadline);
            Controls.Add(txtResponsible);
            Controls.Add(lblResponsible);
            Controls.Add(txtTaskName);
            Controls.Add(lblTaskName);
            Controls.Add(lblTitel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CreateToDoForm";
            Text = "CreateToDoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitel;
        private Label lblTaskName;
        private TextBox txtTaskName;
        private Label lblResponsible;
        private TextBox txtResponsible;
        private Label lblDeadline;
        private DateTimePicker dtpDeadline;
        private Button btnCreate;
        private Label lblDescription;
        private TextBox txtDescription;
        private DateTimePicker dtpDeadlineTime;
        private Button btnToggleDeadline;
    }
}