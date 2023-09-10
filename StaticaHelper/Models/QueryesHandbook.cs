using Microsoft.EntityFrameworkCore;
using System.Data;
using ApplicationContext = StaticaDbContext.DbContext;

namespace StaticaHelper.Models
{
    /// <summary>
    /// Справочник запросов к базе Статика 3.
    /// </summary>
    internal class QueryesHandbook
    {
        public ConnectionString ConnectionString { get; set; } = default!;

        /// <summary>
        /// Дата "С" из последнего запроса.
        /// </summary>
        public DateTime? LastFrom { get; private set; }

        /// <summary>
        /// Дата "По" из последнего запроса.
        /// </summary>
        public DateTime? LastTo { get; private set; }

        /// <summary>
        /// Асинхронный запрос на получение записей в заданном диапазоне дат.
        /// </summary>
        /// <param name="from">Начальная дата.</param>
        /// <param name="to">Конечная дата.</param>
        /// <returns>Список записей.</returns>
        public async Task<IEnumerable<Record>> GetRecordsByDateAsync(DateTime from, DateTime to)
        {
            using var dbContext = new ApplicationContext(ConnectionString.ToString());
            
            var records = dbContext.Journals
                .Where(record => record.Finished && from <= record.BruttoDate && record.TareDate <= to)
                .OrderBy(record => record.BruttoDate)
                .Select(record => new Record
                {
                    Number = record.Number,
                    BruttoDate = record.BruttoDate,
                    TareDate = record.TareDate,
                    Car = dbContext.Cars.FirstOrDefault(car => car.Id == record.CarId)!.Name,
                    Brutto = record.Brutto,
                    Tare = record.Tare,
                    Netto = record.Netto
                });

            LastFrom = records.FirstOrDefault()?.BruttoDate;
            LastTo = records.LastOrDefault()?.TareDate;

            return await records.ToListAsync();
        }

        /// <summary>
        /// Асинхронный запрос на получение записей за вчерашний день (с 00:00 часов вчерашнего дня до 00:00 часов сегодняшнего дня).
        /// </summary>
        /// <returns>Список записей.</returns>
        public async Task<IEnumerable<Record>> GetYesterdayRecordsAsync()
        {
            var from = DateTime.Now.Date.AddDays(-1);
            var to = DateTime.Now.Date;

            return await GetRecordsByDateAsync(from, to);
        }

        /// <summary>
        /// Асинхронный запрос на получение записей за последние 3 дня (с 00:00 часов до 00:00 часов сегодняшнего дня).
        /// </summary>
        /// <returns>Список записей.</returns>
        public async Task<IEnumerable<Record>> GetLastThreeDaysRecordsAsync()
        {
            var from = DateTime.Now.Date.AddDays(-3);
            var to = DateTime.Now.Date;

            return await GetRecordsByDateAsync(from, to);
        }

        /// <summary>
        /// Асинхронный запрос на получение записей за всё время.
        /// </summary>
        /// <returns>Список записей.</returns>
        public async Task<IEnumerable<Record>> GetAllRecordsAsync()
        {
            using var dbContext = new ApplicationContext(ConnectionString.ToString());

            var records = dbContext.Journals
                .Where(record => record.Finished)
                .OrderBy(record => record.BruttoDate)
                .Select(record => new Record
                {
                    Number = record.Number,
                    BruttoDate = record.BruttoDate,
                    TareDate = record.TareDate,
                    Car = dbContext.Cars.FirstOrDefault(car => car.Id == record.CarId)!.Name,
                    Brutto = record.Brutto,
                    Tare = record.Tare,
                    Netto = record.Netto
                });

            LastFrom = records.FirstOrDefault()?.BruttoDate;
            LastTo = records.LastOrDefault()?.TareDate;

            return await records.ToListAsync();
        }
    }
}
