using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodFinder
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();            
        }

        async void OnSignupButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new SignupPage());
        }

        //EDH: User clicks login, user is taken to MapPage, no user credentials required yet
        private void ClickedLogin(object sender, EventArgs e)
        {
            //string EmailS = email.Entry;
            //string PassWd = password.Entry;



            //Navigation.PushModelAsync(MapPage());
        }
    }
}