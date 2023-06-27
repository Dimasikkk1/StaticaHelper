using LightInject;
using StaticaHelper.Views;

namespace StaticaHelper
{
    /// <summary>
    /// Менеджер зависимостей для окон и презентeров.<br/>
    /// Код частично взят с хабра:
    /// <see href="https://habr.com/ru/post/502358/"/>
    /// </summary>
    internal class ApplicationController
    {
        private readonly ServiceContainer _container;

        /// <summary>
        /// Главная форма <see cref="MainForm"/>.
        /// </summary>
        public IMainView MainView { get; }

        public ApplicationController(ServiceContainer container)
        {
            _container = container;
            _container.RegisterInstance(this);

            MainView = _container.GetInstance<IMainView>();
        }

        public void Run<TPresenter>() where TPresenter : class, IPresenter
        {
            var presenter = _container.GetInstance<TPresenter>() ?? throw new NotImplementedException();

            presenter.Run();
        }

        public void Run<TPresenter, TParentView>() where TPresenter : class, IPresenter where TParentView : class, IView
        {
            var presenter = _container.GetInstance<TPresenter>() ?? throw new NotImplementedException();
            var view = _container.GetInstance<TParentView>() ?? throw new NotImplementedException();

            presenter.Run(view);
        }

        public DialogResult RunDialog<TPresenter>() where TPresenter : class, IPresenter => RunDialog<TPresenter, IMainView>();

        public DialogResult RunDialog<TPresenter, TParentView>() where TPresenter : class, IPresenter where TParentView : class, IView
        {
            var presenter = _container.GetInstance<TPresenter>() ?? throw new NotImplementedException();
            var view = _container.GetInstance<TParentView>() ?? throw new NotImplementedException();

            return presenter.RunDialog(view);
        }
    }
}
