using PresentationLayer.Presenters;
using PresentationLayer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IUnityContainer UnitiC;

            string _connectionString = "Data Source=" +
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\OO_PocketGourmet_REAL-UnitTest\MVPDB.sqlite;";

            UnitiC = new UnityContainer().RegisterType<IMainView, MainView>(new ContainerControlledLifetimeManager())
                .RegisterType<IMainPresenter, MainPresenter>(new ContainerControlledLifetimeManager())
                .RegisterType<IErrorMessageView, ErrorMessageView>(new ContainerControlledLifetimeManager());




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMainPresenter mainPresenter = UnitiC.Resolve<MainPresenter>();
            IMainView mainView = mainPresenter.GetMainView();

            Application.Run((MainView)mainView);
        }
    }
}
