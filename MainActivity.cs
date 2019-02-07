using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.OS;
using Xamarin;
using Android.Content;
//using Android.Widget;
using Android.Support.V7.Widget;


namespace Xamarin.Droid
{
    [Activity(Label = "Xamarin", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            SetContentView(Resource.Layout.Main);

           

                TabLayoutResource = Resource.Layout.Tabbar;
                var ToolbarResource = FindViewById<Toolbar>(Resource.Id.toolbar);
                SetSupportActionBar(ToolbarResource);
                ToolbarResource.Title = "Xamarin Manager";

                base.OnCreate(savedInstanceState);
                global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
                LoadApplication(new App());
         
           


        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            this.MenuInflater.Inflate(Resource.Menu.top_menu, menu);

            return base.OnCreateOptionsMenu(menu);
        }

        
    }
}