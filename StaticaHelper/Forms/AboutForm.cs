namespace StaticaHelper.Views
{
    internal partial class AboutForm : BaseForm, IAboutView
    {
        public string Version
        {
            get => labelVersion.Text;
            set => labelVersion.Text = value;
        }

        public AboutForm() : base() => InitializeComponent();
    }
}
