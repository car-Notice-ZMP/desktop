﻿namespace NoticeMyCar.Registration.Model
{
    public interface IModelR
    {
        string email { get; set; }
        string name { get; set; }
        string password { get; set; }
        string password_confirmation { get; set; }
    }
}