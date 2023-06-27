using LightInject;
using StaticaHelper.Forms;
using StaticaHelper.Presenters;
using StaticaHelper.Views;

namespace StaticaHelper
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();

            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            using var context = new ApplicationContext();
            using var container = new ServiceContainer();

            container.RegisterInstance(context);
            container.RegisterSingleton<IMainView, MainForm>();
            container.RegisterSingleton<MainPresenter>();
            container.Register<IAboutView, AboutForm>();
            container.Register<AboutPresenter>();
            container.Register<ISettingsView, SettingsForm>();
            container.Register<SettingsPresenter>();

            var applicationController = new ApplicationController(container);

            context.MainForm = applicationController.MainView as Form ?? throw new NotImplementedException();

            applicationController.Run<MainPresenter>();
        }
    }
}