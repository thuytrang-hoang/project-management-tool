namespace Programmierprojekt
{
    partial class TimeTableForm
    {
        private void InitializeComponent()
        {
            btnCreateToDo = new Button();
            lvTasks = new ListView();
            colName = new ColumnHeader();
            colBeschreibung = new ColumnHeader();
            colFrist = new ColumnHeader();
            colVerantwortlicher = new ColumnHeader();
            lblHeadline = new Label();
            sidebar = new Sidebar();
            topBar = new Topbar.TopBarControl();
            lblHomepage = new Label();
            lblTrennung1 = new Label();
            lblProjekte = new Label();
            lblTrennung2 = new Label();
            lblZeitplan = new Label();
            SuspendLayout();
            // 
            // btnCreateToDo
            // 
            btnCreateToDo.BackColor = Color.FromArgb(235, 232, 240);
            btnCreateToDo.Cursor = Cursors.Hand;
            btnCreateToDo.Location = new Point(220, 176);
            btnCreateToDo.Name = "btnCreateToDo";
            btnCreateToDo.Size = new Size(154, 29);
            btnCreateToDo.TabIndex = 2;
            btnCreateToDo.TabStop = false;
            btnCreateToDo.Text = "+ To-Do erstellen";
            btnCreateToDo.UseVisualStyleBackColor = false;
            btnCreateToDo.Click += btnCreateToDo_Click;
            // 
            // lvTasks
            // 
            lvTasks.CheckBoxes = true;
            lvTasks.Columns.AddRange(new ColumnHeader[] { colName, colBeschreibung, colFrist, colVerantwortlicher });
            lvTasks.Location = new Point(220, 225);
            lvTasks.Name = "lvTasks";
            lvTasks.Size = new Size(776, 328);
            lvTasks.TabIndex = 3;
            lvTasks.UseCompatibleStateImageBehavior = false;
            lvTasks.View = View.Details;
            lvTasks.ColumnClick += lvTasks_ColumnClick;
            lvTasks.ItemCheck += lvTasks_ItemCheck;
            // 
            // colName
            // 
            colName.Text = "             Name";
            colName.Width = 160;
            // 
            // colBeschreibung
            // 
            colBeschreibung.Text = "Beschreibung";
            colBeschreibung.TextAlign = HorizontalAlignment.Center;
            colBeschreibung.Width = 260;
            // 
            // colFrist
            // 
            colFrist.Text = "Frist";
            colFrist.TextAlign = HorizontalAlignment.Center;
            colFrist.Width = 160;
            // 
            // colVerantwortlicher
            // 
            colVerantwortlicher.Text = "Mitglied";
            colVerantwortlicher.TextAlign = HorizontalAlignment.Center;
            colVerantwortlicher.Width = 160;
            // 
            // lblHeadline
            // 
            lblHeadline.AutoSize = true;
            lblHeadline.Font = new Font("Segoe UI", 20F);
            lblHeadline.ForeColor = Color.FromArgb(64, 0, 64);
            lblHeadline.Location = new Point(220, 117);
            lblHeadline.Name = "lblHeadline";
            lblHeadline.Size = new Size(379, 46);
            lblHeadline.TabIndex = 4;
            lblHeadline.Text = "Zeitplan- und Einteilung";
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.LavenderBlush;
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 60);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(204, 525);
            sidebar.TabIndex = 1;
            // 
            // topBar
            // 
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(0, 0);
            topBar.Name = "topBar";
            topBar.Size = new Size(1008, 60);
            topBar.TabIndex = 0;
            // 
            // lblHomepage
            // 
            lblHomepage.AutoSize = true;
            lblHomepage.BackColor = Color.Transparent;
            lblHomepage.Cursor = Cursors.Hand;
            lblHomepage.FlatStyle = FlatStyle.Flat;
            lblHomepage.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHomepage.ForeColor = SystemColors.WindowFrame;
            lblHomepage.Location = new Point(210, 66);
            lblHomepage.Name = "lblHomepage";
            lblHomepage.Size = new Size(89, 23);
            lblHomepage.TabIndex = 5;
            lblHomepage.Text = "Homepage";
            lblHomepage.Click += lblHomepage_Click;
            lblHomepage.MouseEnter += lblHomepage_MouseEnter;
            lblHomepage.MouseLeave += lblHomepage_MouseLeave;
            // 
            // lblTrennung1
            // 
            lblTrennung1.AutoSize = true;
            lblTrennung1.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTrennung1.ForeColor = SystemColors.WindowFrame;
            lblTrennung1.Location = new Point(296, 66);
            lblTrennung1.Name = "lblTrennung1";
            lblTrennung1.Size = new Size(17, 23);
            lblTrennung1.TabIndex = 6;
            lblTrennung1.Text = "/";
            // 
            // lblProjekte
            // 
            lblProjekte.AutoSize = true;
            lblProjekte.BackColor = Color.Transparent;
            lblProjekte.Cursor = Cursors.Hand;
            lblProjekte.FlatStyle = FlatStyle.Flat;
            lblProjekte.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProjekte.ForeColor = SystemColors.WindowFrame;
            lblProjekte.Location = new Point(308, 66);
            lblProjekte.Name = "lblProjekte";
            lblProjekte.Size = new Size(69, 23);
            lblProjekte.TabIndex = 7;
            lblProjekte.Text = "Projekte";
            lblProjekte.Click += lblProjekte_Click;
            lblProjekte.MouseEnter += lblProjekte_MouseEnter;
            lblProjekte.MouseLeave += lblProjekte_MouseLeave;
            // 
            // lblTrennung2
            // 
            lblTrennung2.AutoSize = true;
            lblTrennung2.BackColor = Color.Transparent;
            lblTrennung2.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTrennung2.ForeColor = SystemColors.WindowFrame;
            lblTrennung2.Location = new Point(374, 66);
            lblTrennung2.Name = "lblTrennung2";
            lblTrennung2.Size = new Size(17, 23);
            lblTrennung2.TabIndex = 8;
            lblTrennung2.Text = "/";
            // 
            // lblZeitplan
            // 
            lblZeitplan.AutoSize = true;
            lblZeitplan.Cursor = Cursors.Hand;
            lblZeitplan.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblZeitplan.ForeColor = SystemColors.ControlText;
            lblZeitplan.Location = new Point(387, 66);
            lblZeitplan.Name = "lblZeitplan";
            lblZeitplan.Size = new Size(187, 23);
            lblZeitplan.TabIndex = 9;
            lblZeitplan.Text = "Zeitplan und -Einteilung";
            lblZeitplan.MouseEnter += lblZeitplan_MouseEnter;
            lblZeitplan.MouseLeave += lblZeitplan_MouseLeave;
            // 
            // TimeTableForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1008, 585);
            Controls.Add(lblZeitplan);
            Controls.Add(lblProjekte);
            Controls.Add(lblHomepage);
            Controls.Add(lblHeadline);
            Controls.Add(lvTasks);
            Controls.Add(btnCreateToDo);
            Controls.Add(sidebar);
            Controls.Add(topBar);
            Controls.Add(lblTrennung1);
            Controls.Add(lblTrennung2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TimeTableForm";
            Text = "TimeTableForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnCreateToDo;
        private ListView lvTasks;
        private ColumnHeader colName;
        private ColumnHeader colBeschreibung;
        private ColumnHeader colFrist;
        private ColumnHeader colVerantwortlicher;
        private Label lblHeadline;
        private Sidebar sidebar; // Sidebar-Deklaration
        private Topbar.TopBarControl topBar; // Topbar-Deklaration
        private Label lblHomepage;
        private Label lblTrennung1;
        private Label lblProjekte;
        private Label lblTrennung2;
        private Label lblZeitplan;
    }
}
