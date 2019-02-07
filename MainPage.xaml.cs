using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.Net;

namespace Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
           
                InitializeComponent();
            var browser = new WebView
            {
                Source = "https://server-nrl.000webhostapp.com/XamarinIndex.html"
            };
           

                Content =  browser;


        }
    }
}
