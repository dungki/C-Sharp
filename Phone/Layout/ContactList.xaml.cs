using Phone.Models;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Phone.Layout
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ContactList : Page
    {
        public ContactList()
        {
            this.InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
             MainPage.contentFrame.Navigate(typeof(AddContact));
        }

        private void GV_Loaded(object sender, RoutedEventArgs e)
        {
            GV.Items.Add(new Mail("abc@gmail", "IT", "dev"));
            GV.Items.Add(new Mail("edf@gmail", "IT", "dev"));
        }
    }
}
