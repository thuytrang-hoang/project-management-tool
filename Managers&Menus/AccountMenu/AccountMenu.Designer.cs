namespace Programmierprojekt.Datenbank
{
    partial class AccountMenu
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            profileLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            displayLastNameLabel = new Label();
            displayFirstNameLabel = new Label();
            logOutButton = new Button();
            displayUserNameLabel = new Label();
            userNameLabel = new Label();
            returnToProjectMenuButton = new Button();
            topBarControl1 = new Topbar.TopBarControl();
            sidebar1 = new Sidebar();
            lblHomepage = new Label();
            lblTrennung1 = new Label();
            lblProfil = new Label();
            deleteInformationFromTables = new Button();
            SuspendLayout();
            // 
            // profileLabel
            // 
            profileLabel.AutoSize = true;
            profileLabel.BackColor = Color.Transparent;
            profileLabel.Font = new Font("Segoe UI", 20F);
            profileLabel.ForeColor = Color.FromArgb(64, 0, 64);
            profileLabel.Location = new Point(245, 133);
            profileLabel.Name = "profileLabel";
            profileLabel.Size = new Size(98, 46);
            profileLabel.TabIndex = 3;
            profileLabel.Text = "Profil";
            // 
            // lastNameLabel
            // 
            lastNameLabel.BackColor = Color.Transparent;
            lastNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = Color.FromArgb(64, 0, 64);
            lastNameLabel.Location = new Point(245, 307);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(137, 49);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Nachname:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.BackColor = Color.Transparent;
            firstNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLabel.ForeColor = Color.FromArgb(64, 0, 64);
            firstNameLabel.Location = new Point(245, 232);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(137, 49);
            firstNameLabel.TabIndex = 5;
            firstNameLabel.Text = "Vorname:";
            // 
            // displayLastNameLabel
            // 
            displayLastNameLabel.BackColor = Color.Transparent;
            displayLastNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayLastNameLabel.ForeColor = Color.Black;
            displayLastNameLabel.Location = new Point(389, 307);
            displayLastNameLabel.Name = "displayLastNameLabel";
            displayLastNameLabel.Size = new Size(301, 49);
            displayLastNameLabel.TabIndex = 6;
            displayLastNameLabel.Text = UserSession.Instance.Lastname;
            displayLastNameLabel.Click += displayLastNameLabel_Click;
            // 
            // displayFirstNameLabel
            // 
            displayFirstNameLabel.BackColor = Color.Transparent;
            displayFirstNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayFirstNameLabel.ForeColor = Color.Black;
            displayFirstNameLabel.Location = new Point(389, 232);
            displayFirstNameLabel.Name = "displayFirstNameLabel";
            displayFirstNameLabel.Size = new Size(207, 49);
            displayFirstNameLabel.TabIndex = 7;
            displayFirstNameLabel.Text = UserSession.Instance.Firstname;
            displayFirstNameLabel.Click += displayFirstNameLabel_Click;
            // 
            // logOutButton
            // 
            logOutButton.BackColor = Color.FromArgb(235, 232, 240);
            logOutButton.Cursor = Cursors.Hand;
            logOutButton.Location = new Point(886, 83);
            logOutButton.Margin = new Padding(3, 4, 3, 4);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(98, 29);
            logOutButton.TabIndex = 8;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = false;
            logOutButton.Click += logOutButton_Click;
            // 
            // displayUserNameLabel
            // 
            displayUserNameLabel.BackColor = Color.Transparent;
            displayUserNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            displayUserNameLabel.ForeColor = Color.Black;
            displayUserNameLabel.Location = new Point(774, 232);
            displayUserNameLabel.Name = "displayUserNameLabel";
            displayUserNameLabel.Size = new Size(210, 49);
            displayUserNameLabel.TabIndex = 10;
            displayUserNameLabel.Text = UserSession.Instance.Username;
            displayUserNameLabel.Click += displayUserNameLabel_Click;
            // 
            // userNameLabel
            // 
            userNameLabel.BackColor = Color.Transparent;
            userNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameLabel.ForeColor = Color.FromArgb(64, 0, 64);
            userNameLabel.Location = new Point(648, 232);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(137, 49);
            userNameLabel.TabIndex = 9;
            userNameLabel.Text = "Username:";
            // 
            // returnToProjectMenuButton
            // 
            returnToProjectMenuButton.BackColor = Color.FromArgb(235, 232, 240);
            returnToProjectMenuButton.Cursor = Cursors.Hand;
            returnToProjectMenuButton.Location = new Point(886, 120);
            returnToProjectMenuButton.Margin = new Padding(3, 4, 3, 4);
            returnToProjectMenuButton.Name = "returnToProjectMenuButton";
            returnToProjectMenuButton.Size = new Size(98, 29);
            returnToProjectMenuButton.TabIndex = 11;
            returnToProjectMenuButton.Text = "Return";
            returnToProjectMenuButton.UseVisualStyleBackColor = false;
            returnToProjectMenuButton.Click += returnToProjectMenuButton_Click;
            // 
            // topBarControl1
            // 
            topBarControl1.Dock = DockStyle.Top;
            topBarControl1.Location = new Point(0, 0);
            topBarControl1.Name = "topBarControl1";
            topBarControl1.Size = new Size(1008, 60);
            topBarControl1.TabIndex = 12;
            // 
            // sidebar1
            // 
            sidebar1.BackColor = Color.LavenderBlush;
            sidebar1.Dock = DockStyle.Left;
            sidebar1.Location = new Point(0, 60);
            sidebar1.Name = "sidebar1";
            sidebar1.Size = new Size(203, 525);
            sidebar1.TabIndex = 13;
            // 
            // lblHomepage
            // 
            lblHomepage.AutoSize = true;
            lblHomepage.Cursor = Cursors.Hand;
            lblHomepage.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHomepage.ForeColor = SystemColors.WindowFrame;
            lblHomepage.Location = new Point(210, 67);
            lblHomepage.Name = "lblHomepage";
            lblHomepage.Size = new Size(89, 23);
            lblHomepage.TabIndex = 14;
            lblHomepage.Text = "Homepage";
            lblHomepage.Click += lblHomepage_Click;
            lblHomepage.MouseEnter += lblHomepage_MouseEnter;
            lblHomepage.MouseLeave += lblHomepage_MouseLeave;
            // 
            // lblTrennung1
            // 
            lblTrennung1.AutoSize = true;
            lblTrennung1.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            lblTrennung1.ForeColor = SystemColors.WindowFrame;
            lblTrennung1.Location = new Point(296, 67);
            lblTrennung1.Name = "lblTrennung1";
            lblTrennung1.Size = new Size(17, 23);
            lblTrennung1.TabIndex = 15;
            lblTrennung1.Text = "/";
            // 
            // lblProfil
            // 
            lblProfil.AutoSize = true;
            lblProfil.Cursor = Cursors.Hand;
            lblProfil.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            lblProfil.Location = new Point(309, 67);
            lblProfil.Name = "lblProfil";
            lblProfil.Size = new Size(48, 23);
            lblProfil.TabIndex = 16;
            lblProfil.Text = "Profil";
            lblProfil.MouseEnter += lblProfil_MouseEnter;
            lblProfil.MouseLeave += lblProfil_MouseLeave;
            // 
            // deleteInformationFromTables
            // 
            deleteInformationFromTables.BackColor = Color.FromArgb(235, 232, 240);
            deleteInformationFromTables.Cursor = Cursors.Hand;
            deleteInformationFromTables.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteInformationFromTables.Location = new Point(842, 514);
            deleteInformationFromTables.Margin = new Padding(3, 4, 3, 4);
            deleteInformationFromTables.Name = "deleteInformationFromTables";
            deleteInformationFromTables.Size = new Size(154, 58);
            deleteInformationFromTables.TabIndex = 18;
            deleteInformationFromTables.Text = "Datenbankinhalt löschen";
            deleteInformationFromTables.UseVisualStyleBackColor = false;
            deleteInformationFromTables.Click += deleteInformationFromTables_Click;
            // 
            // AccountMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1008, 585);
            Controls.Add(deleteInformationFromTables);
            Controls.Add(lblProfil);
            Controls.Add(lblTrennung1);
            Controls.Add(lblHomepage);
            Controls.Add(sidebar1);
            Controls.Add(topBarControl1);
            Controls.Add(returnToProjectMenuButton);
            Controls.Add(displayUserNameLabel);
            Controls.Add(userNameLabel);
            Controls.Add(logOutButton);
            Controls.Add(displayFirstNameLabel);
            Controls.Add(displayLastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(profileLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AccountMenu";
            Text = "AccountMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label profileLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private Label displayLastNameLabel;
        private Label displayFirstNameLabel;
        private Button logOutButton;
        private Label displayUserNameLabel;
        private Label userNameLabel;
        private Button returnToProjectMenuButton;
        private Topbar.TopBarControl topBarControl1;
        private Sidebar sidebar1;
        private Label lblHomepage;
        private Label lblTrennung1;
        private Label lblProfil;
        private Button deleteInformationFromTables;
    }
}
