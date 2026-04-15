using Programmierprojekt;

namespace Programmierprojekt
{
    partial class TopicForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            topBarControl1 = new Topbar.TopBarControl();
            sidebar1 = new Sidebar();
            panel2 = new Panel();
            chatPanel = new FlowLayoutPanel();
            sendButton = new Button();
            panel4 = new Panel();
            newChat = new Button();
            historyTitle = new Label();
            chatHistory = new ListBox();
            questionsBox = new TextBox();
            titlePanel = new Panel();
            chatLabel = new Label();
            hauptPanel = new Panel();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            titlePanel.SuspendLayout();
            hauptPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topBarControl1
            // 
            topBarControl1.BackColor = Color.Transparent;
            topBarControl1.Dock = DockStyle.Top;
            topBarControl1.Location = new Point(0, 0);
            topBarControl1.Name = "topBarControl1";
            topBarControl1.Size = new Size(1008, 60);
            topBarControl1.TabIndex = 2;
            // 
            // sidebar1
            // 
            sidebar1.BackColor = Color.LavenderBlush;
            sidebar1.Dock = DockStyle.Left;
            sidebar1.Location = new Point(0, 60);
            sidebar1.Name = "sidebar1";
            sidebar1.Size = new Size(204, 525);
            sidebar1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(chatPanel);
            panel2.Controls.Add(sendButton);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(questionsBox);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(807, 525);
            panel2.TabIndex = 3;
            // 
            // chatPanel
            // 
            chatPanel.BackColor = Color.WhiteSmoke;
            chatPanel.BorderStyle = BorderStyle.Fixed3D;
            chatPanel.FlowDirection = FlowDirection.TopDown;
            chatPanel.Location = new Point(145, 61);
            chatPanel.Name = "chatPanel";
            chatPanel.Size = new Size(661, 411);
            chatPanel.TabIndex = 5;
            chatPanel.AutoScroll = true;
            chatPanel.WrapContents = false;
            // 
            // sendButton
            // 
            sendButton.BackColor = Color.Gray;
            sendButton.Cursor = Cursors.Hand;
            sendButton.ForeColor = Color.White;
            sendButton.Location = new Point(749, 471);
            sendButton.Margin = new Padding(3, 4, 3, 4);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(54, 49);
            sendButton.TabIndex = 3;
            sendButton.Text = "➤";
            sendButton.UseVisualStyleBackColor = false;
            sendButton.Click += buttonSend_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Snow;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(newChat);
            panel4.Controls.Add(historyTitle);
            panel4.Controls.Add(chatHistory);
            panel4.Location = new Point(0, 61);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(146, 463);
            panel4.TabIndex = 2;
            // 
            // newChat
            // 
            newChat.BackColor = Color.Snow;
            newChat.Cursor = Cursors.Hand;
            newChat.Font = new Font("Segoe UI", 10F);
            newChat.Location = new Point(6, 5);
            newChat.Name = "newChat";
            newChat.Size = new Size(126, 44);
            newChat.TabIndex = 4;
            newChat.Text = "➕neuer Chat ";
            newChat.UseVisualStyleBackColor = false;
            newChat.Click += buttonNewChat_Click;
            // 
            // historyTitle
            // 
            historyTitle.AutoSize = true;
            historyTitle.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            historyTitle.ForeColor = Color.Black;
            historyTitle.Location = new Point(3, 82);
            historyTitle.Name = "historyTitle";
            historyTitle.Size = new Size(85, 20);
            historyTitle.TabIndex = 3;
            historyTitle.Text = "letzte Chats";
            // 
            // chatHistory
            // 
            chatHistory.BackColor = Color.Snow;
            chatHistory.BorderStyle = BorderStyle.None;
            chatHistory.Cursor = Cursors.Hand;
            chatHistory.Font = new Font("Segoe UI", 9.5F);
            chatHistory.FormattingEnabled = true;
            chatHistory.ItemHeight = 21;
            chatHistory.Location = new Point(3, 105);
            chatHistory.Name = "chatHistory";
            chatHistory.Size = new Size(122, 294);
            chatHistory.TabIndex = 1;
            chatHistory.DoubleClick += chatHistory_DoubleClick;
            // 
            // questionsBox
            // 
            questionsBox.BackColor = Color.Gainsboro;
            questionsBox.Location = new Point(145, 468);
            questionsBox.Margin = new Padding(3, 4, 3, 4);
            questionsBox.Multiline = true;
            questionsBox.Name = "questionsBox";
            questionsBox.PlaceholderText = "Stelle eine Frage...";
            questionsBox.Size = new Size(661, 52);
            questionsBox.TabIndex = 2;
            // 
            // titlePanel
            // 
            titlePanel.BackColor = Color.Snow;
            titlePanel.BorderStyle = BorderStyle.Fixed3D;
            titlePanel.Controls.Add(chatLabel);
            titlePanel.Location = new Point(204, 60);
            titlePanel.Margin = new Padding(3, 4, 3, 4);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(804, 62);
            titlePanel.TabIndex = 1;
            // 
            // chatLabel
            // 
            chatLabel.AutoSize = true;
            chatLabel.BackColor = Color.Transparent;
            chatLabel.Font = new Font("Segoe UI", 13F);
            chatLabel.Location = new Point(14, 17);
            chatLabel.Name = "chatLabel";
            chatLabel.Size = new Size(296, 30);
            chatLabel.TabIndex = 0;
            chatLabel.Text = "Chat mit KI über dein Thema!";
            chatLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hauptPanel
            // 
            hauptPanel.BackColor = SystemColors.ControlLightLight;
            hauptPanel.Controls.Add(panel2);
            hauptPanel.Location = new Point(201, 60);
            hauptPanel.Margin = new Padding(3, 4, 3, 4);
            hauptPanel.Name = "hauptPanel";
            hauptPanel.Size = new Size(807, 525);
            hauptPanel.TabIndex = 1;
            // 
            // TopicForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 585);
            Controls.Add(sidebar1);
            Controls.Add(titlePanel);
            Controls.Add(topBarControl1);
            Controls.Add(hauptPanel);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "TopicForm";
            Text = "TopicForm";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            hauptPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Topbar.TopBarControl topBarControl1;
        private Sidebar sidebar1;
        private Panel panel2;
        private FlowLayoutPanel chatPanel;
        private Button sendButton;
        private Panel panel4;
        private Button newChat;
        private Label historyTitle;
        private ListBox chatHistory;
        private TextBox questionsBox;
        private Panel titlePanel;
        private Label chatLabel;
        private Panel hauptPanel;
    }
}
