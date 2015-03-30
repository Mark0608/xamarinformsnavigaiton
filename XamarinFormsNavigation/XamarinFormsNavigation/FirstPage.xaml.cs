using System;
using Xamarin.Forms;

namespace XamarinFormsNavigation
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private async void NavigateToSecondPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage(), true);
        }
    }
}
