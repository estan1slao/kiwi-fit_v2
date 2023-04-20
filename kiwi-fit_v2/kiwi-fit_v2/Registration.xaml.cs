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

namespace kiwi_fit_v2
{
    public class UserInformation
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public int Gender { get; set; }
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
        }

        private async void InitializationUser(object sender, System.EventArgs e)
        {
            if (username.Text == null || userheight.Text == null || userweight.Text == null || !gender.IsEnabled)
            {
                await DisplayAlert("Ошибка", "Введите корректные данные", "Продолжить");
                return;
            }
            var userInfo = new UserInformation { Name = username.Text.Trim(), Weight = double.Parse(userheight.Text.Trim()), Height = double.Parse(userheight.Text.Trim()), Gender = int.Parse(gender.Id.ToString()) };
            if (userInfo.Name.Length < 1 || userInfo.Height < 140 || userInfo.Weight < 36)
            {
                await DisplayAlert("Ошибка", "Введите корректные данные", "Продолжить");
                return;
            }
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "userInfo.json");
            var json = JsonSerializer.Serialize(userInfo);

            File.WriteAllText(path, json);
            await Navigation.PushModalAsync(new MainPage());
            return;
        }
    }
}
