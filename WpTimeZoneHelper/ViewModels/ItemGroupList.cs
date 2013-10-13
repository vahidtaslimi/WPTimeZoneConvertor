namespace WpTimeZoneHelper.ViewModels
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Globalization;
    using System.Linq;

    using Microsoft.Phone.Globalization;

    public class ItemGroupList<T> : ObservableCollection<T>
    {
        #region Constructors and Destructors

        public ItemGroupList(string key)
        {
            this.Key = key;
        }

        #endregion

        #region Delegates

        public delegate string GetKeyDelegate(T item);

        #endregion

        #region Public Properties

        public string Key { get; private set; }

        #endregion

        #region Public Methods and Operators

        public static List<ItemGroupList<T>> CreateGroups(
            IEnumerable<T> items, CultureInfo ci, GetKeyDelegate getKey, bool sort)
        {
            SortedLocaleGrouping slg = new SortedLocaleGrouping(ci);
            List<ItemGroupList<T>> list = CreateGroups(slg);

            foreach (T item in items)
            {
                int index = 0;
                if (slg.SupportsPhonetics)
                {
                    // check if your database has yomi string for item
                    // if it does not, then do you want to generate Yomi or ask the user for this item.
                    // index = slg.GetGroupIndex(getKey(Yomiof(item)));
                }
                else
                {
                    index = slg.GetGroupIndex(getKey(item));
                }

                if (index >= 0 && index < list.Count)
                {
                    list[index].Add(item);
                }
            }

            if (sort)
            {
                foreach (ItemGroupList<T> group in list)
                {
                    group.ToList().Sort((c0, c1) => { return ci.CompareInfo.Compare(getKey(c0), getKey(c1)); });
                }
            }

            return list;
        }

        #endregion

        #region Methods
        private static List<ItemGroupList<T>> CreateGroups(SortedLocaleGrouping slg)
        {
            List<ItemGroupList<T>> list = new List<ItemGroupList<T>>();

            foreach (string key in slg.GroupDisplayNames)
            {
                list.Add(new ItemGroupList<T>(key));
            }

            return list;
        }

        private void Convert(ObservableCollection<ItemViewModel> source)
        {
            var datasource = ItemGroupList<ItemViewModel>.CreateGroups(
                source,
                System.Threading.Thread.CurrentThread.CurrentUICulture,
                (ItemViewModel s) => { return s.LineOne; },
                true);
        }

        #endregion
    }
}