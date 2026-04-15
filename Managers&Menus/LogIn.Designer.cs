using System;

namespace Programmierprojekt
{
    partial class LogIn
    {

        private readonly string connectionString;



        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            connectTestButton = new Button();
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameInput = new TextBox();
            passwordInput = new TextBox();
            loginButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // connectTestButton
            // 
            connectTestButton.Cursor = Cursors.Hand;
            connectTestButton.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            connectTestButton.Location = new Point(104, 251);
            connectTestButton.Margin = new Padding(3, 4, 3, 4);
            connectTestButton.Name = "connectTestButton";
            connectTestButton.RightToLeft = RightToLeft.Yes;
            connectTestButton.Size = new Size(154, 29);
            connectTestButton.TabIndex = 0;
            connectTestButton.Text = "Serververbindung Test";
            connectTestButton.UseVisualStyleBackColor = true;
            connectTestButton.Click += btnConnect_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(104, 125);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.RightToLeft = RightToLeft.Yes;
            usernameLabel.Size = new Size(75, 20);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(104, 187);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(66, 20);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Passwort";
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(217, 117);
            usernameInput.Margin = new Padding(3, 4, 3, 4);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(311, 27);
            usernameInput.TabIndex = 4;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(217, 180);
            passwordInput.Margin = new Padding(3, 4, 3, 4);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(311, 27);
            passwordInput.TabIndex = 5;
            // 
            // loginButton
            // 
            loginButton.Cursor = Cursors.Hand;
            loginButton.Location = new Point(374, 250);
            loginButton.Margin = new Padding(3, 4, 3, 4);
            loginButton.Name = "loginButton";
            loginButton.RightToLeft = RightToLeft.Yes;
            loginButton.Size = new Size(154, 29);
            loginButton.TabIndex = 6;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 51);
            label1.Name = "label1";
            label1.Size = new Size(72, 31);
            label1.TabIndex = 8;
            label1.Text = "Login";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 376);
            Controls.Add(label1);
            Controls.Add(loginButton);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(connectTestButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "LogIn";
            Text = "LogIn";
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button connectTestButton;  //Verbindung zum Server Test
        private Label usernameLabel; //Username betitlung
        private Label passwordLabel; //Passwort betitlung
        private TextBox usernameInput; //Username InPut
        private TextBox passwordInput; //Passwort InPut
        private Button loginButton; //User && Server User abfage und Connection 
        private Label label1;
    }
}
