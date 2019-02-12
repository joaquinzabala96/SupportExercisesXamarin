using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void cambio(object sender, TextChangedEventArgs e)
        {
            segundo.Placeholder = primero.Text;
        }
    }
}
