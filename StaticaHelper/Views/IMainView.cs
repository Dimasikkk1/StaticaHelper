using System.Data;

namespace StaticaHelper.Views
{
    internal interface IMainView : IView
    {
        /// <summary>
        /// Свойство состояния подключения к базе Статика 3.
        /// </summary>
        ConnectionState Connection { get; set; }

        /// <summary>
        /// Свойство управления состоянием <see cref="ProgressBar"/>.
        /// </summary>
        bool InProgress { get; set; }

        /// <summary>
        /// Свойство таблицы данных для отображения данных для предварительного просмотра.
        /// </summary>
        DataTable DataTable { get; set; }

        /// <summary>
        /// Свойство общее количество отображаемых записей в таблице данных.
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

        event EventHandler ShowSettingsForm;
        event EventHandler ShowAboutForm;
        event EventHandler UpdateDataTable;
        event EventHandler DownloadAll;
        event EventHandler GetYesterday;
        event EventHandler GetThreeDays;
        event EventHandler GetAll;
    }
}
