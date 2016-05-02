using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using AdeptlyAdaptiveChallenge.Models;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AdeptlyAdaptiveChallenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<NewsItems> NewsItem;

        private static ObservableCollection<NewsItems> categorySelector(NewsItems.CategoryEnum selecetedCategory)
        {
            return new ObservableCollection<NewsItems>(NewsItemManager.GetNewsItems()
                .Where(p => p.Category == selecetedCategory)
                .ToList());
        }

        public MainPage()
        {
            this.InitializeComponent();
            NewsItem = NewsItemManager.GetNewsItems();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MenuView.IsPaneOpen = !MenuView.IsPaneOpen;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FinancialLV.IsSelected)
            {
                NewsItem = categorySelector(NewsItems.CategoryEnum.Financial);
                CategoryLabel.Text = "Financial";
            }
            else if (FoodLV.IsSelected)
            {
                NewsItem = categorySelector(NewsItems.CategoryEnum.Food);
                CategoryLabel.Text = "Food";
            }
            // Bindings.Update(); // It works, but it's not the proper way.
        }
    }
}
