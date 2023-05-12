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
	public partial class Registration1 : ContentPage
	{
		public UserInformation userInfo = new UserInformation();
        public bool activitySelected = false;
        public Registration1 ()
		{
            InitializeComponent();
            InformationLast();
            im14.Source = ImageSource.FromResource("kiwi-fit_v2.im14.png");
            im14.Aspect = Aspect.Fill;
        }

		public void InformationLast()
		{
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "tempInfo.json");
            if (File.Exists(path))
            {
                userInfo = JsonSerializer.Deserialize<UserInformation>(File.ReadAllText(path));
                if(userInfo.Name != null)
                    username.Text = userInfo.Name;
                if (userInfo.Height != 0)
                    userheight.Text = userInfo.Height.ToString();
                if (userInfo.Weight != 0)
                    userweight.Text = userInfo.Weight.ToString();
                if (userInfo.Gender != -1)
                {
                    if (userInfo.Gender == 0)
                        male.IsChecked = true;
                    else
                        female.IsChecked = true;
                }
            }
        }

        private async void RegistrationFirst(object sender, System.EventArgs e)
        {
            if (username.Text != null)
                userInfo.Name = username.Text.Trim();
            if (userheight.Text != null)
                userInfo.Height = double.Parse(userheight.Text.Trim());
            if (userweight.Text != null)
                userInfo.Weight = double.Parse(userweight.Text.Trim());
            if (male.IsChecked)
                userInfo.Gender = 0;
            else if (female.IsChecked)
                userInfo.Gender = 1;
            else
                userInfo.Gender = -1;
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "tempInfo.json");
            var json = JsonSerializer.Serialize(userInfo);

            if (File.Exists(path))
                File.Delete(path);
            File.WriteAllText(path, json);
            await Navigation.PushModalAsync(new Registration());
        }

        private void EveryDayClicked(object sender, System.EventArgs e)
        {
            activitySelected = true;
            userInfo.Activity = 4;
            if (everyDay.BackgroundColor == Color.FromHex("#68ED76") &&
                EveryDayAndJob.BackgroundColor == Color.FromHex("#68ED76") &&
                TwoInDay.BackgroundColor == Color.FromHex("#68ED76"))
                everyDay.BackgroundColor = Color.FromHex("#2B6130");
            else
            {
                everyDay.BackgroundColor = Color.FromHex("#68ED76");
                EveryDayAndJob.BackgroundColor = Color.FromHex("#68ED76");
                TwoInDay.BackgroundColor = Color.FromHex("#68ED76");
                everyDay.BackgroundColor = Color.FromHex("#2B6130");
            }
        }

        private void EveryDayAndJobClicked(object sender, System.EventArgs e)
        {
            activitySelected = true;
            userInfo.Activity = 5;
            if (everyDay.BackgroundColor == Color.FromHex("#68ED76") &&
                EveryDayAndJob.BackgroundColor == Color.FromHex("#68ED76") &&
                TwoInDay.BackgroundColor == Color.FromHex("#68ED76"))
                EveryDayAndJob.BackgroundColor = Color.FromHex("#2B6130");
            else
            {
                everyDay.BackgroundColor = Color.FromHex("#68ED76");
                EveryDayAndJob.BackgroundColor = Color.FromHex("#68ED76");
                TwoInDay.BackgroundColor = Color.FromHex("#68ED76");
                EveryDayAndJob.BackgroundColor = Color.FromHex("#2B6130");
            }
        }

        private void TwoInDayClicked(object sender, System.EventArgs e)
        {
            activitySelected = true;
            userInfo.Activity = 6;
            if (everyDay.BackgroundColor == Color.FromHex("#68ED76") &&
                EveryDayAndJob.BackgroundColor == Color.FromHex("#68ED76") &&
                TwoInDay.BackgroundColor == Color.FromHex("#68ED76"))
                TwoInDay.BackgroundColor = Color.FromHex("#2B6130");
            else
            {
                everyDay.BackgroundColor = Color.FromHex("#68ED76");
                EveryDayAndJob.BackgroundColor = Color.FromHex("#68ED76");
                TwoInDay.BackgroundColor = Color.FromHex("#68ED76");
                TwoInDay.BackgroundColor = Color.FromHex("#2B6130");
            }
        }

        public async void InitializationUser(object sender, System.EventArgs e)
        {
            if (username.Text == null || userheight.Text == null || userweight.Text == null || (!male.IsChecked && !female.IsChecked))
            {
                await DisplayAlert("Ошибка", "Введите корректные данные", "Продолжить");
                return;
            }
            userInfo.Name = username.Text.Trim();
            userInfo.Weight = double.Parse(userweight.Text.Trim());
            userInfo.Height = double.Parse(userheight.Text.Trim());
            userInfo.Gender = male.IsChecked ? 0 : female.IsChecked ? 1 : -1;
            if (userInfo.Name.Length < 1 || userInfo.Height < 140 || userInfo.Weight < 36)
            {
                await DisplayAlert("Ошибка", "Введите корректные данные", "Продолжить");
                return;
            }
            var userIMT = Math.Round((userInfo.Weight / (userInfo.Height * userInfo.Height)) * 10000, 1);
            userInfo.IMT = userIMT;
            string imtText;
            if (userIMT < 16)
                imtText = "Дефицит массы тела";
            else if (userIMT < 18.5)
                imtText = "Минимальная масса тела";
            else if (userIMT < 25)
                imtText = "Масса тела в норме";
            else if (userIMT < 30)
                imtText = "Избыток веса";
            else if (userIMT < 35)
                imtText = "Первая степень ожирения";
            else if (userIMT < 40)
                imtText = "Вторая степень ожирения";
            else
                imtText = "Третья степень ожирения";
            userInfo.TextIMT = imtText;
            userInfo.TextCountOfWater = $"{Math.Round(0.025 * userInfo.Weight, 1)} - {Math.Round(0.03 * userInfo.Weight, 1)} л.";
            userInfo.Date = DateTime.Now;
            if (activitySelected)
            {
                var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "tempInfo.json");
                var json = JsonSerializer.Serialize(userInfo);

                if (File.Exists(path))
                    File.Delete(path);
                File.WriteAllText(path, json);
                await Navigation.PushModalAsync(new Registration2());
            }
            else
                await DisplayAlert("Ошибка", "Введите корректные данные", "Продолжить");
            return;
        }
    }
}