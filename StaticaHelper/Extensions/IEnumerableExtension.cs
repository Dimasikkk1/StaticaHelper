using StaticaHelper.Models;
using System.Data;

namespace StaticaHelper.Extensions
{
    internal static class IEnumerableExtension
    {
        /// <summary>
        /// Асинхронный конвертер списка записей в <see cref="DataTable"/>.
        /// </summary>
        /// <param name="records">Список записей.</param>
        /// <returns>Таблица данных.</returns>
        public static Task<DataTable> ToDataTableAsync(this IEnumerable<Record> records)
        {
            return Task.Run(() =>
            {
                var dataTable = new DataTable();

                dataTable.Columns.Add("Номер документа", typeof(int));
                dataTable.Columns.Add("Дата (брутто)", typeof(string));
                dataTable.Columns.Add("Дата (тара)", typeof(string));
                dataTable.Columns.Add("ТС", typeof(string));
                dataTable.Columns.Add("Брутто", typeof(double));
                dataTable.Columns.Add("Тара", typeof(double));
                dataTable.Columns.Add("Нетто", typeof(double));

                foreach (var record in records)
                    dataTable.Rows.Add(record.ToArray());

                return dataTable;
            });
        }

        /// <summary>
        /// Фильтр элементов коллекции <see cref="IEnumerable{T}"/> по индексам.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="indices"></param>
        /// <returns>Отфильтрованная коллекция.</returns>
        public static IEnumerable<T> GetIndexedItems<T>(this IEnumerable<T> collection, IEnumerable<int> indixes)
        {
            var currentIndex = -1;

            using var collectionEnum = collection.GetEnumerator();

            foreach (int index in indixes)
                while (collectionEnum.MoveNext())
                {
                    currentIndex += 1;

                    if (currentIndex == index)
                    {
                        yield return collectionEnum.Current;

                        break;
                    }
                }
        }
    }
}
