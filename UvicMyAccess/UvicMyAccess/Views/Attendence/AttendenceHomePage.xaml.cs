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
    public partial class AttendenceHomePage : ContentPage
    {
        private AttendenceViewModel viewModel;
        private string greetingMessage = "";
        private string[] greetingMessages = { "Hello", "Bonjour", "Hola", "Welcome", "Greetings" };

        public AttendenceHomePage()
        {
            InitializeComponent();
        }
        public AttendenceHomePage(AttendenceViewModel _viewModel)
        {
            InitializeComponent();
            viewModel = _viewModel;
            greetingMessage = greetingMessages[new Random().Next(0, greetingMessages.Length - 1)] + " " + viewModel.UserName + "!";
            GreetingMessage.Text = greetingMessage;
            if (!viewModel.ClassesRegistered)
            {
                ClassesRegisteredLabel.Text = "You are not a member of any classes. To get started, create a class or join one!";
            }
        }

        private void CreateClass_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateNewClass());
        }

        private void JoinClass_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new JoinNewClass());
        }
    }
}