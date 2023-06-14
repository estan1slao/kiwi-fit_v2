using System;
using System.IO;
using System.Text.Json;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static User.User;

namespace kiwi_fit_v2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SavePageTwo : ContentPage
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
                if (oldUserInfo.Activity == 0)
                    absence.BackgroundColor = Color.FromHex("#2B6130");
                else if (oldUserInfo.Activity == 1)
                    TwoTimeAWeek.BackgroundColor = Color.FromHex("#2B6130");
                else if (oldUserInfo.Activity == 2)
                    ThreeTimeAWeek.BackgroundColor = Color.FromHex("#2B6130");
                else if (oldUserInfo.Activity == 3)
                    FiveTimeAWeek.BackgroundColor = Color.FromHex("#2B6130");
            }
        }
        public SavePageTwo()
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

        private async void SaveChangeClicked(object sender, System.EventArgs e)
        {
            var pathNew = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "userInfo.json");
            var json = JsonSerializer.Serialize(oldUserInfo);

            if (File.Exists(pathNew))
                File.Delete(pathNew);
            File.WriteAllText(pathNew, json);

            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "newTempInfo.json");
            File.Delete(path);

            await Navigation.PushModalAsync(new UserPage());
        }

        private async void NotSaveChangeClicked(object sender, System.EventArgs e)
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "newTempInfo.json");
            File.Delete(path);
            await Navigation.PushModalAsync(new UserPage());
        }
    }
}