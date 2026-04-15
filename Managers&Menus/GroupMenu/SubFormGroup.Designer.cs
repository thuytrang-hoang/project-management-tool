namespace Programmierprojekt.Datenbank
{
    partial class SubFormGroup
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
            addGroupMemberButton = new Button();
            removeGroupMemberButton = new Button();
            groupName = new Label();
            groupMemberListViewBox = new ListView();
            groupMemberNames = new ColumnHeader();
            projectListViewBox = new ListView();
            projectNames = new ColumnHeader();
            createdDateProject = new ColumnHeader();
            leaveGroupButton = new Button();
            lblGruppe = new Label();
            topBarControl1 = new Topbar.TopBarControl();
            sidebar1 = new Sidebar();
            lblHomepage = new Label();
            lblTrennung1 = new Label();
            lblProjekte = new Label();
            lblTrennung2 = new Label();
            lblGroup = new Label();
            SuspendLayout();
            // 
            // addGroupMemberButton
            // 
            addGroupMemberButton.BackColor = Color.FromArgb(235, 232, 240);
            addGroupMemberButton.Cursor = Cursors.Hand;
            addGroupMemberButton.Location = new Point(249, 175);
            addGroupMemberButton.Name = "addGroupMemberButton";
            addGroupMemberButton.Size = new Size(235, 29);
            addGroupMemberButton.TabIndex = 4;
            addGroupMemberButton.Text = "Gruppenmitglied hinzufügen";
            addGroupMemberButton.UseVisualStyleBackColor = false;
            addGroupMemberButton.Click += addGroupMemberButton_Click;
            // 
            // removeGroupMemberButton
            // 
            removeGroupMemberButton.BackColor = Color.FromArgb(235, 232, 240);
            removeGroupMemberButton.Cursor = Cursors.Hand;
            removeGroupMemberButton.Location = new Point(492, 175);
            removeGroupMemberButton.Name = "removeGroupMemberButton";
            removeGroupMemberButton.Size = new Size(226, 29);
            removeGroupMemberButton.TabIndex = 5;
            removeGroupMemberButton.Text = "Gruppenmitglied entfernen";
            removeGroupMemberButton.UseVisualStyleBackColor = false;
            removeGroupMemberButton.Click += removeGroupMemberButton_Click;
            // 
            // groupName
            // 
            groupName.AutoSize = true;
            groupName.BackColor = Color.Transparent;
            groupName.Font = new Font("Segoe UI", 20F);
            groupName.ForeColor = Color.FromArgb(64, 0, 64);
            groupName.Location = new Point(248, 103);
            groupName.Name = "groupName";
            groupName.Size = new Size(0, 46);
            groupName.TabIndex = 6;
            // 
            // groupMemberListViewBox
            // 
            groupMemberListViewBox.Columns.AddRange(new ColumnHeader[] { groupMemberNames });
            groupMemberListViewBox.FullRowSelect = true;
            groupMemberListViewBox.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            groupMemberListViewBox.Location = new Point(249, 220);
            groupMemberListViewBox.Name = "groupMemberListViewBox";
            groupMemberListViewBox.Size = new Size(722, 201);
            groupMemberListViewBox.TabIndex = 7;
            groupMemberListViewBox.UseCompatibleStateImageBehavior = false;
            groupMemberListViewBox.View = View.Details;
            // 
            // groupMemberNames
            // 
            groupMemberNames.Text = "Gruppenmitglieder";
            groupMemberNames.Width = 400;
            // 
            // projectListViewBox
            // 
            projectListViewBox.BackColor = Color.White;
            projectListViewBox.Columns.AddRange(new ColumnHeader[] { projectNames, createdDateProject });
            projectListViewBox.FullRowSelect = true;
            projectListViewBox.Location = new Point(249, 427);
            projectListViewBox.Name = "projectListViewBox";
            projectListViewBox.Size = new Size(722, 111);
            projectListViewBox.TabIndex = 8;
            projectListViewBox.UseCompatibleStateImageBehavior = false;
            projectListViewBox.View = View.Details;
            // 
            // projectNames
            // 
            projectNames.Text = "Projekte";
            projectNames.Width = 300;
            // 
            // createdDateProject
            // 
            createdDateProject.Text = "Erstellungsdatum";
            createdDateProject.Width = 300;
            // 
            // leaveGroupButton
            // 
            leaveGroupButton.BackColor = Color.FromArgb(235, 232, 240);
            leaveGroupButton.Cursor = Cursors.Hand;
            leaveGroupButton.Location = new Point(736, 175);
            leaveGroupButton.Margin = new Padding(3, 4, 3, 4);
            leaveGroupButton.Name = "leaveGroupButton";
            leaveGroupButton.Size = new Size(105, 29);
            leaveGroupButton.TabIndex = 10;
            leaveGroupButton.Text = "Leave Group";
            leaveGroupButton.UseVisualStyleBackColor = false;
            leaveGroupButton.Click += leaveGroupButton_Click;
            // 
            // lblGruppe
            // 
            lblGruppe.AutoSize = true;
            lblGruppe.Font = new Font("Segoe UI", 20F);
            lblGruppe.ForeColor = Color.FromArgb(64, 0, 64);
            lblGruppe.Location = new Point(245, 109);
            lblGruppe.Name = "lblGruppe";
            lblGruppe.Size = new Size(132, 46);
            lblGruppe.TabIndex = 11;
            lblGruppe.Text = "Gruppe";
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
            sidebar1.Size = new Size(204, 525);
            sidebar1.TabIndex = 13;
            // 
            // lblHomepage
            // 
            lblHomepage.AutoSize = true;
            lblHomepage.BackColor = Color.Transparent;
            lblHomepage.Cursor = Cursors.Hand;
            lblHomepage.FlatStyle = FlatStyle.Flat;
            lblHomepage.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            lblHomepage.ForeColor = SystemColors.WindowFrame;
            lblHomepage.Location = new Point(210, 66);
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
            lblTrennung1.Location = new Point(296, 66);
            lblTrennung1.Name = "lblTrennung1";
            lblTrennung1.Size = new Size(17, 23);
            lblTrennung1.TabIndex = 15;
            lblTrennung1.Text = "/";
            // 
            // lblProjekte
            // 
            lblProjekte.AutoSize = true;
            lblProjekte.Cursor = Cursors.Hand;
            lblProjekte.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            lblProjekte.ForeColor = SystemColors.WindowFrame;
            lblProjekte.Location = new Point(308, 66);
            lblProjekte.Name = "lblProjekte";
            lblProjekte.Size = new Size(69, 23);
            lblProjekte.TabIndex = 16;
            lblProjekte.Text = "Projekte";
            lblProjekte.Click += lblProjekte_Click;
            lblProjekte.MouseEnter += lblProjekte_MouseEnter;
            lblProjekte.MouseLeave += lblProjekte_MouseLeave;
            // 
            // lblTrennung2
            // 
            lblTrennung2.AutoSize = true;
            lblTrennung2.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            lblTrennung2.ForeColor = SystemColors.WindowFrame;
            lblTrennung2.Location = new Point(374, 66);
            lblTrennung2.Name = "lblTrennung2";
            lblTrennung2.Size = new Size(17, 23);
            lblTrennung2.TabIndex = 17;
            lblTrennung2.Text = "/";
            // 
            // lblGroup
            // 
            lblGroup.AutoSize = true;
            lblGroup.Cursor = Cursors.Hand;
            lblGroup.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            lblGroup.Location = new Point(387, 66);
            lblGroup.Name = "lblGroup";
            lblGroup.Size = new Size(63, 23);
            lblGroup.TabIndex = 18;
            lblGroup.Text = "Gruppe";
            lblGroup.MouseEnter += lblGroup_MouseEnter;
            lblGroup.MouseLeave += lblGroup_MouseLeave;
            // 
            // SubFormGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 585);
            Controls.Add(lblGroup);
            Controls.Add(lblTrennung2);
            Controls.Add(lblProjekte);
            Controls.Add(lblTrennung1);
            Controls.Add(lblHomepage);
            Controls.Add(sidebar1);
            Controls.Add(topBarControl1);
            Controls.Add(lblGruppe);
            Controls.Add(leaveGroupButton);
            Controls.Add(projectListViewBox);
            Controls.Add(groupMemberListViewBox);
            Controls.Add(groupName);
            Controls.Add(removeGroupMemberButton);
            Controls.Add(addGroupMemberButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SubFormGroup";
            Text = "GruppeBearbeitenForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addGroupMemberButton;
        private Button removeGroupMemberButton;
        private Label groupName;
        private ListView groupMemberListViewBox;
        private ListView projectListViewBox;
        private ColumnHeader groupMemberNames;
        private ColumnHeader projectNames;
        private ColumnHeader createdDateProject;
        private Button leaveGroupButton;
        private Label lblGruppe;
        private Topbar.TopBarControl topBarControl1;
        private Sidebar sidebar1;
        private Label lblHomepage;
        private Label lblTrennung1;
        private Label lblProjekte;
        private Label lblTrennung2;
        private Label lblGroup;
    }
}