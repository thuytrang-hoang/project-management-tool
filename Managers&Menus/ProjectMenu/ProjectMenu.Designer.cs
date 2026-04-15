namespace Programmierprojekt.Datenbank
{
    partial class ProjectMenu
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
            addProjectButton = new Button();
            projectListViewBox = new ListView();
            Projekt = new ColumnHeader();
            Änderungsdatum = new ColumnHeader();
            Erstellungsdatum = new ColumnHeader();
            groupName = new Label();
            topBarControl1 = new Topbar.TopBarControl();
            pre_Sidebar1 = new Sidebars.pre_Sidebar();
            lblHomepage = new Label();
            lblTrennung1 = new Label();
            lblProjekte = new Label();
            SuspendLayout();
            // 
            // addProjectButton
            // 
            addProjectButton.BackColor = Color.FromArgb(235, 232, 240);
            addProjectButton.Cursor = Cursors.Hand;
            addProjectButton.Location = new Point(220, 176);
            addProjectButton.Margin = new Padding(3, 4, 3, 4);
            addProjectButton.Name = "addProjectButton";
            addProjectButton.Size = new Size(154, 29);
            addProjectButton.TabIndex = 0;
            addProjectButton.Text = "Add Project";
            addProjectButton.UseVisualStyleBackColor = false;
            addProjectButton.Click += addProjectButton_Click;
            // 
            // projectListViewBox
            // 
            projectListViewBox.Columns.AddRange(new ColumnHeader[] { Projekt, Änderungsdatum, Erstellungsdatum });
            projectListViewBox.Location = new Point(220, 225);
            projectListViewBox.Margin = new Padding(3, 4, 3, 4);
            projectListViewBox.Name = "projectListViewBox";
            projectListViewBox.Size = new Size(776, 328);
            projectListViewBox.TabIndex = 1;
            projectListViewBox.UseCompatibleStateImageBehavior = false;
            projectListViewBox.View = View.Details;
            projectListViewBox.ItemActivate += projektListe_ItemActivate;
            // 
            // Projekt
            // 
            Projekt.Text = "Projekt";
            Projekt.Width = 200;
            // 
            // Änderungsdatum
            // 
            Änderungsdatum.Text = "Änderungsdatum";
            Änderungsdatum.Width = 200;
            // 
            // Erstellungsdatum
            // 
            Erstellungsdatum.Text = "Erstellungsdatum";
            Erstellungsdatum.Width = 200;
            // 
            // groupName
            // 
            groupName.AutoSize = true;
            groupName.BackColor = Color.Transparent;
            groupName.Font = new Font("Segoe UI", 20F);
            groupName.ForeColor = Color.FromArgb(64, 0, 64);
            groupName.Location = new Point(220, 117);
            groupName.Name = "groupName";
            groupName.Size = new Size(144, 46);
            groupName.TabIndex = 7;
            groupName.Text = "Projekte";
            // 
            // topBarControl1
            // 
            topBarControl1.Dock = DockStyle.Top;
            topBarControl1.Location = new Point(0, 0);
            topBarControl1.Name = "topBarControl1";
            topBarControl1.Size = new Size(1008, 60);
            topBarControl1.TabIndex = 8;
            // 
            // pre_Sidebar1
            // 
            pre_Sidebar1.Dock = DockStyle.Left;
            pre_Sidebar1.Location = new Point(0, 60);
            pre_Sidebar1.Name = "pre_Sidebar1";
            pre_Sidebar1.Size = new Size(204, 525);
            pre_Sidebar1.TabIndex = 9;
            // 
            // lblHomepage
            // 
            lblHomepage.AutoSize = true;
            lblHomepage.Cursor = Cursors.Hand;
            lblHomepage.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            lblHomepage.ForeColor = SystemColors.WindowFrame;
            lblHomepage.Location = new Point(210, 66);
            lblHomepage.Name = "lblHomepage";
            lblHomepage.Size = new Size(89, 23);
            lblHomepage.TabIndex = 10;
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
            lblTrennung1.TabIndex = 11;
            lblTrennung1.Text = "/";
            // 
            // lblProjekte
            // 
            lblProjekte.AutoSize = true;
            lblProjekte.Cursor = Cursors.Hand;
            lblProjekte.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            lblProjekte.Location = new Point(308, 66);
            lblProjekte.Name = "lblProjekte";
            lblProjekte.Size = new Size(69, 23);
            lblProjekte.TabIndex = 12;
            lblProjekte.Text = "Projekte";
            lblProjekte.MouseEnter += lblProjekte_MouseEnter;
            lblProjekte.MouseLeave += lblProjekte_MouseLeave;
            // 
            // ProjectMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1008, 585);
            Controls.Add(lblProjekte);
            Controls.Add(lblTrennung1);
            Controls.Add(lblHomepage);
            Controls.Add(pre_Sidebar1);
            Controls.Add(topBarControl1);
            Controls.Add(groupName);
            Controls.Add(addProjectButton);
            Controls.Add(projectListViewBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ProjectMenu";
            Text = "ProjektMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView projectListViewBox;
        private Button addProjectButton;
        private Button sortButton;
        private ColumnHeader Projekt;
        private ColumnHeader Änderungsdatum;
        private ColumnHeader Erstellungsdatum;
        private Label groupName;
        private Topbar.TopBarControl topBarControl1;
        private Sidebars.pre_Sidebar pre_Sidebar1;
        private Label lblHomepage;
        private Label lblTrennung1;
        private Label lblProjekte;
    }
}