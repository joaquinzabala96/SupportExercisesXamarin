using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio10
{
    public partial class MainPage : ContentPage
    {

        List<string> listItems = new List<string>();

        public MainPage()
        {
            InitializeComponent();

            listItems.Add("Flash");
            listItems.Add("Batman");
            listItems.Add("Linterna Verde");
            listItems.Add("Superman");
            listItems.Add("CatWoman");
            listPlatforms.ItemsSource = listItems;

            listPlatforms.RefreshCommand = new Command(() => {
                RefreshData();
                listPlatforms.IsRefreshing = false;
            });
        }

        public void RefreshData()
        {
            listItems.Add("Clon DE FLASH");
            listPlatforms.ItemsSource = null;
            listPlatforms.ItemsSource = listItems;
        }
    }
}
