namespace StaticaHelper
{
    internal class BaseForm : Form, IView
    {
        public bool Maximized
        {
            get => WindowState == FormWindowState.Maximized;
            set => WindowState = value ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        public BaseForm()
        {
            Load += (s, e) => LoadForm?.Invoke(default, EventArgs.Empty);
            FormClosing += (s, e) => CloseForm?.Invoke(default, EventArgs.Empty);
        }

        public event EventHandler? LoadForm;
        public event EventHandler? CloseForm;
    }
}
