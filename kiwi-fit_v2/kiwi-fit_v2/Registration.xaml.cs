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
        public Registration()
        {
            InitializeComponent();
        }

        private async void InitializationUser(object sender, System.EventArgs e)
        {
            if (username.Text == null || userheight.Text == null || userweight.Text == null || (!male.IsChecked && !female.IsChecked))
            {
                await DisplayAlert("Ошибка", "Введите корректные данные", "Продолжить");
                return;
            }
            var userInfo = new UserInformation { Name = username.Text.Trim(), Weight = double.Parse(userweight.Text.Trim()), Height = double.Parse(userheight.Text.Trim()), Gender = male.IsChecked ? 0: 1 };
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
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "userInfo.json");
            var json = JsonSerializer.Serialize(userInfo);

            if (File.Exists(path))
                File.Delete(path);
            File.WriteAllText(path, json);
            await Navigation.PushModalAsync(new StepOne());
            return;
        }
    }
}