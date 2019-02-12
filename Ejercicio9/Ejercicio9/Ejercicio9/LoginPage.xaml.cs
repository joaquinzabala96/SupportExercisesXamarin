using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio9
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        async void Login_Clicked(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = UserNameEntry.Text,
                Password = PasswordEntry.Text
            };

            var isVaild = AreCredentialsCorrect(user);
            if (isVaild)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MainPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                if (user.Username != Constants.Username)
                {
                    LoginFaild.Text = "Error User";
                    UserNameEntry.Text = string.Empty;
                    UserNameEntry.BackgroundColor = Color.Red;
                }

                if (user.Password != Constants.Password)
                {
                    LoginFaild2.Text = "Error Password";
                    PasswordEntry.Text = string.Empty;
                    PasswordEntry.BackgroundColor = Color.Red;
                }

            }
        }

        bool AreCredentialsCorrect(User user)
        {
            return user.Username == Constants.Username && user.Password == Constants.Password;

        }
    }
}