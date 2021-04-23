using NoticeMyCar.Account.Model;
using System;

namespace NoticeMyCar.Account.View
{
    public interface IData
    {
        void Data(IModelA data);
    }

    public interface IViewA : IData
    {
        event EventHandler profile;
    }
}