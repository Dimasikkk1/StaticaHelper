using System.Data;

namespace StaticaHelper.Views
{
    internal interface IMainView : IView
    {
        /// <summary>
        /// Состояние подключения к базе Статика 3.
        /// </summary>
        ConnectionState Connection { get; set; }

        /// <summary>
        /// Состояние <see cref="ProgressBar"/>.
        /// </summary>
        bool InProgress { get; set; }

        /// <summary>
        /// Таблица для отображения данных для предварительного просмотра.
        /// </summary>
        DataTable DataTable { get; set; }

        /// <summary>
        /// Индексы выбранных строчек.
        /// </summary>
        IEnumerable<int> SelectedRows { get; set; }

        /// <summary>
        /// Общее количество отображаемых записей в таблице данных.
        /// </summary>
        int RecordsCount { get; set; }

        /// <summary>
        /// Начальная дата для запроса записей из базы Статика 3.
        /// </summary>
        DateTime From { get; set; }

        /// <summary>
        /// Конечная дата для запроса записей из базы Статика 3.
        /// </summary>
        DateTime To { get; set; }

        /// <summary>
        /// Автоматическое сохранение выгруженных данных и открытие Excel
        /// </summary>
        bool AutoSaveAndOpen { get; set; }

        /// <summary>
        /// Сеттер дат "С" и "По" в строку состояния.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        void SetFromAndToDates(DateTime? from, DateTime? to);

        event EventHandler ShowSettingsForm;
        event EventHandler ShowAboutForm;
        event EventHandler UpdateDataTable;
        event EventHandler DownloadAll;
        event EventHandler DownloadSelected;
        event EventHandler GetYesterday;
        event EventHandler GetThreeDays;
        event EventHandler GetAll;
    }
}
