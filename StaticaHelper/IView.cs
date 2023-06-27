namespace StaticaHelper
{
    internal interface IView
    {
        public FormStartPosition StartPosition { get; set; }
        public Point Location { get; set; }
        public Size Size { get; set; }
        public bool Maximized { get; set; }

        //public int Width { get; set; }
        //public int Height { get; set; }

        public void Show();
        public void Show(IWin32Window win32Window);

        public DialogResult ShowDialog(IWin32Window win32Window);

        public event EventHandler LoadForm;
        public event EventHandler CloseForm;
    }
}
