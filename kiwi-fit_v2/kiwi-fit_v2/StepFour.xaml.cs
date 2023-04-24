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
	public partial class StepFour : ContentPage
	{
		public StepFour ()
		{
			InitializeComponent();
            userPageBackground.Source = ImageSource.FromResource("kiwi-fit_v2.userbg.png");
            userPageBackground.Aspect = Aspect.Fill;
            im1.Source = ImageSource.FromResource("kiwi-fit_v2.im1.png");
            im1.Aspect = Aspect.Fill;

            im2.Source = ImageSource.FromResource("kiwi-fit_v2.im2.png");
            im2.Aspect = Aspect.Fill;

            im4.Source = ImageSource.FromResource("kiwi-fit_v2.im4.png");
            im4.Aspect = Aspect.Fill;

            im5.Source = ImageSource.FromResource("kiwi-fit_v2.im5.png");
            im5.Aspect = Aspect.Fill;

            im6.Source = ImageSource.FromResource("kiwi-fit_v2.im6.png");
            im6.Aspect = Aspect.Fill;

            im7.Source = ImageSource.FromResource("kiwi-fit_v2.im7.png");
            im7.Aspect = Aspect.Fill;

            im8.Source = ImageSource.FromResource("kiwi-fit_v2.im8.png");
            im8.Aspect = Aspect.Fill;

            im9.Source = ImageSource.FromResource("kiwi-fit_v2.im9.png");
            im9.Aspect = Aspect.Fill;

            im10.Source = ImageSource.FromResource("kiwi-fit_v2.im10.png");
            im10.Aspect = Aspect.Fill;
        }

        private async void GoToUserPage(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new UserPage());
        }

        private async void GoNextPage(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new StepFive());
        }
    }
}