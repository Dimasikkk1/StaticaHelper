using StaticaHelper.Properties;
using StaticaHelper.Views;

namespace StaticaHelper.Presenters
{
    internal class SettingsPresenter : Presenter<ISettingsView>
    {
        public SettingsPresenter(ApplicationController applicationController, ISettingsView view) : base(applicationController, view)
        {
            view.LoadForm += OnLoadForm;
            view.CloseForm += OnCloseForm;
        }

        private void OnLoadForm(object? sender, EventArgs e)
        {
            View.IP = Settings.Default.Host;
            View.Port = Settings.Default.Port;
            View.Username = Settings.Default.Username;
            View.Password = Settings.Default.Password;
            View.DataBase = Settings.Default.Database;
        }

        private void OnCloseForm(object? sender, EventArgs e)
        {
            Settings.Default.Host = View.IP;
            Settings.Default.Port = View.Port;
            Settings.Default.Username = View.Username;
            Settings.Default.Password = View.Password;
            Settings.Default.Database = View.DataBase;
            Settings.Default.Save();
        }
    }
}
