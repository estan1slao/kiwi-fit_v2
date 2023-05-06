using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Reflection;
using static User.User;

namespace kiwi_fit_v2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StepInstr1 : ContentPage
	{
        private void Initialization()
        {
            var pathInfo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "userInfo.json");
            if (!File.Exists(pathInfo))
                Navigation.PushModalAsync(new Registration());
            var info = JsonSerializer.Deserialize<UserInformation>(File.ReadAllText(pathInfo));

            var firstDay = info.Date.Day.ToString();
            var firstMonth = info.Date.Month.ToString();
            var firstYear = info.Date.Year.ToString();

            var secondDate = info.Date + new TimeSpan(168, 0, 0);
            var secondDay = secondDate.Day.ToString();
            var secondMonth = secondDate.Month.ToString();
            var secondYear = secondDate.Year.ToString();
            week.Text = $"{firstDay}.{firstMonth}.{firstYear} - {secondDay}.{secondMonth}.{secondYear}";
        }
        public StepInstr1 ()
		{
			InitializeComponent ();
            Initialization();
            stepbg.Source = ImageSource.FromResource("kiwi-fit_v2.stepsbg.png");
            stepbg.Aspect = Aspect.Fill;
            im9.Source = ImageSource.FromResource("kiwi-fit_v2.im9.png");
            im9.Aspect = Aspect.Fill;

            im10.Source = ImageSource.FromResource("kiwi-fit_v2.im10.png");
            im10.Aspect = Aspect.Fill;
        }

        private async void GoNextPage(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new StepInstr2());
        }
    }
}