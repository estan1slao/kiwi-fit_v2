using System;
using System.IO;
using System.Text.Json;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kiwi_fit_v2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserPage : ContentPage
    {
        private void Initialization(UserInformation info)
        {
            username.Text = info.Name;
            height.Text = info.Height.ToString();
            weight.Text = info.Weight.ToString();
            var userIMT = Math.Round((info.Weight / (info.Height * info.Height)) * 10000, 1);
            imt.Text = userIMT.ToString();
            if (userIMT < 16)
                imtNormal.Text = "Дефицит массы тела";
            else if (userIMT < 18.5)
                imtNormal.Text = "Минимальная масса тела";
            else if (userIMT < 25)
                imtNormal.Text = "Масса тела в норме";
            else if (userIMT < 30)
                imtNormal.Text = "Избыток веса";
            else if (userIMT < 35)
                imtNormal.Text = "Первая степень ожирения";
            else if (userIMT < 40)
                imtNormal.Text = "Вторая степень ожирения";
            else
                imtNormal.Text = "Третья степень ожирения";
            countOfWater.Text = $"{Math.Round(0.025 * info.Weight, 1)} - {Math.Round(0.03 * info.Weight, 1)} л.";
        }

        public UserPage()
        {
            #region front-end
            InitializeComponent();
            userPageBackground.Source = ImageSource.FromResource("kiwi -fit_v2.userbg.png");
            userPageBackground.Aspect = Aspect.Fill;

            im1.Source = ImageSource.FromResource("kiwi-fit_v2.im1.png");
            im1.Aspect = Aspect.Fill;

            im2.Source = ImageSource.FromResource("kiwi-fit_v2.im2.png");
            im2.Aspect = Aspect.Fill;

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
            var pathInfo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "userInfo.json");
            if (!File.Exists(pathInfo))
                Navigation.PushModalAsync(new Registration());
            var jsonInfo = JsonSerializer.Deserialize<UserInformation>(File.ReadAllText(pathInfo));
            Initialization(jsonInfo);

            #endregion
        }
    }
}