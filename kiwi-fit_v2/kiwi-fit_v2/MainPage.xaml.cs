using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: ExportFont("Ubuntu-Light.ttf", Alias = "Ubuntu")]
[assembly: ExportFont("Ubuntu-Bold.ttf", Alias = "Ubuntu-Bold")]
[assembly: ExportFont("Ubuntu-Regular.ttf", Alias = "Ubuntu-Regular")]
namespace kiwi_fit_v2
{  
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "userInfo.json");
            if (File.Exists(path))
            {
                Navigation.PushModalAsync(new UserPage());
                return;
            }
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "tempInfo.json");
            if(File.Exists(path))
                File.Delete(path);
            InitializeComponent();
            loadingPicture.Source = ImageSource.FromResource("kiwi-fit_v2.startpicture.png");
            loadingPicture.Aspect = Aspect.Fill;
        }

        #region При нажатии кнопки перейти на страницу регистрации
        #endregion
        private async void OnButtonClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Registration(), false);
        }
    }
}
