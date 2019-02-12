using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio12
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Cliclar(object sender, EventArgs e)
        {

            var label = new Label { Text = "label creado", FontSize = 20 };
            aqui.Children.Add(label);
            this.Content = aqui;
        }
    }
}
