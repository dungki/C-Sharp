﻿using System;
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
using T1907ACsharp.Models;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using T1907ACsharp.Pages;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T1907ACsharp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private readonly string stringUrl = String.Format("https://foodgroup.herokuapp.com/api/menu");
        public static Frame mainFrame;
        public MainPage()
        {
            this.InitializeComponent();
            GetMenu();
            mainFrame = MainFrame;
            Cart cart = new Cart();
            List<CartItem> cartItems = cart.GetCarts();
            CartNumber.Text = cartItems.Count.ToString();
            CartNumber.Opacity = cartItems.Count > 0 ? 1 : 0;
        }

        public async void GetMenu()
        {
            HttpClient httpClient = new HttpClient();// shippner
            var response = await httpClient.GetAsync(stringUrl);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                Menu menu = JsonConvert.DeserializeObject<Menu>(stringContent);
                MN.ItemsSource = menu.data;
            }
        }

        private void ScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Home));
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem menuItem = MN.SelectedItem as MenuItem;
            MainFrame.Navigate(typeof(Category), menuItem);
            Console.WriteLine(e.ToString());
        }


        private void FontIcon_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Favourite));
        }

        private void Alert_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Home));
        }

        private void Setting_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Carts));
        }
    }
}
