using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using Programmierprojekt.Übersicht;
using Programmierprojekt.Homepage;
using Programmierprojekt.Managers_Menus.FilesOfCode;
using Programmierprojekt.DiagramManagement;

namespace Programmierprojekt.Datenbank
{
    public static class FormManager // Developer: Ugur Bektas; Translator: Languagemodel-Chat-GPT
    {

        /* This class ensures that only a single instance of each form is created and reused (singleton pattern).
         * A static class to manage instances of various forms and share application-wide data.
         * I created this class to ensure that only a single instance of each form exists, as failing to enforce this can result in faulty closing logic.
         */
        public static ProjectMenu ProjectMenuInstance { get; set; }
        public static SubFormProject SubProjectMenuInstance { get; set; }
        public static SubFormGroup SubFormGroupInstance { get; set; }   
        public static GroupMenu GroupMenuInstance { get; set; }
        public static LogIn LogInInstance { get; set; }
        public static AccountMenu AccountMenuInstance { get; set; }
        public static TimeTableForm TimeTableFormInstance { get; set; }
        public static StepsOverviewForm StepsOverviewFormInstance { get; set; }
        public static AssistanceForm AssistanceFormInstance { get; set; }
        public static TopicForm TopicFormInstance { get; set; }
        public static TechnischeSpezifikationenDiagramme TechnischeSpezifikationenDiagrammeInstance { get; set; }
        public static HomepageForm HomepageFormInstance { get; set; }
        public static UploadedCodeMenu UploadedCodeMenuInstance { get; set; }
        public static string CurrentGroupName { get; set; }
        public static string CurrentProjectName { get; set; }
        public static readonly IConfiguration Configuration;

        public static System.Windows.Forms.Timer checkFormsTimer = new System.Windows.Forms.Timer();

        //Setting a Timer to check in intervals if all forms are hidde
        public static void StartFormCheck()
        {
            checkFormsTimer.Interval = 500; 
            checkFormsTimer.Tick += (s, e) => CheckAndCloseApplication();
            checkFormsTimer.Start();
        }
        //Checks if all Forms are hidden. Exits the Application if its True
        public static void CheckAndCloseApplication()
        {
            bool allFormsHidden = true;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Visible) 
                {
                    allFormsHidden = false;
                    break;
                }
            }

            // Exit the Application if all Forms are hidden
            if (allFormsHidden)
            {
                Application.Exit();
            }
        }

        //Closes all Forms 
        public static void CloseAllForms()
        {
            FormManager.LogInInstance = new LogIn();
            FormManager.LogInInstance.Show();
            List<Form> forms = new List<Form>
            {
                ProjectMenuInstance, 
                SubProjectMenuInstance, 
                SubFormGroupInstance, 
                GroupMenuInstance,
                LogInInstance, 
                AccountMenuInstance, 
                TimeTableFormInstance, 
                StepsOverviewFormInstance,
                AssistanceFormInstance, 
                TopicFormInstance, 
                HomepageFormInstance,
                UploadedCodeMenuInstance
            };

            foreach (var form in forms)
            {
                if (form != null && !form.IsDisposed)
                {
                    form.Close();
                    form.Dispose();
                }
            }
            ProjectMenuInstance = null;
            SubProjectMenuInstance = null;
            SubFormGroupInstance = null;
            GroupMenuInstance = null;
            LogInInstance = null;
            AccountMenuInstance = null;
            TimeTableFormInstance = null;
            StepsOverviewFormInstance = null;
            AssistanceFormInstance = null;
            TopicFormInstance = null;
            HomepageFormInstance = null;
            UploadedCodeMenuInstance = null;
        }


     /*   public FormManager() 
        {
        
        }

        public static int GetGroupId()
        {
            string groupName = FormManager.CurrentGroupName;
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            string selectQuery = "SELECT groupId FROM [Groups] WHERE groupName = @groupName";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand selectCmd = new SqlCommand(selectQuery, conn))
                    {
                        selectCmd.Parameters.AddWithValue("@groupName", groupName);
                        object result = selectCmd.ExecuteScalar();
                        int groupId = (int)result;
                        return groupId;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fehler: {ex.Message}");
                    return -1;
                }
            }
        }*/ //Tried to use a static method to get GroupId. Ensures for cleaner code.
    }

}
