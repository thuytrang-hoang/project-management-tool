namespace Programmierprojekt.Datenbank
{
    internal interface IUserSession // Developer: Ugur Bektas; Translator: Languagemodel-Chat-GPT
    {
        string Username { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }
        int UserId { get; set; }

    }
}
