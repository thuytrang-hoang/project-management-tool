namespace Programmierprojekt.Datenbank
{
    partial class SubFormProject
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
            projectnameInput = new TextBox();
            memberList = new ListView();
            Users = new ColumnHeader();
            projectNameLabel = new Label();
            groupmemberLabel = new Label();
            groupmemberInputSearch = new TextBox();
            createProjektbutton = new Button();
            addGroupMember = new Button();
            groupNameInput = new TextBox();
            label1 = new Label();
            lblNewPrj = new Label();
            SuspendLayout();
            // 
            // projectnameInput
            // 
            projectnameInput.Location = new Point(131, 112);
            projectnameInput.Margin = new Padding(3, 4, 3, 4);
            projectnameInput.Name = "projectnameInput";
            projectnameInput.Size = new Size(536, 27);
            projectnameInput.TabIndex = 0;
            // 
            // memberList
            // 
            memberList.Columns.AddRange(new ColumnHeader[] { Users });
            memberList.Location = new Point(131, 306);
            memberList.Margin = new Padding(3, 4, 3, 4);
            memberList.Name = "memberList";
            memberList.Size = new Size(412, 131);
            memberList.TabIndex = 1;
            memberList.UseCompatibleStateImageBehavior = false;
            memberList.View = View.Details;
            // 
            // Users
            // 
            Users.Text = "Users";
            Users.Width = 1000;
            // 
            // projectNameLabel
            // 
            projectNameLabel.AutoSize = true;
            projectNameLabel.Location = new Point(127, 89);
            projectNameLabel.Name = "projectNameLabel";
            projectNameLabel.Size = new Size(334, 20);
            projectNameLabel.TabIndex = 2;
            projectNameLabel.Text = "Bitte fügen Sie hier den Namen ihres Projekts ein:";
            // 
            // groupmemberLabel
            // 
            groupmemberLabel.AutoSize = true;
            groupmemberLabel.Location = new Point(127, 239);
            groupmemberLabel.Name = "groupmemberLabel";
            groupmemberLabel.Size = new Size(241, 20);
            groupmemberLabel.TabIndex = 3;
            groupmemberLabel.Text = "Fügen Sie weitere Mitglieder hinzu:";
            // 
            // groupmemberInputSearch
            // 
            groupmemberInputSearch.Location = new Point(131, 262);
            groupmemberInputSearch.Margin = new Padding(3, 4, 3, 4);
            groupmemberInputSearch.Name = "groupmemberInputSearch";
            groupmemberInputSearch.Size = new Size(412, 27);
            groupmemberInputSearch.TabIndex = 4;
            // 
            // createProjektbutton
            // 
            createProjektbutton.Cursor = Cursors.Hand;
            createProjektbutton.Location = new Point(549, 395);
            createProjektbutton.Margin = new Padding(3, 4, 3, 4);
            createProjektbutton.Name = "createProjektbutton";
            createProjektbutton.Size = new Size(118, 42);
            createProjektbutton.TabIndex = 5;
            createProjektbutton.Text = "erstellen";
            createProjektbutton.UseVisualStyleBackColor = true;
            createProjektbutton.Click += createProjektbutton_Click;
            // 
            // addGroupMember
            // 
            addGroupMember.Cursor = Cursors.Hand;
            addGroupMember.Location = new Point(549, 260);
            addGroupMember.Margin = new Padding(3, 4, 3, 4);
            addGroupMember.Name = "addGroupMember";
            addGroupMember.Size = new Size(118, 31);
            addGroupMember.TabIndex = 7;
            addGroupMember.Text = "Add User";
            addGroupMember.UseVisualStyleBackColor = true;
            addGroupMember.Click += addGroupMember_Click;
            // 
            // groupNameInput
            // 
            groupNameInput.Location = new Point(131, 186);
            groupNameInput.Margin = new Padding(3, 4, 3, 4);
            groupNameInput.Name = "groupNameInput";
            groupNameInput.Size = new Size(536, 27);
            groupNameInput.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 163);
            label1.Name = "label1";
            label1.Size = new Size(330, 20);
            label1.TabIndex = 10;
            label1.Text = "Bitte fügen Sie hier den Namen ihrer Gruppe ein:";
            // 
            // lblNewPrj
            // 
            lblNewPrj.AutoSize = true;
            lblNewPrj.Font = new Font("Segoe UI", 16F);
            lblNewPrj.ForeColor = Color.FromArgb(64, 0, 64);
            lblNewPrj.Location = new Point(123, 42);
            lblNewPrj.Name = "lblNewPrj";
            lblNewPrj.Size = new Size(176, 37);
            lblNewPrj.TabIndex = 11;
            lblNewPrj.Text = "neues Projekt";
            // 
            // SubFormProject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNewPrj);
            Controls.Add(label1);
            Controls.Add(groupNameInput);
            Controls.Add(addGroupMember);
            Controls.Add(createProjektbutton);
            Controls.Add(groupmemberInputSearch);
            Controls.Add(groupmemberLabel);
            Controls.Add(projectNameLabel);
            Controls.Add(memberList);
            Controls.Add(projectnameInput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "SubFormProject";
            Text = "SubFormProject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox projectnameInput;
        private ListView memberList;
        private Label projectNameLabel;
        private Label groupmemberLabel;
        private TextBox groupmemberInputSearch;
        private Button createProjektbutton;
        private Button addGroupMember;

        private TextBox groupNameInput;
        private Label label1;
        private ColumnHeader Users;
        private Label lblNewPrj;
    }
}