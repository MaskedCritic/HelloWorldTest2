using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace HelloWorldTest1.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://github.com/MaskedCritic/HelloWorldTest2")));
        }

        public ICommand OpenWebCommand { get; }
    }
}