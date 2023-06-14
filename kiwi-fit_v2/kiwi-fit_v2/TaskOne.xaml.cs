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
	public partial class TaskOne : ContentPage
	{
		public TaskOne ()
		{
			InitializeComponent ();

            im16.Source = ImageSource.FromResource("kiwi-fit_v2.im17.png");
            im16.Aspect = Aspect.Fill;

            im17.Source = ImageSource.FromResource("kiwi-fit_v2.im17.png");
            im17.Aspect = Aspect.Fill;

            im18.Source = ImageSource.FromResource("kiwi-fit_v2.im17.png");
            im18.Aspect = Aspect.Fill;

            im19.Source = ImageSource.FromResource("kiwi-fit_v2.im17.png");
            im19.Aspect = Aspect.Fill;

            im20.Source = ImageSource.FromResource("kiwi-fit_v2.im17.png");
            im20.Aspect = Aspect.Fill;
        }

        private async void GoToStepPage(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new WeekOne());
        }
    }
}