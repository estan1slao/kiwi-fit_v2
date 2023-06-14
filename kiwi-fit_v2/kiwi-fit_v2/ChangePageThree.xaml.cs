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
	public partial class ChangePageThree : ContentPage
	{
        public UserInformation oldUserInfo = new UserInformation();
        private void InformationLast()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "newTempInfo.json");
            if (File.Exists(path))
                oldUserInfo = JsonSerializer.Deserialize<UserInformation>(File.ReadAllText(path));
            username.Text = oldUserInfo.Name;
            if (oldUserInfo.IsLoseWeight == false)
                gainWeightButton.BackgroundColor = Color.FromHex("#2B6130");
            else if (oldUserInfo.IsLoseWeight)
                loseWeightButton.BackgroundColor = Color.FromHex("#2B6130");
            if (oldUserInfo.IsFaster)
                fast.IsChecked = true;
            else if (!oldUserInfo.IsFaster)
                slowly.IsChecked = true;
        }

        private void GainWeightButtonClicked(object sender, System.EventArgs e)
        {
            oldUserInfo.IsLoseWeight = false;
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
            oldUserInfo.IsLoseWeight = true;
            if (gainWeightButton.BackgroundColor == Color.FromHex("#8EEF96") &&
                loseWeightButton.BackgroundColor == Color.FromHex("#8EEF96"))
            {
                loseWeightButton.BackgroundColor = Color.FromHex("#2B6130");
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
            }
            else
            {
                gainWeightButton.BackgroundColor = Color.FromHex("#8EEF96");
                loseWeightButton.BackgroundColor = Color.FromHex("#2B6130");
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
            }
        }
        public ChangePageThree ()
		{
            #region front-end
            InitializeComponent();
            InformationLast();
            userPageBackground.Source = ImageSource.FromResource("kiwi-fit_v2.userbg.png");
            userPageBackground.Aspect = Aspect.Fill;
            im6.Source = ImageSource.FromResource("kiwi-fit_v2.im6.png");
            im6.Aspect = Aspect.Fill;

            im7.Source = ImageSource.FromResource("kiwi-fit_v2.im7.png");
            im7.Aspect = Aspect.Fill;

            im8.Source = ImageSource.FromResource("kiwi-fit_v2.im8.png");
            im8.Aspect = Aspect.Fill;
            #endregion
        }

        private async void GoSavePage(object sender, System.EventArgs e)
        {
            oldUserInfo.IsFaster = fast.IsChecked;
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "newTempInfo.json");
            var json = JsonSerializer.Serialize(oldUserInfo);

            if (File.Exists(path))
                File.Delete(path);
            File.WriteAllText(path, json);

            await Navigation.PushModalAsync(new SaveChangeOne());
        }
    }
}