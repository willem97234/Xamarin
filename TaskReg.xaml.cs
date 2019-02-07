using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Net;

namespace Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskReg : ContentPage
    {
        public TaskReg()
        {
            InitializeComponent();
           /* var nameLayout = new Entry { Text = "Entrez le nom ici..." };
            var DateTime = new DatePicker { };
            var descLayout = new Entry { Text = "Entrez un descriptif ici..." };
            var Button = new Button { Text = "Save" };
            Button.Clicked += async (sender, e) => {
                //var mi = ((MenuItem)sender);
                Task t = new Task("", nameLayout.Text, "Professional", descLayout.Text, DateTime.Date.ToString(), "");
                save(t);

            };*/




            /*var viewLayout = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                Children = { nameLayout, DateTime, descLayout, Button }
            };
            Content = viewLayout;*/
        }

       /* void save(Task t)
        {

            var webClient = new WebClient();
            string Task = JsonConvert.SerializeObject(t);
            webClient.UploadString("https://server-nrl.000webhostapp.com/PostTask.php", Task);
        }*/
    }
}