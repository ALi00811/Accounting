using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Stimulsoft.Report;



namespace Accounting_App
{
    public class Print
    {
        public Print(DataGridView dgReport, StiReport stiprint)
        {
            DataTable dtprint = new DataTable();
            dtprint.Columns.Add("Customer");
            dtprint.Columns.Add("Amount");
            dtprint.Columns.Add("Date");
            dtprint.Columns.Add("Description");
            foreach (DataGridViewRow item in dgReport.Rows)
            {
                dtprint.Rows.Add(
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString()
                    );
            }
            stiprint.Load(Application.StartupPath + "/Report.mrt");
            stiprint.RegData("DT", dtprint);
            stiprint.Show();
        }
    }
}
