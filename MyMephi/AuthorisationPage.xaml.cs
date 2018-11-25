using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyMephi
{

	public partial class AuthorisationPage : ContentPage
	{
		public AuthorisationPage ()
		{
            InitializeComponent ();

            Title = "Авторизация";
		}

        private async void ToBarPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BarPage());
        }
	}
}