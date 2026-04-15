using System.Windows.Forms;

namespace Programmierprojekt.DiagramManagement
{
    partial class TechnischeSpezifikationenDiagramme
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
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            newDiagramButton = new Button();
            TechnischeSpezifikationenÜberschrift = new Label();
            topBarControl1 = new Topbar.TopBarControl();
            sidebar1 = new Sidebar();
            lvDiagrams = new ListView();
            colTyp = new ColumnHeader();
            colName = new ColumnHeader();
            colDatum = new ColumnHeader();
            colMitglied = new ColumnHeader();
            lblTechnischeSpezifikationen = new Label();
            lblProjekte = new Label();
            lblHomepage = new Label();
            lblTrennung1 = new Label();
            lblTrennung2 = new Label();
            SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // newDiagramButton
            // 
            newDiagramButton.BackColor = Color.FromArgb(235, 232, 240);
            newDiagramButton.Cursor = Cursors.Hand;
            newDiagramButton.Location = new System.Drawing.Point(220, 176);
            newDiagramButton.Name = "newDiagramButton";
            newDiagramButton.Size = new Size(154, 29);
            newDiagramButton.TabIndex = 3;
            newDiagramButton.Text = "neues Diagramm erstellen";
            newDiagramButton.UseVisualStyleBackColor = false;
            newDiagramButton.Click += newDiagrammButton_Click;
            // 
            // TechnischeSpezifikationenÜberschrift
            // 
            TechnischeSpezifikationenÜberschrift.AutoSize = true;
            TechnischeSpezifikationenÜberschrift.Font = new Font("Segoe UI", 20F);
            TechnischeSpezifikationenÜberschrift.ForeColor = Color.FromArgb(64, 0, 64);
            TechnischeSpezifikationenÜberschrift.Location = new System.Drawing.Point(220, 117);
            TechnischeSpezifikationenÜberschrift.Name = "TechnischeSpezifikationenÜberschrift";
            TechnischeSpezifikationenÜberschrift.Size = new Size(419, 46);
            TechnischeSpezifikationenÜberschrift.TabIndex = 5;
            TechnischeSpezifikationenÜberschrift.Text = "Technische Spezifikationen";
            // 
            // topBarControl1
            // 
            topBarControl1.BackColor = Color.FromArgb(235, 232, 240);
            topBarControl1.Dock = DockStyle.Top;
            topBarControl1.Location = new System.Drawing.Point(0, 0);
            topBarControl1.Name = "topBarControl1";
            topBarControl1.Size = new Size(1008, 60);
            topBarControl1.TabIndex = 7;
            // 
            // sidebar1
            // 
            sidebar1.BackColor = Color.FromArgb(235, 232, 240);
            sidebar1.Dock = DockStyle.Left;
            sidebar1.Location = new System.Drawing.Point(0, 60);
            sidebar1.Name = "sidebar1";
            sidebar1.Size = new Size(204, 525);
            sidebar1.TabIndex = 8;
            // 
            // lvDiagrams
            // 
            lvDiagrams.Columns.AddRange(new ColumnHeader[] { colTyp, colName, colDatum, colMitglied });
            lvDiagrams.Location = new System.Drawing.Point(220, 225);
            lvDiagrams.Name = "lvDiagrams";
            lvDiagrams.Size = new Size(776, 328);
            lvDiagrams.TabIndex = 9;
            lvDiagrams.UseCompatibleStateImageBehavior = false;
            lvDiagrams.View = View.Details;
            // 
            // colTyp
            // 
            colTyp.Text = "                 Typ";
            colTyp.Width = 185;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.TextAlign = HorizontalAlignment.Center;
            colName.Width = 185;
            // 
            // colDatum
            // 
            colDatum.Text = "Datum";
            colDatum.TextAlign = HorizontalAlignment.Center;
            colDatum.Width = 185;
            // 
            // colMitglied
            // 
            colMitglied.Text = "Mitglied";
            colMitglied.TextAlign = HorizontalAlignment.Center;
            colMitglied.Width = 185;
            // 
            // lblTechnischeSpezifikationen
            // 
            lblTechnischeSpezifikationen.AutoSize = true;
            lblTechnischeSpezifikationen.Cursor = Cursors.Hand;
            lblTechnischeSpezifikationen.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTechnischeSpezifikationen.ForeColor = SystemColors.ControlText;
            lblTechnischeSpezifikationen.Location = new System.Drawing.Point(386, 63);
            lblTechnischeSpezifikationen.Name = "lblTechnischeSpezifikationen";
            lblTechnischeSpezifikationen.Size = new Size(203, 23);
            lblTechnischeSpezifikationen.TabIndex = 14;
            lblTechnischeSpezifikationen.Text = "Technische Spezifikationen";
            lblTechnischeSpezifikationen.MouseEnter += lblTechnSpez_MouseEnter;
            lblTechnischeSpezifikationen.MouseLeave += lblTechnSpez_MouseLeave;
            // 
            // lblProjekte
            // 
            lblProjekte.AutoSize = true;
            lblProjekte.BackColor = Color.Transparent;
            lblProjekte.Cursor = Cursors.Hand;
            lblProjekte.FlatStyle = FlatStyle.Flat;
            lblProjekte.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProjekte.ForeColor = SystemColors.WindowFrame;
            lblProjekte.Location = new System.Drawing.Point(307, 63);
            lblProjekte.Name = "lblProjekte";
            lblProjekte.Size = new Size(69, 23);
            lblProjekte.TabIndex = 12;
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
            lblHomepage.Location = new System.Drawing.Point(209, 63);
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
            lblTrennung1.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTrennung1.ForeColor = SystemColors.WindowFrame;
            lblTrennung1.Location = new System.Drawing.Point(295, 63);
            lblTrennung1.Name = "lblTrennung1";
            lblTrennung1.Size = new Size(17, 23);
            lblTrennung1.TabIndex = 11;
            lblTrennung1.Text = "/";
            // 
            // lblTrennung2
            // 
            lblTrennung2.AutoSize = true;
            lblTrennung2.BackColor = Color.Transparent;
            lblTrennung2.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTrennung2.ForeColor = SystemColors.WindowFrame;
            lblTrennung2.Location = new System.Drawing.Point(373, 63);
            lblTrennung2.Name = "lblTrennung2";
            lblTrennung2.Size = new Size(17, 23);
            lblTrennung2.TabIndex = 13;
            lblTrennung2.Text = "/";
            // 
            // TechnischeSpezifikationenDiagramme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1008, 585);
            Controls.Add(lblTechnischeSpezifikationen);
            Controls.Add(lblProjekte);
            Controls.Add(lblHomepage);
            Controls.Add(lblTrennung1);
            Controls.Add(lblTrennung2);
            Controls.Add(lvDiagrams);
            Controls.Add(sidebar1);
            Controls.Add(topBarControl1);
            Controls.Add(TechnischeSpezifikationenÜberschrift);
            Controls.Add(newDiagramButton);
            Name = "TechnischeSpezifikationenDiagramme";
            Text = "TechnischeSpezifikationenDiagramme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button newDiagramButton;
        private Label TechnischeSpezifikationenÜberschrift;
        private Topbar.TopBarControl topBarControl1;
        private Sidebar sidebar1;
        private ListView lvDiagrams;
        private ColumnHeader colTyp;
        private ColumnHeader colName;
        private ColumnHeader colDatum;
        private ColumnHeader colMitglied;
        private Label lblTechnischeSpezifikationen;
        private Label lblProjekte;
        private Label lblHomepage;
        private Label lblTrennung1;
        private Label lblTrennung2;
    }
}