using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Programmierprojekt.Datenbank;
using System.Numerics;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection;
using Programmierprojekt.Homepage;

namespace Programmierprojekt.Managers_Menus.FilesOfCode
{
    public partial class UploadedCodeMenu : Form //Assignee: Ugur Bektas; Developer of GUI and  functionality: Ugur Bektas; Translator: Languagemodel-Chat-GPT
    {
        private readonly IConfiguration Configuration;

        public UploadedCodeMenu()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen; // Center window
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            Configuration = builder.Build();
            this.Activated += (s, e) => LoadUploadedFiles();
        }
        /* Helper: Chat-GPT Prompt: "Wie lade ich eine Datei hoch"
         * Based on helped Output i adjusted it 
         */
        private void LoadUploadedFiles()
        {
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            filesListViewBox.Items.Clear();

            string query = @"SELECT ucf.fileIDUploadedCodeFiles,  ucf.fileNameUploadedCodeFiles,  ucf.uploadedDate,  u.username AS uploadBy  FROM UploadedCodeFiles ucf INNER JOIN [User] u ON ucf.userId = u.userId INNER JOIN UserGroups ug ON u.userId = ug.userId WHERE ug.groupId IN (SELECT groupId FROM UserGroups WHERE userId = @userId);";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", UserSession.Instance.UserId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string fileId = reader["fileIDUploadedCodeFiles"].ToString();
                                string fileName = reader["fileNameUploadedCodeFiles"].ToString();
                                string uploadDate = Convert.ToDateTime(reader["uploadedDate"]).ToString("dd/MM/yyyy HH:mm");
                                string uploadedBy = reader["uploadBy"].ToString();

                                ListViewItem item = new ListViewItem(uploadedBy);
                                item.SubItems.Add(fileName);
                                item.SubItems.Add("N/A"); //Later File Size
                                item.SubItems.Add(uploadDate);
                                item.Tag = fileId;

                                filesListViewBox.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Laden der Dateien: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Code from CHAT-GPT; Prompt how to convert into bigint,
        /*  private string FormatFileSize(long bytes)
          {
              if (bytes < 1024) return $"{bytes} Bytes";
              if (bytes < 1024 * 1024) return $"{bytes / 1024.0:F2} KB";
              if (bytes < 1024 * 1024 * 1024) return $"{bytes / (1024.0 * 1024.0):F2} MB";
              return $"{bytes / (1024.0 * 1024.0 * 1024.0):F2} GB";
          }*/

        private void uploadFileToListViewBox_Click(object sender, EventArgs e)
        {
            string connectionString = Configuration.GetConnectionString("DefaultConnection");

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "Alle Dateien (*.*)|*.*";
                openFileDialog.Title = "Datei zum Hochladen auswählen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(filePath);
                    byte[] fileData = File.ReadAllBytes(filePath);
                    /*   FileInfo fileInfo = new FileInfo(filePath);
                         long fileSize = fileInfo.Length;*/
                    int userId = UserSession.Instance.UserId;

                    string query = "INSERT INTO [UploadedCodeFiles] (fileNameUploadedCodeFiles, fileDataUploadedCodeFiles, userId, uploadedDate) VALUES (@fileName, @fileData, @userId, @uploadedDate)";


                    try
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@fileName", fileName);
                                cmd.Parameters.AddWithValue("@fileData", fileData);
                                cmd.Parameters.AddWithValue("@uploadedDate", DateTime.Now);
                                cmd.Parameters.AddWithValue("@userId", userId);
                                //       cmd.Parameters.AddWithValue("@fileSize", fileSize);
                                int count = cmd.ExecuteNonQuery();
                                if (count == 1)
                                {
                                    MessageBox.Show("Datei erfolgreich hochgeladen!", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Fehler beim Hochladen: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void downloadFileToDesktop_Click(object sender, EventArgs e)
        {
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            if (filesListViewBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte eine Datei zum Herunterladen auswählen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int fileId = Convert.ToInt32(filesListViewBox.SelectedItems[0].Tag);

            string query = "SELECT fileNameUploadedCodeFiles, fileDataUploadedCodeFiles FROM UploadedCodeFiles WHERE fileIDUploadedCodeFiles = @fileId";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fileId", fileId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string fileName = reader.GetString(0);
                                byte[] fileData = (byte[])reader[1];

                                string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
                                File.WriteAllBytes(savePath, fileData);

                                MessageBox.Show($"Datei gespeichert: {savePath}", "Download abgeschlossen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Herunterladen: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void removeFile_Click(object sender, EventArgs e)
        {
            string connectionString = Configuration.GetConnectionString("DefaultConnection");

            if (filesListViewBox.SelectedItems.Count == 0)
            {
                MessageBox.Show("Bitte eine Datei zum Löschen auswählen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = filesListViewBox.SelectedItems[0];
            int fileId = Convert.ToInt32(filesListViewBox.SelectedItems[0].Tag);

            string query = "DELETE FROM UploadedCodeFiles WHERE fileIDUploadedCodeFiles = @fileId";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fileId", fileId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            filesListViewBox.Items.Remove(selectedItem);

                        }
                        else
                        {
                            MessageBox.Show("Datei nicht gefunden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fehler beim Löschen: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void lblHomepage_Click(object sender, EventArgs e)
        {
            // Close
            Form currentForm = this.FindForm(); // Ensures where Topbar is located at
            if (currentForm != null)
            {
                currentForm.Hide(); // With Hide, because issue with closing whole program

                // Open
                if (FormManager.HomepageFormInstance == null || FormManager.HomepageFormInstance.IsDisposed)
                {
                    FormManager.HomepageFormInstance = new HomepageForm();

                }  // Checks if an  ProjectMenuInstance is selected and exists then redirects the user appropriately.
                FormManager.HomepageFormInstance.Show();
            }
        }

        private void lblHomepage_MouseEnter(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Underline | FontStyle.Italic);
            }
        }

        private void lblHomepage_MouseLeave(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Italic);
            }
        }

        private void lblProjekte_Click(object sender, EventArgs e)
        {
            // Close
            Form currentForm = this.FindForm(); // Ensures where Topbar is located at
            if (currentForm != null)
            {
                currentForm.Hide(); // With Hide, because issue with closing whole program

                // Open
                if (FormManager.ProjectMenuInstance == null || FormManager.ProjectMenuInstance.IsDisposed)
                {
                    FormManager.ProjectMenuInstance = new ProjectMenu();

                }  // Checks if an  ProjectMenuInstance is selected and exists then redirects the user appropriately.
                FormManager.ProjectMenuInstance.Show();
            }
        }

        private void lblProjekte_MouseEnter(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Underline | FontStyle.Italic);
            }
        }

        private void lblProjekte_MouseLeave(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Italic);
            }
        }
        private void lblCodeOverview_MouseEnter(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Underline | FontStyle.Italic);
            }
        }

        private void lblCodeOverview_MouseLeave(object sender, EventArgs e)
        {
            Label stepLabel = sender as Label;
            if (stepLabel != null)
            {
                stepLabel.Font = new Font(stepLabel.Font, FontStyle.Italic);
            }
        }
    }
}
