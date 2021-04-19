using Autofac;
using Autofac.Builder;
using Autofac.Core;
using NoticeMyCar.Login.Presenter;
using NoticeMyCar.Login.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Module = Autofac.Module;

namespace NoticeMyCar
{
    static class Program
    {
        static IContainer _container;
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
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
