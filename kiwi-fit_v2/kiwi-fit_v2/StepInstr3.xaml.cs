using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kiwi_fit_v2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StepInstr3 : ContentPage
    {
        public StepInstr3()
        {
            InitializeComponent();
            stepbg.Source = ImageSource.FromResource("kiwi-fit_v2.stepsbg.png");
            stepbg.Aspect = Aspect.Fill;

            menuPic.Source = ImageSource.FromResource("kiwi-fit_v2.menu.png");
            menuPic.Aspect = Aspect.Fill;
        }

        private async void OnButtonClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new UserPage(), false);
        }
    }
}