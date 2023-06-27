using StaticaHelper.Views;
using System.Reflection;

namespace StaticaHelper.Presenters
{
    /// <summary>
    /// Презентер <see cref="IAboutView"/> (<see cref="AboutForm"/>).
    /// </summary>
    internal class AboutPresenter : Presenter<IAboutView>, IPresenter
    {
        public AboutPresenter(ApplicationController applicationController, IAboutView view) : base(applicationController, view)
        {
            view.Version = Assembly.GetExecutingAssembly().GetName().Version!.ToString();
        }
    }
}
