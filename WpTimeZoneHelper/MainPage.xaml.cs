using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WpTimeZoneHelper.Resources;
using System.Diagnostics;

namespace WpTimeZoneHelper
{
    using System.Windows.Input;

    using WpTimeZoneHelper.ViewModels;

    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = new TimeZoneViewModel();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            
        }

        private void LongListSelector_ItemRealized(object sender, ItemRealizationEventArgs e)
        {
            //if (!_viewModel.IsLoading && resultListBox.ItemsSource != null && resultListBox.ItemsSource.Count >= _offsetKnob)
            //{
            //    if (e.ItemKind == LongListSelectorItemKind.Item)
            //    {
            //        if ((e.Container.Content as TwitterSearchResult).Equals(resultListBox.ItemsSource[resultListBox.ItemsSource.Count - _offsetKnob]))
            //        {
            //            Debug.WriteLine("Searching for {0}", _pageNumber);
            //            _viewModel.LoadPage(_searchTerm, _pageNumber++);
            //        }
            //    }
            //}
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
        private void UIElement_OnTap(object sender, GestureEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (App.ViewModel.GrouppedItems.Count == 0) return;
            App.ViewModel.GrouppedItems.RemoveAt(0);
        }

    }
}