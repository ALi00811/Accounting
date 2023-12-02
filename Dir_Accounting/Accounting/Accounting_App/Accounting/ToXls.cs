using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_App
{
    public class ToXls
    {
        public ToXls(SaveFileDialog sfd, DataGridView dataGridView, string SheetName)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (OfficeOpenXml.ExcelPackage excelPackage = new OfficeOpenXml.ExcelPackage())
            {

                OfficeOpenXml.ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add(SheetName);
                worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Right;

                for (int i = 2; i <= dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i - 1].Value = dataGridView.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 1; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j].Value = dataGridView.Rows[i].Cells[j].Value;
                    }
                }

                try
                {
                    excelPackage.SaveAs(new FileStream(sfd.FileName, FileMode.Create));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "!!توجه!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
    }
}
