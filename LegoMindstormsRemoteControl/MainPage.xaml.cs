using LegoMindstormsRemoteControl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Web.Http;

// Die Elementvorlage "Leere Seite" wird unter https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x407 dokumentiert.

namespace LegoMindstormsRemoteControl
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            using (HttpClient client = new HttpClient()) {
                client.DefaultRequestHeaders.Accept.TryParseAdd("application/json");

                HttpStringContent stringContent = new HttpStringContent("'test'",
        UnicodeEncoding.Utf8,
        "application/json");
                HttpResponseMessage httpResponseMessage1 = await client.PutAsync(new Uri("http://localhost:61671/api/motor/5"), stringContent);
                HttpResponseMessage httpResponseMessage2 = await client.GetAsync(new Uri("http://localhost:61671/api/temperaturesensor"));

            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
