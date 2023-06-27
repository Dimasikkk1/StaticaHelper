namespace StaticaHelper.Views
{
    internal interface ISettingsView : IView
    {
        string IP { get; set; }
        string Port { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string DataBase { get; set; }
    }
}
