namespace Programmierprojekt.Datenbank
{
    internal class UserSession : IUserSession  // Developer: Ugur Bektas; Translator: Languagemodel-Chat-GPT
    {
        /* Represents a singleton class to manage and store session-specific information for the currently logged-in user.
         * Implements the IUserSession interface, providing properties for the user's details such as Username, UserId, Firstname, and Lastname.
         * Reason is that so only on User can log in on one Device. So no ensures that conflicts do not happen
         */

        private static UserSession _instance;
        private UserSession() { }
        public static UserSession Instance //Singleton
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserSession();
                }
                return _instance;
            }
        }
        public string Username { get; set; }
        public int UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public void ResetUser()
        {
            Username = null;
            UserId = 0;
            Firstname = null;
            Lastname = null;
        }

    }
}
