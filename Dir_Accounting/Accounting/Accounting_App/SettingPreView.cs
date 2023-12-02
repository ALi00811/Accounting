using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting_App
{
    
    public  class SettingPreView
    {
        public List<SetComponent> Component = new List<SetComponent>();
        public SettingPreView()
        {
            for (int i = 0; i < 6; i++)
            {
                Component.Add(new SetComponent { });
            }
        }
    }
    public class SetComponent
    {
        public int Clock { get; set; } = 1;
        public int lblTime { get; set; } = 1;
        public int lblDate { get; set; } = 1;
        public int lblToday { get; set; } = 1;
        public int Image { get; set; } = 1;
        public int Report { get; set; } = 1;
    }

    


}
