using System;
using System.IO;
using System.Text.Json;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static User.User;

namespace kiwi_fit_v2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChangePageTwo : ContentPage
    {
        public bool activitySelected = true;
        public UserInformation oldUserInfo = new UserInformation();

        private void Initialization()
        {
            var pathOld = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "userInfo.json");
            var pathNew = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "newTempInfo.json");
            var path = "";

            if (File.Exists(pathOld) && !File.Exists(pathNew))
                path = pathOld;
            else if (File.Exists(pathNew))
                path = pathNew;
            if (!(path.Length == 0))
            {
                oldUserInfo = JsonSerializer.Deserialize<UserInformation>(File.ReadAllText(path));
                username.Text = oldUserInfo.Name;
                newusername.Text = oldUserInfo.Name;
                userheight.Text = oldUserInfo.Height.ToString();
                userweight.Text = oldUserInfo.Weight.ToString();
                if (oldUserInfo.Gender == 0)
                    male.IsChecked = true;
                else if (oldUserInfo.Gender == 1)
                    female.IsChecked = true;
                if (oldUserInfo.Activity == 4)
                    everyDay.BackgroundColor = Color.FromHex("#2B6130");
                else if (oldUserInfo.Activity == 5)
                    EveryDayAndJob.BackgroundColor = Color.FromHex("#2B6130");
                else if (oldUserInfo.Activity == 6)
                    TwoInDay.BackgroundColor = Color.FromHex("#2B6130");
            }
        }
        public ChangePageTwo()
        {
            #region front-end
            InitializeComponent();
            Initialization();
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
            #endregion
        }

        private void EveryDayClicked(object sender, System.EventArgs e)
        {
            activitySelected = true;
            oldUserInfo.Activity = 4;
            if (everyDay.BackgroundColor == Color.FromHex("#68ED76") &&
                EveryDayAndJob.BackgroundColor == Color.FromHex("#68ED76") &&
                TwoInDay.BackgroundColor == Color.FromHex("#68ED76"))
            {
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
                everyDay.BackgroundColor = Color.FromHex("#2B6130");
            }

            else
            {
                everyDay.BackgroundColor = Color.FromHex("#68ED76");
                EveryDayAndJob.BackgroundColor = Color.FromHex("#68ED76");
                TwoInDay.BackgroundColor = Color.FromHex("#68ED76");
                everyDay.BackgroundColor = Color.FromHex("#2B6130");
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
            }
        }

        private void EveryDayAndJobClicked(object sender, System.EventArgs e)
        {
            activitySelected = true;
            oldUserInfo.Activity = 5;
            if (everyDay.BackgroundColor == Color.FromHex("#68ED76") &&
                EveryDayAndJob.BackgroundColor == Color.FromHex("#68ED76") &&
                TwoInDay.BackgroundColor == Color.FromHex("#68ED76"))
            {
                EveryDayAndJob.BackgroundColor = Color.FromHex("#2B6130");
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
            }
            else
            {
                everyDay.BackgroundColor = Color.FromHex("#68ED76");
                EveryDayAndJob.BackgroundColor = Color.FromHex("#68ED76");
                TwoInDay.BackgroundColor = Color.FromHex("#68ED76");
                EveryDayAndJob.BackgroundColor = Color.FromHex("#2B6130");
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
            }
        }

        private void TwoInDayClicked(object sender, System.EventArgs e)
        {
            activitySelected = true;
            oldUserInfo.Activity = 6;
            if (everyDay.BackgroundColor == Color.FromHex("#68ED76") &&
                EveryDayAndJob.BackgroundColor == Color.FromHex("#68ED76") &&
                TwoInDay.BackgroundColor == Color.FromHex("#68ED76"))
            {
                TwoInDay.BackgroundColor = Color.FromHex("#2B6130");
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
            }
            else
            {
                everyDay.BackgroundColor = Color.FromHex("#68ED76");
                EveryDayAndJob.BackgroundColor = Color.FromHex("#68ED76");
                TwoInDay.BackgroundColor = Color.FromHex("#68ED76");
                TwoInDay.BackgroundColor = Color.FromHex("#2B6130");
                sendDataButton.BackgroundColor = Color.FromHex("#68ED76");
            }
        }

        private async void GoNextPage(object sender, System.EventArgs e)
        {
            if (username.Text != null)
                oldUserInfo.Name = username.Text.Trim();
            if (userheight.Text != null)
                oldUserInfo.Height = double.Parse(userheight.Text.Trim());
            if (userweight.Text != null)
                oldUserInfo.Weight = double.Parse(userweight.Text.Trim());
            if (male.IsChecked)
                oldUserInfo.Gender = 0;
            else if (female.IsChecked)
                oldUserInfo.Gender = 1;
            else
                oldUserInfo.Gender = -1;
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "newTempInfo.json");
            var json = JsonSerializer.Serialize(oldUserInfo);

            if (File.Exists(path))
                File.Delete(path);
            File.WriteAllText(path, json);
            await Navigation.PushModalAsync(new ChangePageOne());
        }

        private async void GoGhangePage(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ChangePageThree());
        }
        private async void GoSavePage(object sender, System.EventArgs e)
        {
            if (username.Text != null)
                oldUserInfo.Name = newusername.Text.Trim();
            if (userheight.Text != null)
                oldUserInfo.Height = double.Parse(userheight.Text.Trim());
            if (userweight.Text != null)
                oldUserInfo.Weight = double.Parse(userweight.Text.Trim());
            if (male.IsChecked)
                oldUserInfo.Gender = 0;
            else if (female.IsChecked)
                oldUserInfo.Gender = 1;
            else
                oldUserInfo.Gender = -1;
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "newTempInfo.json");
            var json = JsonSerializer.Serialize(oldUserInfo);

            if (File.Exists(path))
                File.Delete(path);
            File.WriteAllText(path, json);
            await Navigation.PushModalAsync(new SavePageTwo());
        }
    }

}