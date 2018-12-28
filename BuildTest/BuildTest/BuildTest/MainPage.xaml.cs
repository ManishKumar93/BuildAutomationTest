using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BuildTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btnShowMessage.Clicked += ButtonClickedAsync;
        }

        private async void ButtonClickedAsync(object sender, EventArgs e)
        {
            await DisplayAlert("Title", "Message", "Ok");
        }
    }
}
