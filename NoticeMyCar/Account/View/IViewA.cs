using NoticeMyCar.Account.Model;
using System;

namespace NoticeMyCar.Account.View
{
    public interface IDataA
    {
        void Data(IModelA data);
    }

    public interface IViewA : IDataA
    {
        event EventHandler profile;
    }
}