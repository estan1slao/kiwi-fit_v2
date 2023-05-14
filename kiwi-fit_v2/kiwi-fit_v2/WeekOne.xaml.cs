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
	public partial class WeekOne : ContentPage
	{
		public WeekOne ()
		{
			InitializeComponent ();

            im6.Source = ImageSource.FromResource("kiwi-fit_v2.im6.png");
            im6.Aspect = Aspect.Fill;

            im7.Source = ImageSource.FromResource("kiwi-fit_v2.im7.png");
            im7.Aspect = Aspect.Fill;

            im8.Source = ImageSource.FromResource("kiwi-fit_v2.im8.png");
            im8.Aspect = Aspect.Fill;

            im15.Source = ImageSource.FromResource("kiwi-fit_v2.im15.png");
            im15.Aspect = Aspect.Fill;

            im16.Source = ImageSource.FromResource("kiwi-fit_v2.im16.png");
            im16.Aspect = Aspect.Fill;

            im17.Source = ImageSource.FromResource("kiwi-fit_v2.im16.png");
            im17.Aspect = Aspect.Fill;

            im18.Source = ImageSource.FromResource("kiwi-fit_v2.im16.png");
            im18.Aspect = Aspect.Fill;

            im19.Source = ImageSource.FromResource("kiwi-fit_v2.im16.png");
            im19.Aspect = Aspect.Fill;

            im20.Source = ImageSource.FromResource("kiwi-fit_v2.im16.png");
            im20.Aspect = Aspect.Fill;

            im21.Source = ImageSource.FromResource("kiwi-fit_v2.im16.png");
            im21.Aspect = Aspect.Fill;
        }

        private async void GoToUserPage(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new UserPage());
        }

        private async void GoToTaskOnePage(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new TaskOne());
        }
    }
}