namespace StaticaHelper
{
    internal interface IPresenter
    {
        public void Run();
        public void Run(IView parentView);

        public DialogResult RunDialog(IView parentView);
    }
}
