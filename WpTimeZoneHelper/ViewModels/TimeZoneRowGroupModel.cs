using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpTimeZoneHelper.ViewModels
{
    using System.Collections.ObjectModel;

    public class TimeZoneRowGroupModel : List<TimeZoneRowModel>
    {
        public TimeZoneRowGroupModel(DateTime key)
        {
            this.Key = key;
        }

        public DateTime Key { get; set; }
    }
}
