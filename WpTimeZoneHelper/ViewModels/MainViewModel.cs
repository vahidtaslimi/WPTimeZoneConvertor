namespace WpTimeZoneHelper.ViewModels
{
    #region

    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;

    using WpTimeZoneHelper.Resources;

    #endregion

    public class MainViewModel : INotifyPropertyChanged
    {
        #region Fields

        private List<ItemGroupList<ItemViewModel>> _groupedFormsListCategory;

        private string _sampleProperty = "Sample Runtime Property Value";

        #endregion

        #region Constructors and Destructors

        public MainViewModel()
        {
            // this.Items = new ObservableCollection<ItemViewModel>();
            this.Items = new ObservableCollection<ItemViewModel>();
            this.GrouppedItems = new ObservableCollection<ItemGroupList<ItemViewModel>>();
        }

        #endregion

        #region Public Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Public Properties

        public ObservableCollection<ItemGroupList<ItemViewModel>> GrouppedItems { get; private set; }

        public bool IsDataLoaded { get; private set; }

        /// <summary>
        ///     A collection for ItemViewModel objects.
        /// </summary>
        public ObservableCollection<ItemViewModel> Items { get; private set; }

        /// <summary>
        ///     Sample property that returns a localized string
        /// </summary>
        public string LocalizedSampleProperty
        {
            get
            {
                return AppResources.SampleProperty;
            }
        }

        /// <summary>
        ///     Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return this._sampleProperty;
            }

            set
            {
                if (value != this._sampleProperty)
                {
                    this._sampleProperty = value;
                    this.NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            this.GrouppedItems.Add(new ItemGroupList<ItemViewModel>("Group 1"));
            this.GrouppedItems.Add(new ItemGroupList<ItemViewModel>("Group 2"));
            this.GrouppedItems.Add(new ItemGroupList<ItemViewModel>("Group 3"));
            this.GrouppedItems.Add(new ItemGroupList<ItemViewModel>("Group 4"));
            this.GrouppedItems.Add(new ItemGroupList<ItemViewModel>("Group 5"));
            this.GrouppedItems.Add(new ItemGroupList<ItemViewModel>("Group 6"));

            // Sample data; replace with real data
            this.Items.Add(
                new ItemViewModel()
                    {
                        LineOne = "runtime one",
                        LineTwo = "Maecenas praesent accumsan bibendum",
                        LineThree =
                            "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"
                    });
            this.Items.Add(
                new ItemViewModel()
                    {
                        LineOne = "runtime two",
                        LineTwo = "Dictumst eleifend facilisi faucibus",
                        LineThree =
                            "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus"
                    });
            this.Items.Add(
                new ItemViewModel()
                    {
                        LineOne = "runtime three",
                        LineTwo = "Habitant inceptos interdum lobortis",
                        LineThree =
                            "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent"
                    });
            this.Items.Add(
                new ItemViewModel()
                    {
                        LineOne = "runtime four",
                        LineTwo = "Nascetur pharetra placerat pulvinar",
                        LineThree =
                            "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos"
                    });
            this.Items.Add(
                new ItemViewModel()
                    {
                        LineOne = "runtime five",
                        LineTwo = "Maecenas praesent accumsan bibendum",
                        LineThree =
                            "Maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur"
                    });
            this.Items.Add(
                new ItemViewModel()
                    {
                        LineOne = "runtime six",
                        LineTwo = "Dictumst eleifend facilisi faucibus",
                        LineThree =
                            "Pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent"
                    });
            this.Items.Add(
                new ItemViewModel()
                    {
                        LineOne = "runtime seven",
                        LineTwo = "Habitant inceptos interdum lobortis",
                        LineThree =
                            "Accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat"
                    });
            this.Items.Add(
                new ItemViewModel()
                    {
                        LineOne = "runtime eight",
                        LineTwo = "Nascetur pharetra placerat pulvinar",
                        LineThree =
                            "Pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum"
                    });
            this.Items.Add(
                new ItemViewModel()
                    {
                        LineOne = "runtime nine",
                        LineTwo = "Maecenas praesent accumsan bibendum",
                        LineThree =
                            "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"
                    });
            this.Items.Add(
                new ItemViewModel()
                    {
                        LineOne = "runtime ten",
                        LineTwo = "Dictumst eleifend facilisi faucibus",
                        LineThree =
                            "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus"
                    });
            this.Items.Add(
                new ItemViewModel()
                    {
                        LineOne = "runtime eleven",
                        LineTwo = "Habitant inceptos interdum lobortis",
                        LineThree =
                            "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent"
                    });
            this.Items.Add(
                new ItemViewModel()
                    {
                        LineOne = "runtime twelve",
                        LineTwo = "Nascetur pharetra placerat pulvinar",
                        LineThree =
                            "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos"
                    });
            this.Items.Add(
                new ItemViewModel()
                    {
                        LineOne = "runtime thirteen",
                        LineTwo = "Maecenas praesent accumsan bibendum",
                        LineThree =
                            "Maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur"
                    });
            this.Items.Add(
                new ItemViewModel()
                    {
                        LineOne = "runtime fourteen",
                        LineTwo = "Dictumst eleifend facilisi faucibus",
                        LineThree =
                            "Pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent"
                    });
            this.Items.Add(
                new ItemViewModel()
                    {
                        LineOne = "runtime fifteen",
                        LineTwo = "Habitant inceptos interdum lobortis",
                        LineThree =
                            "Accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat"
                    });
            this.Items.Add(
                new ItemViewModel()
                    {
                        LineOne = "runtime sixteen",
                        LineTwo = "Nascetur pharetra placerat pulvinar",
                        LineThree =
                            "Pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum"
                    });

            int groupNumber = 0;
            for (int i = 0; i < this.Items.Count; i++)
            {
                this.GrouppedItems[groupNumber].Add(this.Items[i]);
                if (i % 3 == 0)
                {
                    groupNumber++;
                }
            }

            this.IsDataLoaded = true;
        }

        #endregion

        #region Methods

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}