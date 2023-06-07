using System.Text.Json;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static User.User;
using System.IO;

namespace kiwi_fit_v2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeekTwo : ContentPage
    {
        private void Initialization()
        {
            var pathInfo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "userInfo.json");
            if (!File.Exists(pathInfo))
                Navigation.PushModalAsync(new Registration());
            var info = JsonSerializer.Deserialize<UserInformation>(File.ReadAllText(pathInfo));

            var currentDate = info.Date + new TimeSpan(7, 0, 0, 0);
            if (!(currentDate.Date <= DateTime.Now.Date && (currentDate.Date + new TimeSpan(7, 0, 0, 0)) > DateTime.Now.Date))
            {
                Navigation.PushModalAsync(new WeekThree(),false);
                return;
            }

            var firstDay = currentDate.Day.ToString();
            var firstMonth = currentDate.Month.ToString();
            var firstYear = currentDate.Year.ToString();

            var secondDate = currentDate + new TimeSpan(7, 0, 0, 0);
            var secondDay = secondDate.Day.ToString();
            var secondMonth = secondDate.Month.ToString();
            var secondYear = secondDate.Year.ToString();
            week.Text = $"{firstDay}.{firstMonth}.{firstYear} - {secondDay}.{secondMonth}.{secondYear}";
            stepNumber.Text = "Шаг 2";
        }
        public WeekTwo()
        {
            InitializeComponent();
            Initialization();

            im6.Source = ImageSource.FromResource("kiwi-fit_v2.im6.png");
            im6.Aspect = Aspect.Fill;

            im7.Source = ImageSource.FromResource("kiwi-fit_v2.im7.png");
            im7.Aspect = Aspect.Fill;

            im8.Source = ImageSource.FromResource("kiwi-fit_v2.im8.png");
            im8.Aspect = Aspect.Fill;

            im15.Source = ImageSource.FromResource("kiwi-fit_v2.im15.png");
            im15.Aspect = Aspect.Fill;

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

        private async void GoToTaskTwoPage(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new TaskTwo());
        }
    }
}