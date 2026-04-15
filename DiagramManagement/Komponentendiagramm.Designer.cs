namespace Programmierprojekt.DiagramManagement
{
    partial class Komponentendiagramm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Komponentendiagramm));
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            textbox = new ToolStripButton();
            rectangle = new ToolStripButton();
            line = new ToolStripButton();
            polyline = new ToolStripButton();
            arrow = new ToolStripButton();
            polyArrow = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            Schnittstelle = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            interfaceBottomImage = new ToolStripButton();
            interfaceRightImage = new ToolStripButton();
            interfaceLeftImage = new ToolStripButton();
            artifactImage = new ToolStripButton();
            componentImage = new ToolStripButton();
            portImage = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            isDashed = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            auswahlmodus = new ToolStripButton();
            removeButton = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            DeleteTextBox = new ToolStripButton();
            pictureBox = new PictureBox();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip1.Location = new System.Drawing.Point(0, 907);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1902, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(197, 20);
            toolStripStatusLabel.Text = "Messages from applications.";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(235, 232, 240);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, newToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(59, 24);
            fileToolStripMenuItem.Text = "Datei";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(68, 24);
            openToolStripMenuItem.Text = "Öffnen";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(88, 24);
            saveToolStripMenuItem.Text = "Speichern";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(50, 24);
            newToolStripMenuItem.Text = "Neu";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(235, 232, 240);
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { textbox, rectangle, line, polyline, arrow, polyArrow, toolStripSeparator3, Schnittstelle, toolStripButton4, interfaceBottomImage, interfaceRightImage, interfaceLeftImage, artifactImage, componentImage, portImage, toolStripSeparator1, isDashed, toolStripSeparator2, auswahlmodus, removeButton, toolStripSeparator4, DeleteTextBox });
            toolStrip1.Location = new System.Drawing.Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1902, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // textbox
            // 
            textbox.DisplayStyle = ToolStripItemDisplayStyle.Text;
            textbox.Image = (Image)resources.GetObject("textbox.Image");
            textbox.ImageTransparentColor = Color.Magenta;
            textbox.Name = "textbox";
            textbox.Size = new Size(65, 24);
            textbox.Text = "TextBox";
            textbox.Click += textbox_Click;
            // 
            // rectangle
            // 
            rectangle.DisplayStyle = ToolStripItemDisplayStyle.Text;
            rectangle.Image = (Image)resources.GetObject("rectangle.Image");
            rectangle.ImageTransparentColor = Color.Magenta;
            rectangle.Name = "rectangle";
            rectangle.Size = new Size(72, 24);
            rectangle.Text = "Rechteck";
            rectangle.Click += rectangle_Click;
            // 
            // line
            // 
            line.DisplayStyle = ToolStripItemDisplayStyle.Text;
            line.Image = (Image)resources.GetObject("line.Image");
            line.ImageTransparentColor = Color.Magenta;
            line.Name = "line";
            line.Size = new Size(44, 24);
            line.Text = "Linie";
            line.Click += line_Click;
            // 
            // polyline
            // 
            polyline.DisplayStyle = ToolStripItemDisplayStyle.Text;
            polyline.Image = (Image)resources.GetObject("polyline.Image");
            polyline.ImageTransparentColor = Color.Magenta;
            polyline.Name = "polyline";
            polyline.Size = new Size(68, 24);
            polyline.Text = "Polylinie";
            polyline.Click += polyline_Click;
            // 
            // arrow
            // 
            arrow.DisplayStyle = ToolStripItemDisplayStyle.Text;
            arrow.Image = (Image)resources.GetObject("arrow.Image");
            arrow.ImageTransparentColor = Color.Magenta;
            arrow.Name = "arrow";
            arrow.Size = new Size(42, 24);
            arrow.Text = "Pfeil";
            arrow.Click += arrow_Click;
            // 
            // polyArrow
            // 
            polyArrow.DisplayStyle = ToolStripItemDisplayStyle.Text;
            polyArrow.Image = (Image)resources.GetObject("polyArrow.Image");
            polyArrow.ImageTransparentColor = Color.Magenta;
            polyArrow.Name = "polyArrow";
            polyArrow.Size = new Size(70, 24);
            polyArrow.Text = "Polypfeil";
            polyArrow.Click += polyArrow_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // Schnittstelle
            // 
            Schnittstelle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Schnittstelle.Image = (Image)resources.GetObject("Schnittstelle.Image");
            Schnittstelle.ImageTransparentColor = Color.Magenta;
            Schnittstelle.Name = "Schnittstelle";
            Schnittstelle.Size = new Size(29, 24);
            Schnittstelle.Text = "Schnittstelle";
            Schnittstelle.Click += interfaceImage_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(29, 24);
            toolStripButton4.Text = "interfaceTopImage";
            toolStripButton4.Click += interfaceTopImage_Click;
            // 
            // interfaceBottomImage
            // 
            interfaceBottomImage.DisplayStyle = ToolStripItemDisplayStyle.Image;
            interfaceBottomImage.Image = (Image)resources.GetObject("interfaceBottomImage.Image");
            interfaceBottomImage.ImageTransparentColor = Color.Magenta;
            interfaceBottomImage.Name = "interfaceBottomImage";
            interfaceBottomImage.Size = new Size(29, 24);
            interfaceBottomImage.Text = "SchnittstelleUnten";
            interfaceBottomImage.Click += interfaceBottomImage_Click;
            // 
            // interfaceRightImage
            // 
            interfaceRightImage.DisplayStyle = ToolStripItemDisplayStyle.Image;
            interfaceRightImage.Image = (Image)resources.GetObject("interfaceRightImage.Image");
            interfaceRightImage.ImageTransparentColor = Color.Magenta;
            interfaceRightImage.Name = "interfaceRightImage";
            interfaceRightImage.Size = new Size(29, 24);
            interfaceRightImage.Text = "SchnittstelleRechts";
            interfaceRightImage.Click += interfaceRightImage_Click;
            // 
            // interfaceLeftImage
            // 
            interfaceLeftImage.DisplayStyle = ToolStripItemDisplayStyle.Image;
            interfaceLeftImage.Image = (Image)resources.GetObject("interfaceLeftImage.Image");
            interfaceLeftImage.ImageTransparentColor = Color.Magenta;
            interfaceLeftImage.Name = "interfaceLeftImage";
            interfaceLeftImage.Size = new Size(29, 24);
            interfaceLeftImage.Text = "SchnittstelleLinks";
            interfaceLeftImage.Click += interfaceLeftImage_Click;
            // 
            // artifactImage
            // 
            artifactImage.DisplayStyle = ToolStripItemDisplayStyle.Image;
            artifactImage.Image = (Image)resources.GetObject("artifactImage.Image");
            artifactImage.ImageTransparentColor = Color.Magenta;
            artifactImage.Name = "artifactImage";
            artifactImage.Size = new Size(29, 24);
            artifactImage.Text = "Artefakt";
            artifactImage.Click += artifactImage_Click;
            // 
            // componentImage
            // 
            componentImage.DisplayStyle = ToolStripItemDisplayStyle.Image;
            componentImage.Image = (Image)resources.GetObject("componentImage.Image");
            componentImage.ImageTransparentColor = Color.Magenta;
            componentImage.Name = "componentImage";
            componentImage.Size = new Size(29, 24);
            componentImage.Text = "Komponente";
            componentImage.Click += componentImage_Click;
            // 
            // portImage
            // 
            portImage.DisplayStyle = ToolStripItemDisplayStyle.Image;
            portImage.Image = (Image)resources.GetObject("portImage.Image");
            portImage.ImageTransparentColor = Color.Magenta;
            portImage.Name = "portImage";
            portImage.Size = new Size(29, 24);
            portImage.Text = "Port";
            portImage.Click += portImage_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // isDashed
            // 
            isDashed.DisplayStyle = ToolStripItemDisplayStyle.Text;
            isDashed.Image = (Image)resources.GetObject("isDashed.Image");
            isDashed.ImageTransparentColor = Color.Magenta;
            isDashed.Name = "isDashed";
            isDashed.Size = new Size(82, 24);
            isDashed.Text = "gestrichelt";
            isDashed.Click += isDashed_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // auswahlmodus
            // 
            auswahlmodus.DisplayStyle = ToolStripItemDisplayStyle.Text;
            auswahlmodus.Image = (Image)resources.GetObject("auswahlmodus.Image");
            auswahlmodus.ImageTransparentColor = Color.Magenta;
            auswahlmodus.Name = "auswahlmodus";
            auswahlmodus.Size = new Size(82, 24);
            auswahlmodus.Text = "auswählen";
            auswahlmodus.Click += auswahlmodus_Click;
            // 
            // removeButton
            // 
            removeButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            removeButton.Image = (Image)resources.GetObject("removeButton.Image");
            removeButton.ImageTransparentColor = Color.Magenta;
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(63, 24);
            removeButton.Text = "löschen";
            removeButton.Click += removeButton_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 27);
            // 
            // DeleteTextBox
            // 
            DeleteTextBox.DisplayStyle = ToolStripItemDisplayStyle.Text;
            DeleteTextBox.Image = (Image)resources.GetObject("DeleteTextBox.Image");
            DeleteTextBox.ImageTransparentColor = Color.Magenta;
            DeleteTextBox.Name = "DeleteTextBox";
            DeleteTextBox.Size = new Size(119, 24);
            DeleteTextBox.Text = "TextBox löschen";
            DeleteTextBox.Click += btnDeleteTextBox_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.Window;
            pictureBox.Location = new System.Drawing.Point(0, 58);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1902, 846);
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            pictureBox.Paint += pictureBox_Paint;
            pictureBox.MouseClick += pictureBox_MouseClick;
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
            // 
            // Komponentendiagramm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 933);
            Controls.Add(pictureBox);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Komponentendiagramm";
            Text = "Komponentendiagramm";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStrip toolStrip1;
        private PictureBox pictureBox;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripButton textbox;
        private ToolStripButton rectangle;
        private ToolStripButton line;
        private ToolStripButton polyline;
        private ToolStripButton arrow;
        private ToolStripButton polyArrow;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton auswahlmodus;
        private ToolStripButton removeButton;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton isDashed;
        private ToolStripButton interfaceImage;
        private ToolStripButton interfaceTopImage;
        private ToolStripButton interfaceBottomImage;
        private ToolStripButton interfaceRightImage;
        private ToolStripButton interfaceLeftImage;
        private ToolStripButton artifactImage;
        private ToolStripButton componentImage;
        private ToolStripButton portImage;
        private ToolStripButton Schnittstelle;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton DeleteTextBox;
    }
}