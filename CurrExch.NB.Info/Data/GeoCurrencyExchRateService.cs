using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace CurrExch.NB.Info.Data
{
    public class GeoCurrencyExchRateService : XmlCurrencyExchRateService<GeoCurrencyExchRate>
    {
        // Номер первой строки в табличной части
        int firstRowNum;
        public void CalcExchRateListByDate(DateTime requestDate)
        {
            RequestDate = requestDate;

            var wb = NPOI.SS.UserModel.WorkbookFactory.Create( GetStreamFromUrl());
            var ws = wb.GetSheetAt(0);
            int RequestedRowNo = 0;

            var rowEnumerator = ws.GetRowEnumerator();
            while (rowEnumerator.MoveNext())
            {
                var row = (NPOI.SS.UserModel.IRow)rowEnumerator.Current;
                // RowNum идут с нуля
                if (row.RowNum < firstRowNum)
                    continue;
                // CellNum идут с нуля
                var cell = row.GetCell(0);

                if (cell.CellType == CellType.Numeric)
                {
                    var cellValue = cell.GetDateTimeValue();
                    if (cellValue > RequestDate)
                        break;
                    RequestedRowNo = row.RowNum;
                    RateDate = cellValue;
                }
                else
                {
                    break;
                }
            }

            if (RequestedRowNo == 0) throw new Exception($"Для даты {RequestDate} не удалось найти запись в файле от НБ Грузии!");

            // calc column count
            var requestedRow = ws.GetRow(RequestedRowNo);
            var columnCount = requestedRow.LastCellNum;

            // цикл по колонкам
            ExchRates = new List<GeoCurrencyExchRate>();
            for (int columnNo = 1; columnNo < columnCount; columnNo++)
            {
                int nominal = 0;
                var nominalCell = ws.GetRow(firstRowNum - 2).GetCell(columnNo);
                if (nominalCell is null)
                    continue;

                if (nominalCell.CellType == CellType.Numeric)
                    nominal = (int)nominalCell.NumericCellValue;
                else
                    nominal = Int32.Parse(nominalCell.StringCellValue);

                string rate = "";
                var rateCell = ws.GetRow(RequestedRowNo).GetCell(columnNo);
                if (rateCell is null)
                    continue;

                if (rateCell.CellType == CellType.Numeric)
                    rate = rateCell.NumericCellValue.ToString();
                else
                    rate = rateCell.StringCellValue;

                if (String.IsNullOrEmpty(rate))
                    continue;

                ExchRates.Add(new GeoCurrencyExchRate
                {
                    IsoCode = ws.GetRow(firstRowNum - 1).GetCell(columnNo).StringCellValue,
                    Name = ws.GetRow(firstRowNum - 3).GetCell(columnNo).StringCellValue,
                    Rate = rate,
                    Nominal = nominal
                });
            }

            wb.Close();

            AlreadyLaunched = true;
        }
        protected override string GetDownloadUrl()
        {
            if (RequestDate.Year == DateTime.UtcNow.Year)
            {
                firstRowNum = 5;
                return $"https://www.nbg.gov.ge/uploads/exchangeratesunglisurad/official_daily_exchange_rateseng.xlsx";
            }
            else
            if (RequestDate.Year > 2000)
            {
                firstRowNum = 6;
                return "https://www.nbg.gov.ge/uploads/exchangeratesunglisurad/exratesyearseng.xlsx";
            }
            else
                throw new Exception($"Дата курса должна быть не ранее 2001 года!");
        }
    }
}
