namespace WpTimeZoneHelper.SampleData
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Text;
    using System.IO;
    using System.Windows;
    using System.Xml.Serialization;

    using Windows.Storage;

    using WpTimeZoneHelper.ViewModels;

    public class TimeZonesSampleData
    {
        public List<ItemGroupList<MyTimeZone>> GroupedItems0
        {
            get
            {
                var myTimeZones = this.LoadTimeZones();

                var datasource = ItemGroupList<MyTimeZone>.CreateGroups(
                    myTimeZones,
                    System.Threading.Thread.CurrentThread.CurrentUICulture,
                    (MyTimeZone s) => { return s.BaseUtcOffset; },
                    true);

                return datasource;
                //var groupedPhotos =
                //    from photo in photos
                //    orderby photo.TimeStamp
                //    group photo by photo.TimeStamp.ToString("y") into photosByMonth
                //    select new KeyedList<string, Photo>(photosByMonth);

                //return new List<KeyedList<string, Photo>>(groupedPhotos);
            }
        }

        public List<TimeZoneModel> TimeZones
        {
            get
            {
                var timezones = new List<TimeZoneModel>();

                for (int i = 0; i < 6; i++)
                {
                    timezones.Add(new TimeZoneModel() { Name = "TimeZone" + i.ToString(), ShortName = "tz" + i.ToString() });
                }

                return timezones;
            }
        }
        public ObservableCollection<TimeZoneRowGroupModel> GroupedItems
        {
            get
            {
                var result = new ObservableCollection<TimeZoneRowGroupModel>();
                for (int i = 0; i < 100; i++)
                {
                    var group = new TimeZoneRowGroupModel(DateTime.Now.Date.AddDays(i));
                    result.Add(group);
                    for (int j = 0; j < 7; j++)
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


                return result;
            }
        }

        public List<MyTimeZone> LoadTimeZones()
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
    }
}
