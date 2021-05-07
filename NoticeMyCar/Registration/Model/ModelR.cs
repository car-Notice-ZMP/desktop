namespace NoticeMyCar.Registration.Model
{
    class ModelR : IModelR
    {
        public string email { get; set; }
        public string password { get; set; }
        public string password_confirmation { get; set; }
        public string name { get; set; }
    }
}
