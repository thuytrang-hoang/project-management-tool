namespace Programmierprojekt.Homepage
{
    partial class HomepageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageForm));
            topBarControl1 = new Topbar.TopBarControl();
            lblHomepage = new Label();
            panelText = new Panel();
            lblText = new Label();
            pre_Sidebar1 = new Sidebars.pre_Sidebar();
            panelText.SuspendLayout();
            SuspendLayout();
            // 
            // topBarControl1
            // 
            topBarControl1.Dock = DockStyle.Top;
            topBarControl1.Location = new Point(0, 0);
            topBarControl1.Name = "topBarControl1";
            topBarControl1.Size = new Size(1008, 60);
            topBarControl1.TabIndex = 0;
            // 
            // lblHomepage
            // 
            lblHomepage.AutoSize = true;
            lblHomepage.Font = new Font("Segoe UI", 20F);
            lblHomepage.ForeColor = Color.FromArgb(64, 0, 64);
            lblHomepage.Location = new Point(219, 75);
            lblHomepage.Name = "lblHomepage";
            lblHomepage.Size = new Size(186, 46);
            lblHomepage.TabIndex = 2;
            lblHomepage.Text = "Homepage";
            // 
            // panelText
            // 
            panelText.AutoScroll = true;
            panelText.Controls.Add(lblText);
            panelText.Location = new Point(216, 132);
            panelText.Name = "panelText";
            panelText.Size = new Size(780, 441);
            panelText.TabIndex = 3;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new Font("Segoe UI", 10F);
            lblText.Location = new Point(9, 11);
            lblText.MaximumSize = new Size(755, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(754, 414);
            lblText.TabIndex = 0;
            lblText.Text = resources.GetString("lblText.Text");
            // 
            // pre_Sidebar1
            // 
            pre_Sidebar1.Dock = DockStyle.Left;
            pre_Sidebar1.Location = new Point(0, 60);
            pre_Sidebar1.Name = "pre_Sidebar1";
            pre_Sidebar1.Size = new Size(204, 525);
            pre_Sidebar1.TabIndex = 4;
            // 
            // HomepageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1008, 585);
            Controls.Add(pre_Sidebar1);
            Controls.Add(panelText);
            Controls.Add(lblHomepage);
            Controls.Add(topBarControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "HomepageForm";
            Text = "Homepage";
            panelText.ResumeLayout(false);
            panelText.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Topbar.TopBarControl topBarControl1;
        private Label lblHomepage;
        private Panel panelText;
        private Label lblText;
        private Sidebars.pre_Sidebar pre_Sidebar1;
    }
}