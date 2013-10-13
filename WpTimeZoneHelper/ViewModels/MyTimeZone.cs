using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpTimeZoneHelper.ViewModels
{
    public class MyTimeZone
    {
        public string Id { get; set; }

        public string BaseUtcOffset { get; set; }

        public string DisplayName { get; set; }

        public string StandardName { get; set; }

        public bool SupportsDaylightSavingTime { get; set; }
    }
}
