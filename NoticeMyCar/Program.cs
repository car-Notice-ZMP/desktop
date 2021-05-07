using Autofac;
using NoticeMyCar.Login.View;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace NoticeMyCar
{
    static class Program
    {
        static IContainer _container;

        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(executingAssembly)
                .AsSelf()
                .AsImplementedInterfaces();

            _container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(_container.Resolve<ViewL>());
        }
    }
}
