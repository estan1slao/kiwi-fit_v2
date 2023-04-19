using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: ExportFont("Ubuntu-Bold.ttf", Alias = "Ubuntu")]
namespace kiwi_fit_v2
{  
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            loadingPicture.Source = ImageSource.FromResource("kiwi-fit_v2.startpicture.png");
            loadingPicture.Aspect = Aspect.Fill;
        }

        private async void OnButtonClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new Registration());
        }
    }
}
