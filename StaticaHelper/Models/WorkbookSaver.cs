using ClosedXML.Excel;
using StaticaHelper.Extensions;
using System.Data;
using System.Diagnostics;

namespace StaticaHelper.Models
{
    internal class WorkbookSaver
    {
        private const string JournalFolderName = "_Автомобильные весы";

        public async Task SaveAsync(IEnumerable<Record> records, DateTime? from, DateTime? to, bool saveToDocumentsAndOpen = true)
        {
            if (records == null || records.Count() == 0)
                return;

            string fileName = (to?.Date - from?.Date)?.Days == 0 ? $"Журнал {from?.ToShortDateString()}.xlsx" : $"Журнал {from?.ToShortDateString()} - {to?.ToShortDateString()}.xlsx";
            string fullFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), JournalFolderName, fileName);

            if (!saveToDocumentsAndOpen)
            {
                using var dialog = new SaveFileDialog { Filter = "Таблица Excel|*.xlsx", DefaultExt = ".xlsx" };

                if (dialog.ShowDialog() != DialogResult.OK)
                    return;

                fullFileName = dialog.FileName;
            }

            var workbook = new XLWorkbook();
            var sheet = workbook.AddWorksheet(await records.ToDataTableAsync(), "Лист1");
            var table = sheet.Table(0);

            table.Theme = XLTableTheme.TableStyleLight9;

            await Task.Run(() => sheet.Columns().AdjustToContents());

            await Task.Run(() => workbook.SaveAs(fullFileName));

            if (saveToDocumentsAndOpen)
                Process.Start(new ProcessStartInfo(fullFileName)
                {
                    UseShellExecute = true
                });
        }

        public void Save(DataTable dataTable, string filePath)
        {
            var workbook = new XLWorkbook();
            var sheet = workbook.AddWorksheet(dataTable, "Лист1");
            var table = sheet.Table(0);

            table.Theme = XLTableTheme.TableStyleLight9;

            sheet.Columns().AdjustToContents();

            workbook.SaveAs(filePath);
        }
    }
}
