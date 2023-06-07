using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static User.User;

namespace kiwi_fit_v2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChangePageOne : ContentPage
	{
        public bool activitySelected = false;
        public UserInformation userInfo = new UserInformation();
        public ChangePageOne ()
		{
            #region front-end
            InitializeComponent();

            userPageBackground.Source = ImageSource.FromResource("kiwi-fit_v2.userbg.png");
            userPageBackground.Aspect = Aspect.Fill;
            im6.Source = ImageSource.FromResource("kiwi-fit_v2.im6.png");
            im6.Aspect = Aspect.Fill;

            im7.Source = ImageSource.FromResource("kiwi-fit_v2.im7.png");
            im7.Aspect = Aspect.Fill;

            im8.Source = ImageSource.FromResource("kiwi-fit_v2.im8.png");
            im8.Aspect = Aspect.Fill;

            im14.Source = ImageSource.FromResource("kiwi-fit_v2.im14.png");
            im14.Aspect = Aspect.Fill;
            # endregion
        }
        private async void GoNextPage(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ChangePageTwo());
        }

        private async void GoGhangePage(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ChangePageThree());
        }

        private async void GoSavePage(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new SavePageTwo());
        }
    }
}