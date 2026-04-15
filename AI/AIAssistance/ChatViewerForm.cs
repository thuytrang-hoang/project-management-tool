using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmierprojekt.AI
{
    public partial class ChatViewerForm : Form
    {
        public ChatViewerForm()
        {
            InitializeComponent();
        }
        public ChatViewerForm(List<(string Text, bool IsFromAI, DateTime Timestamp)> messages)
        {
            this.Text = "Chat Viewer";
            this.Size = new Size(800, 300);

            ListBox chatListBox = new ListBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 10),
                HorizontalScrollbar = true
            };

            foreach (var (text, isFromAI, timestamp) in messages)
            {
                string sender = isFromAI ? "KI" : "User";
                chatListBox.Items.Add($"[{timestamp:HH:mm}] {sender}: {text}");
            }

            this.Controls.Add(chatListBox);
        }
    }
}
