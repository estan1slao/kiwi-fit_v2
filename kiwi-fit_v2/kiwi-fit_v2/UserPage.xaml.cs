using System;
using System.IO;
using System.Text.Json;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static User.User;

namespace kiwi_fit_v2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        private void Initialization()
        {
            var pathInfo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "userInfo.json");
            if (!File.Exists(pathInfo))
                Navigation.PushModalAsync(new Registration());
            var info = JsonSerializer.Deserialize<UserInformation>(File.ReadAllText(pathInfo));
            username.Text = info.Name;
            height.Text = info.Height.ToString();
            weight.Text = info.Weight.ToString();
            imt.Text = info.IMT.ToString();
            imtNormal.Text = info.TextIMT.ToString();
            countOfWater.Text = info.TextCountOfWater.ToString();
        }

        public UserPage()
        {
            #region front-end
            InitializeComponent();
            userPageBackground.Source = ImageSource.FromResource("kiwi-fit_v2.userbg.png");
            userPageBackground.Aspect = Aspect.Fill;

            im1.Source = ImageSource.FromResource("kiwi-fit_v2.im1.png");
            im1.Aspect = Aspect.Fill;

            im2.Source = ImageSource.FromResource("kiwi-fit_v2.im2.png");
            im2.Aspect = Aspect.Fill;

            im3.Source = ImageSource.FromResource("kiwi-fit_v2.im3.png");
            im3.Aspect = Aspect.Fill;

            im4.Source = ImageSource.FromResource("kiwi-fit_v2.im4.png");
            im4.Aspect = Aspect.Fill;

            im5.Source = ImageSource.FromResource("kiwi-fit_v2.im5.png");
            im5.Aspect = Aspect.Fill;

            im6.Source = ImageSource.FromResource("kiwi-fit_v2.im6.png");
            im6.Aspect = Aspect.Fill;

            im7.Source = ImageSource.FromResource("kiwi-fit_v2.im7.png");
            im7.Aspect = Aspect.Fill;

            im8.Source = ImageSource.FromResource("kiwi-fit_v2.im8.png");
            im8.Aspect = Aspect.Fill;
            #endregion

            #region back-end
            Initialization();
            #endregion
        }
    }
}