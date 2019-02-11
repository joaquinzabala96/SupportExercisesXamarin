using Ejercicio3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio3
{
    public partial class MainPage : ContentPage
    {
        List<ListViewTemplate> omg = new List<ListViewTemplate>
            {
            new ListViewTemplate
                {
                Name = "Fantasma",
                    Age = "19",
                    NamePhoto="casper.jpg"
               },
               new ListViewTemplate
               {
                  Name = "Fantasma2",
                    Age = "20",
                    NamePhoto="sylvanas.png"
                },
                new ListViewTemplate
                {
                    Name = "Fantasma3",
                    Age = "21",
                    NamePhoto="DaenerysTargaryen.jpg"
               },
               new ListViewTemplate
               {
                   Name = "Fantasma4",
                    Age = "22",
                    NamePhoto="MrRobot.jpg"
               }
           };

        public MainPage()
        {
            InitializeComponent();
            MainListView.ItemsSource = omg;
        }

        async private void MainListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Selected = e.Item as ListViewTemplate;

            await Navigation.PushAsync(new Page1(Selected));


            ((ListView)sender).SelectedItem = null;


        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                MainListView.ItemsSource = omg;
            }

            else
            {
                MainListView.ItemsSource = omg.Where(x => x.Name.StartsWith(e.NewTextValue));
            }
        }
    }
}
