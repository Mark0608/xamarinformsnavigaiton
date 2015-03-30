using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsNavigation
{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private void RemoveFirstPage(object sender, EventArgs e)
        {
            var firstPage = Navigation.NavigationStack[1];
            Navigation.RemovePage(firstPage);
        }

        private async void BackToRoot(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
