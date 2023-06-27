namespace StaticaHelper
{
    internal abstract class Presenter<TView> : IPresenter where TView : class, IView
    {
        protected ApplicationController ApplicationController { get; private set; }
        protected TView View { get; private set; }

        public Presenter(ApplicationController applicationController, TView view)
        {
            ApplicationController = applicationController;
            View = view;
        }

        public virtual void Run() => View.Show();

        public virtual void Run(IView parentView)
        {
            View.Show(parentView as Form ?? throw new ArgumentException());

            View.StartPosition = FormStartPosition.Manual;
            View.Location = new Point(parentView.Location.X + (parentView.Size.Width - View.Size.Width) / 2, parentView.Location.Y + (parentView.Size.Height - View.Size.Height) / 2);
        }

        public virtual DialogResult RunDialog(IView parentView) => View.ShowDialog(parentView as Form ?? throw new ArgumentException());
    }
}
