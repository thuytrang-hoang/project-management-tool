namespace Programmierprojekt.Topbar
{
    partial class TopBarControl
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
            panelTop = new Panel();
            pictureBoxVN = new PictureBox();
            pictureBoxHomepage = new PictureBox();
            btnName = new Button();
            btnHomepage = new Button();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxVN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHomepage).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(224, 220, 228);
            panelTop.Controls.Add(pictureBoxVN);
            panelTop.Controls.Add(pictureBoxHomepage);
            panelTop.Controls.Add(btnName);
            panelTop.Controls.Add(btnHomepage);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1008, 60);
            panelTop.TabIndex = 0;
            // 
            // pictureBoxVN
            // 
            pictureBoxVN.Cursor = Cursors.Hand;
            pictureBoxVN.Location = new Point(950, 12);
            pictureBoxVN.Name = "pictureBoxVN";
            pictureBoxVN.Size = new Size(37, 37);
            pictureBoxVN.TabIndex = 3;
            pictureBoxVN.TabStop = false;
            pictureBoxVN.Click += pictureBoxVN_Click;
            pictureBoxVN.Paint += pictureBoxVN_Paint;
            pictureBoxVN.Image = new Bitmap(37, 37);  
            pictureBoxHomepage.Image = new Bitmap(37, 37);
            // 
            // pictureBoxHomepage
            // 
            pictureBoxHomepage.BackColor = Color.Transparent;
            pictureBoxHomepage.Cursor = Cursors.Hand;
            pictureBoxHomepage.Location = new Point(19, 12);
            pictureBoxHomepage.Name = "pictureBoxHomepage";
            pictureBoxHomepage.Size = new Size(37, 37);
            pictureBoxHomepage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHomepage.TabIndex = 2;
            pictureBoxHomepage.TabStop = false;
            pictureBoxHomepage.Click += pictureBoxHomepage_Click;
            pictureBoxHomepage.Paint += pictureBoxHomepage_Paint;
            // 
            // btnName
            // 
            btnName.Cursor = Cursors.Hand;
            btnName.FlatAppearance.BorderSize = 0;
            btnName.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnName.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnName.FlatStyle = FlatStyle.Flat;
            btnName.Font = new Font("Segoe UI", 12F);
            btnName.Location = new Point(747, 8);
            btnName.Name = "btnName";
            btnName.Size = new Size(197, 44);
            btnName.TabIndex = 1;
            btnName.TabStop = false;
            btnName.Text = "Vorname Nachname";
            btnName.TextAlign = ContentAlignment.MiddleRight;
            btnName.UseVisualStyleBackColor = true;
            btnName.Click += btnName_Click;
            // 
            // btnHomepage
            // 
            btnHomepage.BackgroundImageLayout = ImageLayout.None;
            btnHomepage.Cursor = Cursors.Hand;
            btnHomepage.FlatAppearance.BorderSize = 0;
            btnHomepage.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnHomepage.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnHomepage.FlatStyle = FlatStyle.Flat;
            btnHomepage.Font = new Font("Segoe UI", 12F);
            btnHomepage.Location = new Point(56, 7);
            btnHomepage.Name = "btnHomepage";
            btnHomepage.Size = new Size(130, 44);
            btnHomepage.TabIndex = 0;
            btnHomepage.Text = "Homepage";
            btnHomepage.TextAlign = ContentAlignment.MiddleLeft;
            btnHomepage.TextImageRelation = TextImageRelation.ImageAboveText;
            btnHomepage.UseVisualStyleBackColor = true;
            btnHomepage.Click += btnHomepage_Click;
            // 
            // TopBarControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelTop);
            Name = "TopBarControl";
            Size = new Size(1008, 60);
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxVN).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHomepage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button btnHomepage;
        private Button btnName;
        private PictureBox pictureBoxHomepage;
        private PictureBox pictureBoxVN;
    }
}
