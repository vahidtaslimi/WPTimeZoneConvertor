namespace WpTimeZoneHelper.ViewModels
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.IO;
    using System.Text;
    using System.Windows;
    using System.Xml.Serialization;

    using Windows.Storage;

    #endregion

    public class TimeZoneViewModel
    {
        public TimeZoneViewModel()
        {
            this.BuildSampleData();
        }
        #region Public Properties

        public ObservableCollection<TimeZoneRowGroupModel> GroupedItems { get; set; }

        public List<TimeZoneModel> TimeZones { get; set; }
        #endregion

        #region Public Methods and Operators

        private void BuildSampleData()
        {
            var result = new ObservableCollection<TimeZoneRowGroupModel>();
            for (int i = 0; i < 100; i++)
            {
                var group = new TimeZoneRowGroupModel(DateTime.Now.Date.AddDays(i));
                result.Add(group);
                for (int j = 0; j < 24; j++)
                {
                    var row = new TimeZoneRowModel();
                    row.RowKey = group.Key.AddHours(j);
                    for (int k = 0; k < 5; k++)
                    {
                        var item = new TimeZoneItemModel();
                        item.DayDifference = 0;
                        item.Value = row.RowKey;
                        row.Items.Add(item);
                    }

                    group.Add(row);
                }
            }

            this.GroupedItems = result;
            var timezones = new List<TimeZoneModel>();
            for (int i = 0; i < 6; i++)
            {
                timezones.Add(new TimeZoneModel() { Name = "TimeZone" + i.ToString(), ShortName = "tz" + i.ToString() });
            }

            this.TimeZones = timezones;
        }

        private List<MyTimeZone> LoadTimeZones()
        {
            List<MyTimeZone> myTimeZones = new List<MyTimeZone>();
            XmlSerializer serializer = new XmlSerializer(myTimeZones.GetType());
            var uri = new Uri("tzs.xml", UriKind.Relative);
            var file = Application.GetResourceStream(uri);


            using (var stream = file.Stream)
            {
                myTimeZones = serializer.Deserialize(stream) as List<MyTimeZone>;
            }

            return myTimeZones;
        }

        private void LoadTimeZonesAsync()
        {
            List<MyTimeZone> myTimeZones = new List<MyTimeZone>();

            myTimeZones = this.LoadTimeZones();

            var datasource = ItemGroupList<MyTimeZone>.CreateGroups(
                myTimeZones,
                System.Threading.Thread.CurrentThread.CurrentUICulture,
                (MyTimeZone s) => { return s.BaseUtcOffset; },
                true);

            // this.GroupedItems = datasource;
        }

        #endregion
    }
}