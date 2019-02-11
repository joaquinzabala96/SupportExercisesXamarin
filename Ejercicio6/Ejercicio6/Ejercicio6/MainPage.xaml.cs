using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Labelsillo.TranslateTo(0, 100, 250);
            await Labelsillo.RotateTo(360, 500, Easing.SinOut);
            await Labelsillo.RotateTo(-360, 500, Easing.SinOut);
            await Labelsillo.TranslateTo(0, -100, 250);
        }
    }
}
