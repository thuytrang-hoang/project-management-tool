namespace Programmierprojekt
{
    partial class Sidebar
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
            sidebarPanel = new Panel();
            lblProjName = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnTechsp = new Button();
            btnCodeOverview = new Button();
            btnTimeTable = new Button();
            btnTopic = new Button();
            btnSteps = new Button();
            btnAssistant = new Button();
            btnGroup = new Button();
            sidebarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(224, 220, 228);
            sidebarPanel.Controls.Add(lblProjName);
            sidebarPanel.Controls.Add(label4);
            sidebarPanel.Controls.Add(label3);
            sidebarPanel.Controls.Add(label2);
            sidebarPanel.Controls.Add(label1);
            sidebarPanel.Controls.Add(btnTechsp);
            sidebarPanel.Controls.Add(btnCodeOverview);
            sidebarPanel.Controls.Add(btnTimeTable);
            sidebarPanel.Controls.Add(btnTopic);
            sidebarPanel.Controls.Add(btnSteps);
            sidebarPanel.Controls.Add(btnAssistant);
            sidebarPanel.Controls.Add(btnGroup);
            sidebarPanel.Dock = DockStyle.Fill;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(204, 640);
            sidebarPanel.TabIndex = 0;
            // 
            // lblProjName
            // 
            lblProjName.AutoSize = true;
            lblProjName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblProjName.Location = new Point(11, 22);
            lblProjName.Name = "lblProjName";
            lblProjName.Size = new Size(118, 28);
            lblProjName.TabIndex = 15;
            lblProjName.Text = "Team Fuchs";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 397);
            label4.Name = "label4";
            label4.Size = new Size(26, 25);
            label4.TabIndex = 14;
            label4.Text = "4.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 337);
            label3.Name = "label3";
            label3.Size = new Size(26, 25);
            label3.TabIndex = 13;
            label3.Text = "3.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 272);
            label2.Name = "label2";
            label2.Size = new Size(26, 25);
            label2.TabIndex = 12;
            label2.Text = "2.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 232);
            label1.Name = "label1";
            label1.Size = new Size(26, 25);
            label1.TabIndex = 11;
            label1.Text = "1.";
            // 
            // btnTechsp
            // 
            btnTechsp.Cursor = Cursors.Hand;
            btnTechsp.FlatAppearance.BorderSize = 0;
            btnTechsp.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTechsp.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTechsp.FlatStyle = FlatStyle.Flat;
            btnTechsp.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTechsp.Location = new Point(33, 269);
            btnTechsp.Name = "btnTechsp";
            btnTechsp.Size = new Size(121, 58);
            btnTechsp.TabIndex = 10;
            btnTechsp.Text = "Technische Spezifikation";
            btnTechsp.TextAlign = ContentAlignment.MiddleLeft;
            btnTechsp.UseVisualStyleBackColor = true;
            btnTechsp.Click += btnTechsp_Click;
            btnTechsp.MouseEnter += btnTechsp_MouseEnter;
            btnTechsp.MouseLeave += btnTechsp_MouseLeave;
            // 
            // btnCodeOverview
            // 
            btnCodeOverview.Cursor = Cursors.Hand;
            btnCodeOverview.FlatAppearance.BorderSize = 0;
            btnCodeOverview.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCodeOverview.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCodeOverview.FlatStyle = FlatStyle.Flat;
            btnCodeOverview.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCodeOverview.Location = new Point(33, 394);
            btnCodeOverview.Name = "btnCodeOverview";
            btnCodeOverview.Size = new Size(141, 34);
            btnCodeOverview.TabIndex = 9;
            btnCodeOverview.Text = "Code-Übersicht";
            btnCodeOverview.TextAlign = ContentAlignment.MiddleLeft;
            btnCodeOverview.UseVisualStyleBackColor = true;
            btnCodeOverview.Click += btnCodeOverview_Click;
            btnCodeOverview.MouseEnter += btnCodeOverview_MouseEnter;
            btnCodeOverview.MouseLeave += btnCodeOverview_MouseLeave;
            // 
            // btnTimeTable
            // 
            btnTimeTable.Cursor = Cursors.Hand;
            btnTimeTable.FlatAppearance.BorderSize = 0;
            btnTimeTable.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTimeTable.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTimeTable.FlatStyle = FlatStyle.Flat;
            btnTimeTable.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTimeTable.Location = new Point(33, 333);
            btnTimeTable.Name = "btnTimeTable";
            btnTimeTable.Size = new Size(121, 60);
            btnTimeTable.TabIndex = 8;
            btnTimeTable.Text = "Zeitplan und -einteilung";
            btnTimeTable.TextAlign = ContentAlignment.MiddleLeft;
            btnTimeTable.UseVisualStyleBackColor = true;
            btnTimeTable.Click += btnbtnTimeTable;
            btnTimeTable.MouseEnter += btnTimeTable_MouseEnter;
            btnTimeTable.MouseLeave += btnTimeTable_MouseLeave;
            // 
            // btnTopic
            // 
            btnTopic.Cursor = Cursors.Hand;
            btnTopic.FlatAppearance.BorderSize = 0;
            btnTopic.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTopic.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTopic.FlatStyle = FlatStyle.Flat;
            btnTopic.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTopic.Location = new Point(33, 229);
            btnTopic.Name = "btnTopic";
            btnTopic.Size = new Size(75, 34);
            btnTopic.TabIndex = 6;
            btnTopic.Text = "Thema";
            btnTopic.TextAlign = ContentAlignment.MiddleLeft;
            btnTopic.UseVisualStyleBackColor = true;
            btnTopic.Click += btnTopic_Click;
            btnTopic.MouseEnter += btnTopic_MouseEnter;
            btnTopic.MouseLeave += btnTopic_MouseLeave;
            // 
            // btnSteps
            // 
            btnSteps.Cursor = Cursors.Hand;
            btnSteps.FlatAppearance.BorderSize = 0;
            btnSteps.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSteps.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSteps.FlatStyle = FlatStyle.Flat;
            btnSteps.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSteps.Location = new Point(7, 189);
            btnSteps.Name = "btnSteps";
            btnSteps.Size = new Size(157, 34);
            btnSteps.TabIndex = 3;
            btnSteps.Text = "Deine Schritte";
            btnSteps.TextAlign = ContentAlignment.MiddleLeft;
            btnSteps.UseVisualStyleBackColor = true;
            btnSteps.Click += btnSteps_Click;
            btnSteps.MouseEnter += btnSteps_MouseEnter;
            btnSteps.MouseLeave += btnSteps_MouseLeave;
            // 
            // btnAssistant
            // 
            btnAssistant.Cursor = Cursors.Hand;
            btnAssistant.FlatAppearance.BorderSize = 0;
            btnAssistant.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAssistant.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAssistant.FlatStyle = FlatStyle.Flat;
            btnAssistant.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAssistant.Location = new Point(7, 133);
            btnAssistant.Name = "btnAssistant";
            btnAssistant.Size = new Size(125, 34);
            btnAssistant.TabIndex = 2;
            btnAssistant.Text = "KI-Assistent";
            btnAssistant.TextAlign = ContentAlignment.MiddleLeft;
            btnAssistant.UseVisualStyleBackColor = true;
            btnAssistant.Click += btnAssistant_Click;
            btnAssistant.MouseEnter += btnAssistant_MouseEnter;
            btnAssistant.MouseLeave += btnAssistant_MouseLeave;
            // 
            // btnGroup
            // 
            btnGroup.Cursor = Cursors.Hand;
            btnGroup.FlatAppearance.BorderSize = 0;
            btnGroup.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnGroup.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnGroup.FlatStyle = FlatStyle.Flat;
            btnGroup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGroup.Location = new Point(7, 74);
            btnGroup.Name = "btnGroup";
            btnGroup.Size = new Size(94, 38);
            btnGroup.TabIndex = 1;
            btnGroup.Text = "Gruppe";
            btnGroup.TextAlign = ContentAlignment.MiddleLeft;
            btnGroup.UseVisualStyleBackColor = true;
            btnGroup.Click += btnGroup_Click;
            btnGroup.MouseEnter += btnGroup_MouseEnter;
            btnGroup.MouseLeave += btnGroup_MouseLeave;
            // 
            // Sidebar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            Controls.Add(sidebarPanel);
            Name = "Sidebar";
            Size = new Size(204, 640);
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel sidebarPanel;
        private Button btnGroup;
        private Button btnAssistant;
        private Button btnSteps;
        private Button btnTopic;
        private Button btnCodeOverview;
        private Button btnTimeTable;
        private Button btnTechsp;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblProjName;
    }
}
