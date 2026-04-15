namespace Programmierprojekt.Datenbank
{
    partial class GroupMenu
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
            title = new Label();
            groupListViewBox = new ListView();
            Gruppen = new ColumnHeader();
            Gruppenname = new ColumnHeader();
            Änderungsdatum = new ColumnHeader();
            Erstellungsdatum = new ColumnHeader();
            returnProjectMenuButton = new Button();
            topBarControl1 = new Topbar.TopBarControl();
            pre_Sidebar1 = new Sidebars.pre_Sidebar();
            lblProjekte = new Label();
            lblTrennung1 = new Label();
            lblHomepage = new Label();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Segoe UI", 20F);
            title.ForeColor = Color.FromArgb(64, 0, 64);
            title.Location = new Point(220, 117);
            title.Name = "title";
            title.Size = new Size(247, 46);
            title.TabIndex = 2;
            title.Text = "Deine Gruppen";
            // 
            // groupListViewBox
            // 
            groupListViewBox.BackColor = Color.White;
            groupListViewBox.Columns.AddRange(new ColumnHeader[] { Gruppen });
            groupListViewBox.FullRowSelect = true;
            groupListViewBox.Location = new Point(220, 225);
            groupListViewBox.Name = "groupListViewBox";
            groupListViewBox.Size = new Size(776, 328);
            groupListViewBox.TabIndex = 3;
            groupListViewBox.UseCompatibleStateImageBehavior = false;
            groupListViewBox.View = View.Details;
            groupListViewBox.ItemActivate += groupListViewBox_ItemActivate;
            // 
            // Gruppen
            // 
            Gruppen.Text = "Gruppen";
            Gruppen.Width = 230;
            // 
            // returnProjectMenuButton
            // 
            returnProjectMenuButton.BackColor = Color.FromArgb(235, 232, 240);
            returnProjectMenuButton.Location = new Point(910, 187);
            returnProjectMenuButton.Margin = new Padding(3, 4, 3, 4);
            returnProjectMenuButton.Name = "returnProjectMenuButton";
            returnProjectMenuButton.Size = new Size(86, 31);
            returnProjectMenuButton.TabIndex = 4;
            returnProjectMenuButton.Text = "Return";
            returnProjectMenuButton.UseVisualStyleBackColor = false;
            returnProjectMenuButton.Click += returnProjectMenuButton_Click;
            // 
            // topBarControl1
            // 
            topBarControl1.Dock = DockStyle.Top;
            topBarControl1.Location = new Point(0, 0);
            topBarControl1.Name = "topBarControl1";
            topBarControl1.Size = new Size(1008, 60);
            topBarControl1.TabIndex = 5;
            // 
            // pre_Sidebar1
            // 
            pre_Sidebar1.Dock = DockStyle.Left;
            pre_Sidebar1.Location = new Point(0, 60);
            pre_Sidebar1.Name = "pre_Sidebar1";
            pre_Sidebar1.Size = new Size(204, 525);
            pre_Sidebar1.TabIndex = 6;
            // 
            // lblProjekte
            // 
            lblProjekte.AutoSize = true;
            lblProjekte.Cursor = Cursors.Hand;
            lblProjekte.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            lblProjekte.Location = new Point(308, 63);
            lblProjekte.Name = "lblProjekte";
            lblProjekte.Size = new Size(69, 23);
            lblProjekte.TabIndex = 15;
            lblProjekte.Text = "Projekte";
            lblProjekte.MouseEnter += lblProjekte_MouseEnter;
            lblProjekte.MouseLeave += lblProjekte_MouseLeave;
            // 
            // lblTrennung1
            // 
            lblTrennung1.AutoSize = true;
            lblTrennung1.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            lblTrennung1.ForeColor = SystemColors.WindowFrame;
            lblTrennung1.Location = new Point(296, 63);
            lblTrennung1.Name = "lblTrennung1";
            lblTrennung1.Size = new Size(17, 23);
            lblTrennung1.TabIndex = 14;
            lblTrennung1.Text = "/";
            // 
            // lblHomepage
            // 
            lblHomepage.AutoSize = true;
            lblHomepage.Cursor = Cursors.Hand;
            lblHomepage.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            lblHomepage.ForeColor = SystemColors.WindowFrame;
            lblHomepage.Location = new Point(210, 63);
            lblHomepage.Name = "lblHomepage";
            lblHomepage.Size = new Size(89, 23);
            lblHomepage.TabIndex = 13;
            lblHomepage.Text = "Homepage";
            lblHomepage.Click += lblHomepage_Click;
            lblHomepage.MouseEnter += lblHomepage_MouseEnter;
            lblHomepage.MouseLeave += lblHomepage_MouseLeave;
            // 
            // GroupMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 585);
            Controls.Add(lblProjekte);
            Controls.Add(lblTrennung1);
            Controls.Add(lblHomepage);
            Controls.Add(pre_Sidebar1);
            Controls.Add(topBarControl1);
            Controls.Add(returnProjectMenuButton);
            Controls.Add(groupListViewBox);
            Controls.Add(title);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "GroupMenu";
            Text = "DeineGruppeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label title;
        private ListView groupListViewBox;
        private ColumnHeader Gruppenname;
        private ColumnHeader Änderungsdatum;
        private ColumnHeader Erstellungsdatum;
        private Button returnProjectMenuButton;
        private ColumnHeader Gruppen;
        private Topbar.TopBarControl topBarControl1;
        private Sidebars.pre_Sidebar pre_Sidebar1;
        private Label lblProjekte;
        private Label lblTrennung1;
        private Label lblHomepage;
    }
}