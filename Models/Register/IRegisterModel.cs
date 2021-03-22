namespace Models.Register
{
    public interface IRegisterModel
    {
        string email { get; set; }
        string name { get; set; }
        string password { get; set; }
        string password_confirmation { get; set; }
    }
}