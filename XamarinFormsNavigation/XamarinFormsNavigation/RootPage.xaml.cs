using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsNavigation
{
    public partial class RootPage : ContentPage
    {
        public RootPage()
        {
            InitializeComponent();
        }

        private async void ModalNavigationSelected(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstPage());
        }

        private async void AnimatedNavigationSelected(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FirstPage(), true);
        }

        private async void NoAnimationSelected(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FirstPage(), false);
        }
    }
}
