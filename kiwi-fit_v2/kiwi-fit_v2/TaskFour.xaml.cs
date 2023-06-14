using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kiwi_fit_v2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskFour : ContentPage
    {
        public TaskFour()
        {
            InitializeComponent();
            im16.Source = ImageSource.FromResource("kiwi-fit_v2.im17.png");
            im16.Aspect = Aspect.Fill;

            im17.Source = ImageSource.FromResource("kiwi-fit_v2.im17.png");
            im17.Aspect = Aspect.Fill;

            im18.Source = ImageSource.FromResource("kiwi-fit_v2.im17.png");
            im18.Aspect = Aspect.Fill;

            im19.Source = ImageSource.FromResource("kiwi-fit_v2.im17.png");
            im19.Aspect = Aspect.Fill;
        }
    }
}