namespace Models.Login
{
    interface ILoginModel
    {
        string email { get; set; }
        string password { get; set; }
    }
}