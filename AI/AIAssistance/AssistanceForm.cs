using Microsoft.VisualBasic.ApplicationServices;
using Programmierprojekt.AI;
using Programmierprojekt.AI.AIAssistance;
using System;
using System.Windows.Forms;


namespace Programmierprojekt
{
    public partial class AssistanceForm : Form
    {
        public AssistanceForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Center window
        }
        private void AddMessage(string message, bool isUser)
        {
            // Container-Panel for the Messages
            Panel messagePanel = new Panel();
            messagePanel.AutoSize = true;
            messagePanel.MaximumSize = new Size(chatPanel.Width - 20, 0); // Maximale Breite der Nachricht
            messagePanel.Margin = new Padding(5);
            messagePanel.Dock = isUser ? DockStyle.Right : DockStyle.Left;

            // Messages text
            Label messageLabel = new Label();
            messageLabel.Text = message;
            messageLabel.AutoSize = true;
            messageLabel.MaximumSize = new Size(chatPanel.Width - 60, 0);
            messageLabel.BackColor = isUser ? Color.LightBlue : Color.LightGray;
            messageLabel.ForeColor = Color.Black;
            messagePanel.Margin = new Padding(5);

            // Time for Chats
            Label timeLabel = new Label();
            timeLabel.Text = DateTime.Now.ToString("HH:mm");
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Arial", 8, FontStyle.Italic);
            timeLabel.ForeColor = Color.Gray;

            string iconPath = isUser ? @"Images\user_icon.png" : @"Images\ai_icon.png";
            PictureBox icon = new PictureBox();
            icon.Size = new Size(30, 30);
            icon.SizeMode = PictureBoxSizeMode.StretchImage;
            icon.Image = Image.FromFile(iconPath);
            icon.Margin = new Padding(5);

            // Align for Messages
            if (isUser)
            {
                icon.Location = new Point(messagePanel.Width - 40, 10); // Place icon on the right
                messagePanel.Controls.Add(icon);
                messageLabel.Location = new Point(icon.Left - 10 - messageLabel.PreferredWidth, 10);
                messagePanel.Controls.Add(messageLabel);
                timeLabel.Location = new Point(icon.Left - timeLabel.PreferredWidth, icon.Bottom - 5); // Place time below the bubble
                messagePanel.Controls.Add(timeLabel);
            }
            else
            {
                icon.Location = new Point(5, 5); // Place icon on the left
                messagePanel.Controls.Add(icon);
                messageLabel.Location = new Point(icon.Right + 5, 5); // Place bubble next to icon
                messagePanel.Controls.Add(messageLabel);
                timeLabel.Location = new Point(messageLabel.Left, messageLabel.Bottom + 5); // Place time below the bubble
                messagePanel.Controls.Add(timeLabel);
            }

            chatPanel.Controls.Add(messagePanel);
            chatPanel.ScrollControlIntoView(messagePanel);
        }

        private async void buttonSend_Click(object sender, EventArgs e)
        {
            string userMessage = questionsBox.Text.Trim();
            if (!string.IsNullOrWhiteSpace(userMessage))
            {
                // Show User's Messages
                AddMessage(userMessage, true);

                // Empty input feld
                questionsBox.Clear();

                // Call KI-Answer 
                AI_Assistance assistant = new AI_Assistance();
                string aiResponse = await assistant.GetResponseFromOpenAI(userMessage);

                // Show KI-Answer
                AddMessage(aiResponse, false);
            }
        }

        private Dictionary<string, List<(string Text, bool IsFromAI, DateTime Timestamp)>> chatHistoryStorage = new();
        private int chatCounter = 1; // To track chat numbers

        private void buttonNewChat_Click(object sender, EventArgs e)
        {
            string currentChatTitle = $"Chat {chatCounter}";

            // Save current chat messages to history storage
            var currentChatMessages = new List<(string Text, bool IsFromAI, DateTime Timestamp)>();
            foreach (Control control in chatPanel.Controls)
            {
                if (control is Panel messagePanel)
                {
                    var messageLabel = messagePanel.Controls.OfType<Label>().FirstOrDefault();
                    string messageText = messageLabel?.Text ?? "";
                    bool isFromAI = messageLabel.BackColor == Color.LightGray;
                    currentChatMessages.Add((messageText, isFromAI, DateTime.Now));
                }
            }

            if (currentChatMessages.Count > 0)
            {
                chatHistoryStorage[currentChatTitle] = currentChatMessages;
            }

            // Add new chat title to history
            chatHistory.Items.Add(currentChatTitle);

            // Clear the chat panel for a new conversation
            chatPanel.Controls.Clear();

            // Increment chat counter for the next chat
            chatCounter++;
        }

        private void chatHistory_DoubleClick(object sender, EventArgs e)
        {
            if (chatHistory.SelectedItem != null)
            {
                string selectedChatTitle = chatHistory.SelectedItem.ToString();

                if (chatHistoryStorage.TryGetValue(selectedChatTitle, out var messages))
                {
                    var chatViewer = new ChatViewerForm(messages);
                    chatViewer.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No messages found for this chat.");
                }
            }
        }
    }
}