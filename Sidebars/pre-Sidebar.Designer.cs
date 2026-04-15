namespace Programmierprojekt.Sidebars
{
    partial class pre_Sidebar
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
            preSidebarPanel = new Panel();
            btnProjects = new Button();
            btnGroup = new Button();
            preSidebarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // preSidebarPanel
            // 
            preSidebarPanel.BackColor = Color.FromArgb(224, 220, 228);
            preSidebarPanel.Controls.Add(btnProjects);
            preSidebarPanel.Controls.Add(btnGroup);
            preSidebarPanel.Dock = DockStyle.Fill;
            preSidebarPanel.Location = new Point(0, 0);
            preSidebarPanel.Name = "preSidebarPanel";
            preSidebarPanel.Size = new Size(204, 640);
            preSidebarPanel.TabIndex = 0;
            // 
            // btnProjects
            // 
            btnProjects.Cursor = Cursors.Hand;
            btnProjects.FlatAppearance.BorderSize = 0;
            btnProjects.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProjects.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProjects.FlatStyle = FlatStyle.Flat;
            btnProjects.Font = new Font("Segoe UI", 12F);
            btnProjects.Location = new Point(7, 19);
            btnProjects.Name = "btnProjects";
            btnProjects.Size = new Size(94, 38);
            btnProjects.TabIndex = 1;
            btnProjects.Text = "Projekte";
            btnProjects.TextAlign = ContentAlignment.MiddleLeft;
            btnProjects.UseVisualStyleBackColor = true;
            btnProjects.Click += btnProjects_Click;
            btnProjects.MouseEnter += btnProjects_MouseEnter;
            btnProjects.MouseLeave += btnProjects_MouseLeave;
            // 
            // btnGroup
            // 
            btnGroup.Cursor = Cursors.Hand;
            btnGroup.FlatAppearance.BorderSize = 0;
            btnGroup.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnGroup.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnGroup.FlatStyle = FlatStyle.Flat;
            btnGroup.Font = new Font("Segoe UI", 12F);
            btnGroup.Location = new Point(7, 74);
            btnGroup.Name = "btnGroup";
            btnGroup.Size = new Size(100, 38);
            btnGroup.TabIndex = 0;
            btnGroup.Text = "Gruppen";
            btnGroup.TextAlign = ContentAlignment.MiddleLeft;
            btnGroup.UseVisualStyleBackColor = true;
            btnGroup.Click += btnGroup_Click;
            btnGroup.MouseEnter += btnGroup_MouseEnter;
            btnGroup.MouseLeave += btnGroup_MouseLeave;
            // 
            // pre_Sidebar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(preSidebarPanel);
            Name = "pre_Sidebar";
            Size = new Size(204, 640);
            preSidebarPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel preSidebarPanel;
        private Button btnGroup;
        private Button btnProjects;
    }
}
