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
    public partial class Registration : ContentPage
    {
        public bool activitySelected = false;
        public UserInformation userInfo = new UserInformation();
        public Registration()
        {
            InitializeComponent();
            InformationLast();
            im14.Source = ImageSource.FromResource("kiwi-fit_v2.im14.png");
            im14.Aspect = Aspect.Fill;
        }

        public async void InitializationUser(object sender, System.EventArgs e)
        {
            if (username.Text == null || userheight.Text == null || userweight.Text == null || userage.Text == null || (!male.IsChecked && !female.IsChecked))
            {
                await DisplayAlert("Ошибка", "Введите корректные данные", "Продолжить");
                return;
            }
            userInfo.Name = username.Text.Trim();
            userInfo.Weight = double.Parse(userweight.Text.Trim());
            userInfo.Height = double.Parse(userheight.Text.Trim());
            userInfo.Age = double.Parse(userage.Text.Trim());
            userInfo.Gender = male.IsChecked ? 0 : female.IsChecked ? 1 : -1;
            if (userInfo.Name.Length < 1 || userInfo.Height < 140 || userInfo.Weight < 36 || userInfo.Age < 0)
            {
                await DisplayAlert("Ошибка", "Введите корректные данные", "Продолжить");
                return;
            }
            var userIMT = Math.Round((userInfo.Weight / (userInfo.Height * userInfo.Height)) * 10000, 1);
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
            userInfo.Date = DateTime.Now;
            if (activitySelected)
            {
                var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "tempInfo.json");
                var json = JsonSerializer.Serialize(userInfo);

                if (File.Exists(path))
                    File.Delete(path);
                File.WriteAllText(path, json);
                await Navigation.PushModalAsync(new Registration2(), false);
            }
            else
                await DisplayAlert("Ошибка", "Введите корректные данные", "Продолжить");
            return;
        }

        private void AbsenceClicked(object sender, System.EventArgs e)
        {
            activitySelected = true;
            userInfo.Activity = 0;
            if (absence.BackgroundColor == Color.FromHex("#68ED76") &&
                TwoTimeAWeek.BackgroundColor == Color.FromHex("#68ED76") &&
                ThreeTimeAWeek.BackgroundColor == Color.FromHex("#68ED76") &&
                FiveTimeAWeek.BackgroundColor == Color.FromHex("#68ED76"))
            {
                absence.BackgroundColor = Color.FromHex("#2B6130");
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
            }
            else
            {
                absence.BackgroundColor = Color.FromHex("#68ED76");
                TwoTimeAWeek.BackgroundColor = Color.FromHex("#68ED76");
                ThreeTimeAWeek.BackgroundColor = Color.FromHex("#68ED76");
                FiveTimeAWeek.BackgroundColor = Color.FromHex("#68ED76");
                absence.BackgroundColor = Color.FromHex("#2B6130");
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
            }
        }

        private void TwoTimeAWeekClicked(object sender, System.EventArgs e)
        {
            activitySelected = true;
            userInfo.Activity = 1;
            if (absence.BackgroundColor == Color.FromHex("#68ED76") &&
                TwoTimeAWeek.BackgroundColor == Color.FromHex("#68ED76") &&
                ThreeTimeAWeek.BackgroundColor == Color.FromHex("#68ED76") &&
                FiveTimeAWeek.BackgroundColor == Color.FromHex("#68ED76"))
            {
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
                TwoTimeAWeek.BackgroundColor = Color.FromHex("#2B6130");
            }
                
            else
            {
                absence.BackgroundColor = Color.FromHex("#68ED76");
                TwoTimeAWeek.BackgroundColor = Color.FromHex("#68ED76");
                ThreeTimeAWeek.BackgroundColor = Color.FromHex("#68ED76");
                FiveTimeAWeek.BackgroundColor = Color.FromHex("#68ED76");
                TwoTimeAWeek.BackgroundColor = Color.FromHex("#2B6130");
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
            }
        }

        private void ThreeTimeAWeekClicked(object sender, System.EventArgs e)
        {
            activitySelected = true;
            userInfo.Activity = 2;
            if (absence.BackgroundColor == Color.FromHex("#68ED76") &&
                TwoTimeAWeek.BackgroundColor == Color.FromHex("#68ED76") &&
                ThreeTimeAWeek.BackgroundColor == Color.FromHex("#68ED76") &&
                FiveTimeAWeek.BackgroundColor == Color.FromHex("#68ED76"))
            {
                ThreeTimeAWeek.BackgroundColor = Color.FromHex("#2B6130");
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
            }
            else
            {
                absence.BackgroundColor = Color.FromHex("#68ED76");
                TwoTimeAWeek.BackgroundColor = Color.FromHex("#68ED76");
                ThreeTimeAWeek.BackgroundColor = Color.FromHex("#68ED76");
                FiveTimeAWeek.BackgroundColor = Color.FromHex("#68ED76");
                ThreeTimeAWeek.BackgroundColor = Color.FromHex("#2B6130");
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
            }
        }

        private void FiveTimeAWeekClicked(object sender, System.EventArgs e)
        {
            activitySelected = true;
            userInfo.Activity = 3;
            if (absence.BackgroundColor == Color.FromHex("#68ED76") &&
                TwoTimeAWeek.BackgroundColor == Color.FromHex("#68ED76") &&
                ThreeTimeAWeek.BackgroundColor == Color.FromHex("#68ED76") &&
                FiveTimeAWeek.BackgroundColor == Color.FromHex("#68ED76"))
            {
                FiveTimeAWeek.BackgroundColor = Color.FromHex("#2B6130");
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
            }
            else
            {
                absence.BackgroundColor = Color.FromHex("#68ED76");
                TwoTimeAWeek.BackgroundColor = Color.FromHex("#68ED76");
                ThreeTimeAWeek.BackgroundColor = Color.FromHex("#68ED76");
                FiveTimeAWeek.BackgroundColor = Color.FromHex("#68ED76");
                FiveTimeAWeek.BackgroundColor = Color.FromHex("#2B6130");
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
            }
        }

        private async void RegistrationSecond(object sender, System.EventArgs e)
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
            if (userage.Text != null)
                userInfo.Age = double.Parse(userage.Text.Trim());
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "tempInfo.json");
            var json = JsonSerializer.Serialize(userInfo);

            if (File.Exists(path))
                File.Delete(path);
            File.WriteAllText(path, json);
            await Navigation.PushModalAsync(new Registration1(), false);
        }

        public void InformationLast()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "tempInfo.json");
            if (File.Exists(path))
            {
                userInfo = JsonSerializer.Deserialize<UserInformation>(File.ReadAllText(path));
                if (userInfo.Name != null)
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
                if (userInfo.Age != 0)
                    userage.Text = userInfo.Age.ToString();
            }
        }
    }
}