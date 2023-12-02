using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Accounting_App.Notification
{
    public class SendNotification
    {
        Main form = Application.OpenForms.Cast<Main>().FirstOrDefault();
        public SendNotification(string title,string ContentText)
        {
            form.popupNotifier.TitleText = title;
            form.popupNotifier.ContentText = ContentText;

            form.popupNotifier.Popup();

        }
    }
}
