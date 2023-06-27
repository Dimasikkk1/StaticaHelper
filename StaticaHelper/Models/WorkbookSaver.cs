using ClosedXML.Excel;
using StaticaHelper.Extensions;
using System.Data;

namespace StaticaHelper.Models
{
    internal class WorkbookSaver
    {
        public async Task SaveAsync(IEnumerable<Record> records)
        {
            if (records == null)
                return;

            using var dialog = new SaveFileDialog { Filter = "Таблица Excel|*.xlsx", DefaultExt = ".xlsx" };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            var workbook = new XLWorkbook();
            var sheet = workbook.AddWorksheet(await records.ToDataTableAsync(), "journal");
            var table = sheet.Table(0);

            table.Theme = XLTableTheme.TableStyleLight9;

            await Task.Run(() => sheet.Columns().AdjustToContents());

            await Task.Run(() => workbook.SaveAs(dialog.FileName));
        }

        public void Save(DataTable dataTable, string filePath)
        {
            var workbook = new XLWorkbook();
            var sheet = workbook.AddWorksheet(dataTable, "journal");
            var table = sheet.Table(0);

            table.Theme = XLTableTheme.TableStyleLight9;

            sheet.Columns().AdjustToContents();

            workbook.SaveAs(filePath);
        }
    }
}
