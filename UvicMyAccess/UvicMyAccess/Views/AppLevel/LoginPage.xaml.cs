using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UvicMyAccess.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UvicMyAccess.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButtonPressed_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new AttendenceHomePage(new AttendenceViewModel(Email.Text))));
        }
    }
}