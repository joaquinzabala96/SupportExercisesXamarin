using Ejercicio3.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        ListViewTemplate personaB;
        public Page1(ListViewTemplate persona)
        {
            InitializeComponent();
            personaB = persona;
            lol1.Text = persona.Name;
            lol2.Text = persona.Age;

            imagen.Source = persona.NamePhoto;

        }
    }
}