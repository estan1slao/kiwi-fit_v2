using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kiwi_fit_v2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registration : ContentPage
	{
		public Registration ()
		{
			InitializeComponent();
		}

        private async void OnButtonStartClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new UserPage());
        }
    }
}