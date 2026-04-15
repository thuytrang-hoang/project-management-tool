using Programmierprojekt.Datenbank;

namespace Programmierprojekt.Übersicht
{
    partial class StepsOverviewForm
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
            nameLabel = new Label();
            label1 = new Label();
            topBarControl1 = new Topbar.TopBarControl();
            sidebar1 = new Sidebar();
            lblThema = new Label();
            lblTechnischeSpez = new Label();
            lblZeitplan = new Label();
            lblCode = new Label();
            lblHomepage = new Label();
            lblTrennung1 = new Label();
            lblProjekte = new Label();
            lblTrennung2 = new Label();
            lblDeineSchritte = new Label();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.Font = new Font("Segoe UI", 20F);
            nameLabel.ForeColor = Color.FromArgb(64, 0, 64);
            nameLabel.Location = new Point(239, 107);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(0, 46);
            nameLabel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.FromArgb(64, 0, 64);
            label1.Location = new Point(239, 125);
            label1.Name = "label1";
            label1.Size = new Size(162, 46);
            label1.TabIndex = 9;
            label1.Text = "Übersicht";
            // 
            // topBarControl1
            // 
            topBarControl1.Dock = DockStyle.Top;
            topBarControl1.Location = new Point(0, 0);
            topBarControl1.Name = "topBarControl1";
            topBarControl1.Size = new Size(1008, 60);
            topBarControl1.TabIndex = 10;
            // 
            // sidebar1
            // 
            sidebar1.BackColor = Color.LavenderBlush;
            sidebar1.Dock = DockStyle.Left;
            sidebar1.Location = new Point(0, 60);
            sidebar1.Name = "sidebar1";
            sidebar1.Size = new Size(204, 525);
            sidebar1.TabIndex = 11;
            // 
            // lblThema
            // 
            lblThema.AutoSize = true;
            lblThema.BackColor = Color.FromArgb(77, 104, 149);
            lblThema.Cursor = Cursors.Hand;
            lblThema.FlatStyle = FlatStyle.Flat;
            lblThema.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblThema.ForeColor = SystemColors.Window;
            lblThema.Location = new Point(280, 307);
            lblThema.Name = "lblThema";
            lblThema.Size = new Size(124, 75);
            lblThema.TabIndex = 13;
            lblThema.Text = "1. Thema\r\nFindung und \r\nBeprechung\r\n";
            lblThema.TextAlign = ContentAlignment.MiddleCenter;
            lblThema.Click += lblThema_Click;
            lblThema.MouseEnter += lblThema_MouseEnter;
            lblThema.MouseLeave += lblThema_MouseLeave;
            // 
            // lblTechnischeSpez
            // 
            lblTechnischeSpez.AutoSize = true;
            lblTechnischeSpez.BackColor = Color.FromArgb(109, 136, 179);
            lblTechnischeSpez.Cursor = Cursors.Hand;
            lblTechnischeSpez.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTechnischeSpez.ForeColor = SystemColors.Window;
            lblTechnischeSpez.Location = new Point(484, 320);
            lblTechnischeSpez.Name = "lblTechnischeSpez";
            lblTechnischeSpez.Size = new Size(125, 50);
            lblTechnischeSpez.TabIndex = 14;
            lblTechnischeSpez.Text = "2. Technische\r\nSpezifikation\r\n";
            lblTechnischeSpez.TextAlign = ContentAlignment.MiddleCenter;
            lblTechnischeSpez.Click += lblTechnischeSpez_Click;
            lblTechnischeSpez.MouseEnter += lblTechnischeSpez_MouseEnter;
            lblTechnischeSpez.MouseLeave += lblTechnischeSpez_MouseLeave;
            // 
            // lblZeitplan
            // 
            lblZeitplan.AutoSize = true;
            lblZeitplan.BackColor = Color.FromArgb(154, 172, 202);
            lblZeitplan.Cursor = Cursors.Hand;
            lblZeitplan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblZeitplan.ForeColor = SystemColors.Window;
            lblZeitplan.Location = new Point(641, 320);
            lblZeitplan.Name = "lblZeitplan";
            lblZeitplan.Size = new Size(140, 50);
            lblZeitplan.TabIndex = 15;
            lblZeitplan.Text = "3. Zeitplan und\r\n-einteilung";
            lblZeitplan.TextAlign = ContentAlignment.MiddleCenter;
            lblZeitplan.Click += lblZeitplan_Click;
            lblZeitplan.MouseEnter += lblZeitplan_MouseEnter;
            lblZeitplan.MouseLeave += lblZeitplan_MouseLeave;
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.BackColor = Color.FromArgb(190, 201, 220);
            lblCode.Cursor = Cursors.Hand;
            lblCode.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCode.ForeColor = SystemColors.Window;
            lblCode.Location = new Point(831, 320);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(93, 50);
            lblCode.TabIndex = 16;
            lblCode.Text = "4. Code-\r\nÜbersicht";
            lblCode.TextAlign = ContentAlignment.MiddleCenter;
            lblCode.Click += lblCode_Click;
            lblCode.MouseEnter += lblCode_MouseEnter;
            lblCode.MouseLeave += lblCode_MouseLeave;
            // 
            // lblHomepage
            // 
            lblHomepage.AutoSize = true;
            lblHomepage.BackColor = Color.Transparent;
            lblHomepage.Cursor = Cursors.Hand;
            lblHomepage.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            lblHomepage.ForeColor = SystemColors.WindowFrame;
            lblHomepage.Location = new Point(210, 66);
            lblHomepage.Name = "lblHomepage";
            lblHomepage.Size = new Size(89, 23);
            lblHomepage.TabIndex = 17;
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
            lblTrennung1.TabIndex = 18;
            lblTrennung1.Text = "/";
            // 
            // lblProjekte
            // 
            lblProjekte.AutoSize = true;
            lblProjekte.BackColor = Color.Transparent;
            lblProjekte.Cursor = Cursors.Hand;
            lblProjekte.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            lblProjekte.ForeColor = SystemColors.WindowFrame;
            lblProjekte.Location = new Point(308, 66);
            lblProjekte.Name = "lblProjekte";
            lblProjekte.Size = new Size(69, 23);
            lblProjekte.TabIndex = 19;
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
            lblTrennung2.TabIndex = 20;
            lblTrennung2.Text = "/";
            // 
            // lblDeineSchritte
            // 
            lblDeineSchritte.AutoSize = true;
            lblDeineSchritte.Cursor = Cursors.Hand;
            lblDeineSchritte.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic);
            lblDeineSchritte.Location = new Point(387, 66);
            lblDeineSchritte.Name = "lblDeineSchritte";
            lblDeineSchritte.Size = new Size(111, 23);
            lblDeineSchritte.TabIndex = 21;
            lblDeineSchritte.Text = "Deine Schritte";
            lblDeineSchritte.MouseEnter += lblDeineSchritte_MouseEnter;
            lblDeineSchritte.MouseLeave += lblDeineSchritte_MouseLeave;
            // 
            // StepsOverviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1008, 585);
            Controls.Add(lblDeineSchritte);
            Controls.Add(lblProjekte);
            Controls.Add(lblHomepage);
            Controls.Add(lblCode);
            Controls.Add(lblZeitplan);
            Controls.Add(lblTechnischeSpez);
            Controls.Add(lblThema);
            Controls.Add(sidebar1);
            Controls.Add(topBarControl1);
            Controls.Add(label1);
            Controls.Add(nameLabel);
            Controls.Add(lblTrennung2);
            Controls.Add(lblTrennung1);
            Name = "StepsOverviewForm";
            Text = "ÜbersichtForm";
            Load += StepsOverviewForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void StepLabel_MouseEnter(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Bold | FontStyle.Underline);
            }
        }

        private void StepLabel_MouseLeave(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Bold);
            }
        }

        #endregion

        private Label nameLabel;
        private Topbar.TopBarControl topBarControl1;
        private Sidebar sidebar1;
        private Label label1;
        private Label lblThema;
        private Label lblTechnischeSpez;
        private Label lblZeitplan;
        private Label lblCode;
        private Label lblHomepage;
        private Label lblTrennung1;
        private Label lblProjekte;
        private Label lblTrennung2;
        private Label lblDeineSchritte;
    }
}