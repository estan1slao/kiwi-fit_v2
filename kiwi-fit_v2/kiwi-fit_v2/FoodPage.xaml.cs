using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kiwi_fit_v2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FoodPage : ContentPage
	{
		public FoodPage ()
		{
			InitializeComponent ();
            foodPageBackground.Source = ImageSource.FromResource("kiwi-fit_v2.food.png");
            foodPageBackground.Aspect = Aspect.Fill;
            im18.Source = ImageSource.FromResource("kiwi-fit_v2.im18.png");
            im18.Aspect = Aspect.Fill;
            im6.Source = ImageSource.FromResource("kiwi-fit_v2.im6.png");
            im6.Aspect = Aspect.Fill;

            im7.Source = ImageSource.FromResource("kiwi-fit_v2.im7.png");
            im7.Aspect = Aspect.Fill;

            im8.Source = ImageSource.FromResource("kiwi-fit_v2.im8.png");
            im8.Aspect = Aspect.Fill;
            this.BindingContext = this;
        }

        public ObservableCollection<Food> MyFood { get => GetFood(); }

        private ObservableCollection<Food> GetFood()
        {

            return new ObservableCollection<Food>
            {
                new Food{Name = "Киви", Calories = "10", Fats="0", Carb="0", Proteins="0",
                    Picture = "kiwi-fit_v2.kiwi.png"},
                new Food{Name = "Киви", Calories = "10", Fats="0", Carb="0", Proteins="0",
                Picture = "kiwi-fit_v2.kiwi.png"},
                new Food{Name = "Киви", Calories = "10", Fats="0", Carb="0", Proteins="0",
                    Picture = "kiwi-fit_v2.kiwi.png"},
                new Food{Name = "Киви", Calories = "10", Fats="0", Carb="0", Proteins="0",
                    Picture = "kiwi-fit_v2.kiwi.png"},
                new Food{Name = "Яблоко", Calories = "10", Fats="0", Carb="0", Proteins="1",
                    Picture = "kiwi-fit_v2.kiwi.png"}
            };
        }


        public class Food
        {
            public string Name { get; set; }
            public string Calories { get; set; }
            public string Proteins { get; set; }
            public string Fats { get; set; }
            public string Carb { get; set; }
            public string Picture { get; set; }
        }

        private async void GoToChangePage(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new ChangePageOne());
        }

        private async void GoToUserPage(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new UserPage());
        }
    }
}