using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FoodFinder
{
    public partial class SignupPage : ContentPage
    {
        public SignupPage()
        {
            InitializeComponent();
        }

        // JH: Will have to send the user to the MapPage
        void ClickedSignup(object sender, System.EventArgs e)
        {
            //EDH: i believe that Justin put this code in
            //string EmailS = email.Entry;
            //string PassWd = password.Entry;
            //string PassWdConfirm = passwordConfirm.Entry;
            //string CampusPrim = primaryCampus.String;

            //JH: Display a prompt for user to verify their signup
            DisplayAlert("A Verification Code has been sent to your email. Submit it here:","Verify","Cancel");
            //JH: DisplayAlert("You Have Signed Up!");
            //JH: Log in the users
            //JH: Navigation.PopAsync(MapPage());
        }

        // JH: Will have to send the user to the EULAPage
        void ClickedEULA(object sender, System.EventArgs e)
        {
            //JH: Navigation.PopAsync(EULAPage());
        }

        //EDH: EULA POPUP, NOT A NEW SCREEN
        void OnEULASelect(object sender, EventArgs e)
        {
            string eulaMessage = "EULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA" +
                "TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA" +
                "TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA" +
                "TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA" +
                "TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA" +
                "TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA" +
                "TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA" +
                "TextEULA TextEULA TextEULA TextEULA TextEULA TextEULA Text";
            DisplayAlert("EULA", eulaMessage, "Close");
        }
        //EDH: Takes User back to LoginPage
        async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        //EDH: User can toggle the aggree/disagree switch
        void userAgreesWithEULA(object sender, EventArgs e)
        {
            
        }
    }
}
