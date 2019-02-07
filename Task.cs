using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamarin
{
    public class Task : ViewCell
    {
        string id { get; set; }
        string name { get; set; }
        string type { get; set; }
        string desc { get; set; }
        string date { get; set; }
        string time { get; set; }

        public Task(string id, string name, string type, string desc, string date, string time)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.desc = desc;
            this.date = date;
            this.time = time;

            var nameLayout = CreateNameLayout(this.name, this.date, this.time);
            var descLayout = CreateDescLayout(this.desc = desc);
            var viewLayout = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                Children = { nameLayout , descLayout }
            };
            View = viewLayout;
        }

       static StackLayout CreateDescLayout(string desc)
        {

            var DescLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontSize = 20
            };
            DescLabel.SetBinding(Label.TextProperty, "Desc");
            DescLabel.Text = desc;



            var DescLayout = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Vertical,
                Children = { DescLabel }
            };

            return DescLayout;
        }

        static StackLayout CreateNameLayout(string name, string date, string time)
        {
            var nameLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
            nameLabel.SetBinding(Label.TextProperty, "Name");
            nameLabel.Text = name;


            var DateLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                FontSize = 24
            };
            DateLabel.SetBinding(Label.TextProperty, "Date");
            DateLabel.Text = "The " + date + " at " + time + ".";

            var nameLayout = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Horizontal,
                Children = { nameLabel, DateLabel }


            };
            return nameLayout;
        }
    }
}
