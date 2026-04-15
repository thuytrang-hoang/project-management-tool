namespace Programmierprojekt.Managers_Menus.FilesOfCode
{
    partial class UploadedCodeMenu
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
            filesListViewBox = new ListView();
            uploadedFromUser = new ColumnHeader();
            uploadedFile = new ColumnHeader();
            fileSize = new ColumnHeader();
            uploadedDate = new ColumnHeader();
            uploadFileToListViewBox = new Button();
            downloadFileToDesktop = new Button();
            removeFile = new Button();
            topBarControl1 = new Topbar.TopBarControl();
            sidebar1 = new Sidebar();
            title = new Label();
            lblCodeOverview = new Label();
            lblProjekte = new Label();
            lblHomepage = new Label();
            lblTrennung1 = new Label();
            lblTrennung2 = new Label();
            SuspendLayout();
            // 
            // filesListViewBox
            // 
            filesListViewBox.BackColor = Color.White;
            filesListViewBox.Columns.AddRange(new ColumnHeader[] { uploadedFromUser, uploadedFile, fileSize, uploadedDate });
            filesListViewBox.FullRowSelect = true;
            filesListViewBox.Location = new Point(220, 225);
            filesListViewBox.Name = "filesListViewBox";
            filesListViewBox.Size = new Size(776, 328);
            filesListViewBox.TabIndex = 4;
            filesListViewBox.UseCompatibleStateImageBehavior = false;
            filesListViewBox.View = View.Details;
            // 
            // uploadedFromUser
            // 
            uploadedFromUser.Text = "Nutzer";
            uploadedFromUser.Width = 185;
            // 
            // uploadedFile
            // 
            uploadedFile.Text = "Datei";
            uploadedFile.Width = 185;
            // 
            // fileSize
            // 
            fileSize.Text = "Größe";
            fileSize.Width = 185;
            // 
            // uploadedDate
            // 
            uploadedDate.Text = "Hochgeladen";
            uploadedDate.Width = 200;
            // 
            // uploadFileToListViewBox
            // 
            uploadFileToListViewBox.BackColor = Color.FromArgb(235, 232, 240);
            uploadFileToListViewBox.Location = new Point(220, 176);
            uploadFileToListViewBox.Margin = new Padding(3, 4, 3, 4);
            uploadFileToListViewBox.Name = "uploadFileToListViewBox";
            uploadFileToListViewBox.Size = new Size(154, 29);
            uploadFileToListViewBox.TabIndex = 5;
            uploadFileToListViewBox.Text = "Upload";
            uploadFileToListViewBox.UseVisualStyleBackColor = false;
            uploadFileToListViewBox.Click += uploadFileToListViewBox_Click;
            // 
            // downloadFileToDesktop
            // 
            downloadFileToDesktop.BackColor = Color.FromArgb(235, 232, 240);
            downloadFileToDesktop.Location = new Point(398, 176);
            downloadFileToDesktop.Margin = new Padding(3, 4, 3, 4);
            downloadFileToDesktop.Name = "downloadFileToDesktop";
            downloadFileToDesktop.Size = new Size(154, 29);
            downloadFileToDesktop.TabIndex = 6;
            downloadFileToDesktop.Text = "Download";
            downloadFileToDesktop.UseVisualStyleBackColor = false;
            downloadFileToDesktop.Click += downloadFileToDesktop_Click;
            // 
            // removeFile
            // 
            removeFile.BackColor = Color.FromArgb(235, 232, 240);
            removeFile.Location = new Point(842, 176);
            removeFile.Margin = new Padding(3, 4, 3, 4);
            removeFile.Name = "removeFile";
            removeFile.Size = new Size(154, 29);
            removeFile.TabIndex = 7;
            removeFile.Text = "Remove";
            removeFile.UseVisualStyleBackColor = false;
            removeFile.Click += removeFile_Click;
            // 
            // topBarControl1
            // 
            topBarControl1.Dock = DockStyle.Top;
            topBarControl1.Location = new Point(0, 0);
            topBarControl1.Name = "topBarControl1";
            topBarControl1.Size = new Size(1008, 60);
            topBarControl1.TabIndex = 8;
            // 
            // sidebar1
            // 
            sidebar1.BackColor = Color.LavenderBlush;
            sidebar1.Dock = DockStyle.Left;
            sidebar1.Location = new Point(0, 60);
            sidebar1.Name = "sidebar1";
            sidebar1.Size = new Size(204, 525);
            sidebar1.TabIndex = 9;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Segoe UI", 20F);
            title.ForeColor = Color.FromArgb(64, 0, 64);
            title.Location = new Point(220, 117);
            title.Name = "title";
            title.Size = new Size(255, 46);
            title.TabIndex = 10;
            title.Text = "Code-Übersicht";
            // 
            // lblCodeOverview
            // 
            lblCodeOverview.AutoSize = true;
            lblCodeOverview.Cursor = Cursors.Hand;
            lblCodeOverview.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblCodeOverview.ForeColor = SystemColors.ControlText;
            lblCodeOverview.Location = new Point(387, 63);
            lblCodeOverview.Name = "lblCodeOverview";
            lblCodeOverview.Size = new Size(122, 23);
            lblCodeOverview.TabIndex = 24;
            lblCodeOverview.Text = "Code-Übersicht";
            lblCodeOverview.MouseEnter += lblCodeOverview_MouseEnter;
            lblCodeOverview.MouseLeave += lblCodeOverview_MouseLeave;
            // 
            // lblProjekte
            // 
            lblProjekte.AutoSize = true;
            lblProjekte.BackColor = Color.Transparent;
            lblProjekte.Cursor = Cursors.Hand;
            lblProjekte.FlatStyle = FlatStyle.Flat;
            lblProjekte.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProjekte.ForeColor = SystemColors.WindowFrame;
            lblProjekte.Location = new Point(308, 63);
            lblProjekte.Name = "lblProjekte";
            lblProjekte.Size = new Size(69, 23);
            lblProjekte.TabIndex = 22;
            lblProjekte.Text = "Projekte";
            lblProjekte.Click += lblProjekte_Click;
            lblProjekte.MouseEnter += lblProjekte_MouseEnter;
            lblProjekte.MouseLeave += lblProjekte_MouseLeave;
            // 
            // lblHomepage
            // 
            lblHomepage.AutoSize = true;
            lblHomepage.BackColor = Color.Transparent;
            lblHomepage.Cursor = Cursors.Hand;
            lblHomepage.FlatStyle = FlatStyle.Flat;
            lblHomepage.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHomepage.ForeColor = SystemColors.WindowFrame;
            lblHomepage.Location = new Point(210, 63);
            lblHomepage.Name = "lblHomepage";
            lblHomepage.Size = new Size(89, 23);
            lblHomepage.TabIndex = 20;
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
            lblTrennung1.Location = new Point(296, 63);
            lblTrennung1.Name = "lblTrennung1";
            lblTrennung1.Size = new Size(17, 23);
            lblTrennung1.TabIndex = 21;
            lblTrennung1.Text = "/";
            // 
            // lblTrennung2
            // 
            lblTrennung2.AutoSize = true;
            lblTrennung2.BackColor = Color.Transparent;
            lblTrennung2.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTrennung2.ForeColor = SystemColors.WindowFrame;
            lblTrennung2.Location = new Point(374, 63);
            lblTrennung2.Name = "lblTrennung2";
            lblTrennung2.Size = new Size(17, 23);
            lblTrennung2.TabIndex = 23;
            lblTrennung2.Text = "/";
            // 
            // UploadedCodeMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1008, 585);
            Controls.Add(lblCodeOverview);
            Controls.Add(lblProjekte);
            Controls.Add(lblHomepage);
            Controls.Add(lblTrennung1);
            Controls.Add(lblTrennung2);
            Controls.Add(title);
            Controls.Add(sidebar1);
            Controls.Add(topBarControl1);
            Controls.Add(removeFile);
            Controls.Add(downloadFileToDesktop);
            Controls.Add(uploadFileToListViewBox);
            Controls.Add(filesListViewBox);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "UploadedCodeMenu";
            Text = "UploadedCodeMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView filesListViewBox;
        private ColumnHeader uploadedFromUser;
        private ColumnHeader uploadedFile;
        private ColumnHeader fileSize;
        private ColumnHeader uploadedDate;
        private Button uploadFileToListViewBox;
        private Button downloadFileToDesktop;
        private Button removeFile;
        private Topbar.TopBarControl topBarControl1;
        private Sidebar sidebar1;
        private Label title;
        private Label lblCodeOverview;
        private Label lblProjekte;
        private Label lblHomepage;
        private Label lblTrennung1;
        private Label lblTrennung2;
    }
}