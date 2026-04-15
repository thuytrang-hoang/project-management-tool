using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmierprojekt.AI.AIFindTopic
{
    public partial class ChatTopicViewerForm : Form
    {
        public ChatTopicViewerForm()
        {
            InitializeComponent();
        }
        public ChatTopicViewerForm(List<(string Text, bool IsUser, DateTime Timestamp)> messages)
        {
            this.Text = "Chat Viewer";
            this.Size = new Size(800, 300);

            ListBox chatListBox = new ListBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 10),
                HorizontalScrollbar = true
            };

            foreach (var (text, isUser, timestamp) in messages)
            {
                string sender = isUser ? "User" : "KI";
                chatListBox.Items.Add($"[{timestamp:HH:mm}] {sender}: {text}");
            }

            this.Controls.Add(chatListBox);
        }
    }
}
