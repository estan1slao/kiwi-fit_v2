using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;
using static User.User;

namespace kiwi_fit_v2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registration2 : ContentPage
	{
        public UserInformation userInfo = new UserInformation();
        private bool isTargetSelected = false;

        public Registration2 ()
		{
			InitializeComponent();
            InformationLast();
        }

        private void GainWeightButtonClicked(object sender, System.EventArgs e)
        {
            isTargetSelected = true;
            userInfo.IsLoseWeight = false;
            if (gainWeightButton.BackgroundColor == Color.FromHex("#8EEF96") &&
                loseWeightButton.BackgroundColor == Color.FromHex("#8EEF96"))
            {
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
                gainWeightButton.BackgroundColor = Color.FromHex("#2B6130");
            }
                
            else
            {
                gainWeightButton.BackgroundColor = Color.FromHex("#8EEF96");
                loseWeightButton.BackgroundColor = Color.FromHex("#8EEF96");
                gainWeightButton.BackgroundColor = Color.FromHex("#2B6130");
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
            }
        }

        private void LoseWeightButtonClicked(object sender, System.EventArgs e)
        {
            isTargetSelected = true;
            userInfo.IsLoseWeight = true;
            if (gainWeightButton.BackgroundColor == Color.FromHex("#8EEF96") &&
                loseWeightButton.BackgroundColor == Color.FromHex("#8EEF96"))
            {
                loseWeightButton.BackgroundColor = Color.FromHex("#2B6130");
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
            }
            else
            {
                gainWeightButton.BackgroundColor = Color.FromHex("#8EEF96");
                loseWeightButton.BackgroundColor = Color.FromHex("#8EEF96");
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
            }
        }

        private async void EndRegistration(object sender, System.EventArgs e)
        {
            if(!isTargetSelected || (!fast.IsChecked && !slowly.IsChecked))
            {
                await DisplayAlert("Ошибка", "Введите корректные данные", "Продолжить");
                return;
            }
            userInfo.IsFaster = fast.IsChecked;
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "userInfo.json");
            var json = JsonSerializer.Serialize(userInfo);

            if (File.Exists(path))
                File.Delete(path);
            File.WriteAllText(path, json);
            await Navigation.PushModalAsync(new StepOne());
        }

        private void InformationLast()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "tempInfo.json");
            if (File.Exists(path))
                userInfo = JsonSerializer.Deserialize<UserInformation>(File.ReadAllText(path));
        }
    }
}