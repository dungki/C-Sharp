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
using T1907ACsharp.Models;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T1907ACsharp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static Frame contenFrame;
        private readonly string stringUrl = String.Format("https://foodgroup.herokuapp.com/api/menu");
        public MainPage()
        {
            this.InitializeComponent();
            GetMenu();
        }

        public async void GetMenu()
        {
            HttpClient httpClient = new HttpClient(); //shippner
            var response = await httpClient.GetAsync(stringUrl);
            if(response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                Menu menu = JsonConvert.DeserializeObject<Menu>(stringContent);
                MN.ItemsSource = menu.data;
            }
        }

        private void ScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            contenFrame = MainFrame;
            contenFrame.Navigate(typeof(Layout.RightLayout));
        }
    }
}
