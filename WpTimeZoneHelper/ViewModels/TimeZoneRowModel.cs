using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpTimeZoneHelper.ViewModels
{
    public class TimeZoneRowModel
    {
        public TimeZoneRowModel()
        {
            this.Items = new List<TimeZoneItemModel>();
        }

        public DateTime RowKey { get; set; }

        public List<TimeZoneItemModel> Items { get; set; }
    }
}
