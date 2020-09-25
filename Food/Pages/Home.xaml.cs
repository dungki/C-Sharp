using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using T1907ACsharp.Models;
using T1907ACsharp.Services;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T1907ACsharp.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        private ProductServices _productServices = new ProductServices();

        public Home()
        {
            this.InitializeComponent();
            TodaySpecial();
        }

        public async void TodaySpecial()
        {
            ProductList productList = await _productServices.TodaySpecial();
            if (productList != null)
            {
                ProductList.ItemsSource = productList.data;
            }
        }

        private void GridViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Product detail = ProductList.SelectedItem as Product;
            MainPage.mainFrame.Navigate(typeof(ProductDetail), detail);
        }
    }
}
