using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using T1907ACsharp.Models;
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

namespace T1907ACsharp.Layout
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RightLayout : Page
    {
        private readonly string stringUrl = String.Format("https://foodgroup.herokuapp.com/api/today-special");
        public RightLayout()
        {
            this.InitializeComponent();
            GetMenu();
        }
        public async void GetMenu()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(stringUrl);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                var image = JsonConvert.DeserializeObject<DataImagesFood>(stringContent);
                gvFood.ItemsSource = image.data;
            }
        }
    }
}
