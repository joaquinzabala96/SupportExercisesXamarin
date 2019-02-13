using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;

namespace Ejercicio15
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ActivityIndicator.IsRunning = true;

            waitForMinute();
        }

        public void waitForMinute()
        {
            Device.StartTimer(new TimeSpan(0, 0, 5), () => {
                ActivityIndicator.IsRunning = false;
                return ActivityIndicator.IsRunning;
            });

        }
    }
}
