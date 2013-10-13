namespace WpTimeZoneHelper.ViewModels
{
    #region

    using System;

    #endregion

    public class TimeZoneItemModel
    {
        #region Public Properties

        public int DayDifference { get; set; }

        public TimeZoneInfo TimeZoneInfo { get; set; }

        public DateTime Value { get; set; }

        #endregion
    }
}