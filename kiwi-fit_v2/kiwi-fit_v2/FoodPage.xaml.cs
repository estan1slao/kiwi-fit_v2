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
        ObservableCollection<Food> foods = new ObservableCollection<Food>();
        public FoodPage ()
		{
			InitializeComponent ();
            foodPageBackground.Source = ImageSource.FromResource("kiwi-fit_v2.food.png");
            foodPageBackground.Aspect = Aspect.Fill;
            im6.Source = ImageSource.FromResource("kiwi-fit_v2.im6.png");
            im6.Aspect = Aspect.Fill;

            im7.Source = ImageSource.FromResource("kiwi-fit_v2.im7.png");
            im7.Aspect = Aspect.Fill;

            im8.Source = ImageSource.FromResource("kiwi-fit_v2.im8.png");
            im8.Aspect = Aspect.Fill;

            this.BindingContext = this;

            #region Foods
            foods.Add(new Food { Name = "Гусь", Calories = "371", Fats = "33.62", Carb = "0", Proteins = "15.86" });
            foods.Add(new Food { Name = "Индейка", Calories = "144", Fats = "5.64", Carb = "0.14", Proteins = "21.64" });
            foods.Add(new Food { Name = "Куриная грудка (филе)", Calories = "113", Fats = "1.9 ", Carb = "0.4", Proteins = "23.6" });
            foods.Add(new Food { Name = "Куриный окорочок", Calories = "185", Fats = "11", Carb = "0.1", Proteins = "21.3" });
            foods.Add(new Food { Name = "Куриный фарш", Calories = "143", Fats = "8.1", Carb = "0.04", Proteins = "17.44" });
            foods.Add(new Food { Name = "Курица, цыплята-бройлеры, бедро", Calories = "221", Fats = "16.61", Carb = "0.25", Proteins = "16.52" });
            foods.Add(new Food { Name = "Курица, цыплята-бройлеры, голень", Calories = "161", Fats = "9.2", Carb = "0.11", Proteins = "18.08" });
            foods.Add(new Food { Name = "Курица, цыплята-бройлеры, крылышки", Calories = "191", Fats = "12.85", Carb = "0", Proteins = "17.52" });
            foods.Add(new Food { Name = "Страус, огузок", Calories = "116", Fats = "2.4", Carb = "0", Proteins = "21.99" });
            foods.Add(new Food { Name = "Утка", Calories = "211", Fats = "15.2", Carb = "0", Proteins = "17.42" });
            foods.Add(new Food { Name = "Абрикос", Calories = "48", Fats = "0.39", Carb = "9.12", Proteins = "1.4" });
            foods.Add(new Food { Name = "Ананас", Calories = "52", Fats = "0.1", Carb = "11.8", Proteins = "0.3" });
            foods.Add(new Food { Name = "Апельсин", Calories = "43", Fats = "0.2", Carb = "8.1", Proteins = "0.9" });
            foods.Add(new Food { Name = "Арбуз", Calories = "27", Fats = "0.1", Carb = "5.8", Proteins = "0.7" });
            foods.Add(new Food { Name = "Банан", Calories = "96", Fats = "0.5", Carb = "21", Proteins = "1.5" });
            foods.Add(new Food { Name = "Брусника", Calories = "46", Fats = "0.5", Carb = "8.2", Proteins = "0.7" });
            foods.Add(new Food { Name = "Виноград", Calories = "72", Fats = "0.6", Carb = "15.4", Proteins = "0.6" });
            foods.Add(new Food { Name = "Вишня", Calories = "52", Fats = "0.2", Carb = "10.6", Proteins = "0.8" });
            foods.Add(new Food { Name = "Голубика", Calories = "39", Fats = "0.5", Carb = "6.6", Proteins = "1" });
            foods.Add(new Food { Name = "Гранат", Calories = "72", Fats = "0.6", Carb = "14.5", Proteins = "0.7" });
            foods.Add(new Food { Name = "Грейпфрут", Calories = "35", Fats = "0.2", Carb = "6.5", Proteins = "0.7" });
            foods.Add(new Food { Name = "Груша", Calories = "57", Fats = "0.14", Carb = "12.13", Proteins = "0.36" });
            foods.Add(new Food { Name = "Дыня", Calories = "35", Fats = "0.3", Carb = "7.4", Proteins = "0.6" });
            foods.Add(new Food { Name = "Ежевика", Calories = "43", Fats = "0.49", Carb = "4.31", Proteins = "1.39" });
            foods.Add(new Food { Name = "Инжир", Calories = "54", Fats = "0.2", Carb = "12", Proteins = "0.7" });
            foods.Add(new Food { Name = "Киви", Calories = "47", Fats = "0.4", Carb = "8.1", Proteins = "0.8" });
            foods.Add(new Food { Name = "Клубника", Calories = "41", Fats = "0.4", Carb = "7.5", Proteins = "0.8" });
            foods.Add(new Food { Name = "Клюква", Calories = "46", Fats = "0.13", Carb = "8.37", Proteins = "0.46" });
            foods.Add(new Food { Name = "Крыжовник", Calories = "45", Fats = "0.2", Carb = "9.1", Proteins = "0.7" });
            foods.Add(new Food { Name = "Лайм", Calories = "30", Fats = "0.2", Carb = "7.74", Proteins = "0.7" });
            foods.Add(new Food { Name = "Лимон", Calories = "34", Fats = "0.1", Carb = "3", Proteins = "0.9" });
            foods.Add(new Food { Name = "Личи", Calories = "66", Fats = "0.44", Carb = "15.23", Proteins = "0.83" });
            foods.Add(new Food { Name = "Малина", Calories = "52", Fats = "0.65", Carb = "5.44", Proteins = "1.2" });
            foods.Add(new Food { Name = "Манго", Calories = "60", Fats = "0.38", Carb = "13.38", Proteins = "0.82" });
            foods.Add(new Food { Name = "Мандарин", Calories = "53", Fats = "0.31", Carb = "11.54", Proteins = "0.81" });
            foods.Add(new Food { Name = "Морошка", Calories = "40", Fats = "0.9", Carb = "7.4", Proteins = "0.8" });
            foods.Add(new Food { Name = "Нектарин", Calories = "44", Fats = "0.32", Carb = "8.85", Proteins = "1.06" });
            foods.Add(new Food { Name = "Облепиха", Calories = "82", Fats = "5.4", Carb = "5.7", Proteins = "1.2" });
            foods.Add(new Food { Name = "Персик", Calories = "45", Fats = "0.1", Carb = "9.5", Proteins = "0.9" });
            foods.Add(new Food { Name = "Слива", Calories = "46", Fats = "0.28", Carb = "10.02", Proteins = "0.7" });
            foods.Add(new Food { Name = "Смородина белая", Calories = "42", Fats = "0.2", Carb = "8", Proteins = "0.5" });
            foods.Add(new Food { Name = "Смородина красная", Calories = "43", Fats = "0.2", Carb = "7.7", Proteins = "0.6" });
            foods.Add(new Food { Name = "Смородина черная", Calories = "44", Fats = "0.4", Carb = "7.3", Proteins = "1" });
            foods.Add(new Food { Name = "Хурма", Calories = "67", Fats = "0.4", Carb = "15.3", Proteins = "0.5" });
            foods.Add(new Food { Name = "Черемуха", Calories = "46", Fats = "0", Carb = "10", Proteins = "0" });
            foods.Add(new Food { Name = "Черешня", Calories = "63", Fats = "0.2", Carb = "13.91", Proteins = "1.06" });
            foods.Add(new Food { Name = "Черника", Calories = "57", Fats = "0.33", Carb = "12.09", Proteins = "0.74" });
            foods.Add(new Food { Name = "Шиповник", Calories = "109", Fats = "0.7", Carb = "22.4", Proteins = "1.6" });
            foods.Add(new Food { Name = "Яблоко", Calories = "52", Fats = "0.17", Carb = "11.41", Proteins = "0.26" });
            foods.Add(new Food { Name = "Авокадо", Calories = "160", Fats = "14.66", Carb = "1.83", Proteins = "2" });
            foods.Add(new Food { Name = "Айсберг (салат кочанный)", Calories = "14", Fats = "0.14", Carb = "1.77", Proteins = "0.9" });
            foods.Add(new Food { Name = "Баклажан", Calories = "24", Fats = "0.1", Carb = "4.5", Proteins = "1.2" });
            foods.Add(new Food { Name = "Брокколи", Calories = "34", Fats = "0.37", Carb = "4.04", Proteins = "2.82" });
            foods.Add(new Food { Name = "Кабачок", Calories = "24", Fats = "0.3", Carb = "4.6", Proteins = "0.6" });
            foods.Add(new Food { Name = "Капуста белокачанная", Calories = "25", Fats = "0.1", Carb = "3.3", Proteins = "1.28" });
            foods.Add(new Food { Name = "Картофель", Calories = "77", Fats = "0.4", Carb = "16.3", Proteins = "2" });
            foods.Add(new Food { Name = "Лук зеленый", Calories = "20", Fats = "0.1", Carb = "3.2", Proteins = "1.3" });
            foods.Add(new Food { Name = "Лук репчатый", Calories = "41", Fats = "0.2", Carb = "8.2", Proteins = "1.4" });
            foods.Add(new Food { Name = "Морковь", Calories = "41", Fats = "0.24", Carb = "6.78", Proteins = "0.93" });
            foods.Add(new Food { Name = "Огурец", Calories = "15", Fats = "0.11", Carb = "3.13", Proteins = "0.65" });
            foods.Add(new Food { Name = "Пекинская капуста", Calories = "16", Fats = "0.2", Carb = "2.03", Proteins = "1.2" });
            foods.Add(new Food { Name = "Перец сладкий", Calories = "27", Fats = "0.21", Carb = "5.42", Proteins = "1" });
            foods.Add(new Food { Name = "Петрушка", Calories = "49", Fats = "0.4", Carb = "7.6", Proteins = "3.7" });
            foods.Add(new Food { Name = "Помидор", Calories = "18", Fats = "0.2", Carb = "2.69", Proteins = "0.88" });
            foods.Add(new Food { Name = "Редис", Calories = "20", Fats = "0.1", Carb = "3.4", Proteins = "1.2" });
            foods.Add(new Food { Name = "Репа", Calories = "32", Fats = "0.1", Carb = "6.2", Proteins = "1.5" });
            foods.Add(new Food { Name = "Руккола", Calories = "25", Fats = "0.66", Carb = "2.05", Proteins = "2.58" });
            foods.Add(new Food { Name = "Свекла", Calories = "43", Fats = "0.17", Carb = "6.76", Proteins = "1.61" });
            foods.Add(new Food { Name = "Сельдерей", Calories = "14", Fats = "0.17", Carb = "1.37", Proteins = "0.69" });
            foods.Add(new Food { Name = "Спаржа", Calories = "21", Fats = "0.1", Carb = "3.1", Proteins = "1.9" });
            foods.Add(new Food { Name = "Тыква", Calories = "26", Fats = "0.1", Carb = "6", Proteins = "1" });
            foods.Add(new Food { Name = "Укроп", Calories = "40", Fats = "0.5", Carb = "6.3", Proteins = "2.5" });
            foods.Add(new Food { Name = "Цветная капуста", Calories = "30", Fats = "0.3", Carb = "4.2", Proteins = "2.5" });
            foods.Add(new Food { Name = "Чеснок", Calories = "149", Fats = "0.5", Carb = "29.9", Proteins = "6.5" });
            foods.Add(new Food { Name = "Шпинат", Calories = "23", Fats = "0.3", Carb = "2", Proteins = "2.9" });
            foods.Add(new Food { Name = "Щавель", Calories = "22", Fats = "0.3", Carb = "2.9", Proteins = "1.5" });
            foods.Add(new Food { Name = "Акула", Calories = "130", Fats = "4.51", Carb = "0", Proteins = "20.98" });
            foods.Add(new Food { Name = "Барабулька", Calories = "117", Fats = "3.79", Carb = "0", Proteins = "19.35" });
            foods.Add(new Food { Name = "Белая рыба", Calories = "134", Fats = "5.86", Carb = "0", Proteins = "19.09" });
            foods.Add(new Food { Name = "Горбуша", Calories = "140", Fats = "6.5", Carb = "0", Proteins = "20.5" });
            foods.Add(new Food { Name = "Горбыль", Calories = "119", Fats = "4.93", Carb = "0", Proteins = "17.54" });
            foods.Add(new Food { Name = "Гребешок", Calories = "69", Fats = "0.49", Carb = "3.18", Proteins = "12.06" });
            foods.Add(new Food { Name = "Кальмар", Calories = "100", Fats = "2.2", Carb = "2", Proteins = "18" });
            foods.Add(new Food { Name = "Карп", Calories = "112", Fats = "5.3", Carb = "0", Proteins = "16" });
            foods.Add(new Food { Name = "Кета", Calories = "127", Fats = "5.6", Carb = "0", Proteins = "19" });
            foods.Add(new Food { Name = "Килька", Calories = "137", Fats = "9", Carb = "0", Proteins = "14.1" });
            foods.Add(new Food { Name = "Барабулька", Calories = "117", Fats = "3.79", Carb = "0", Proteins = "19.35" });
            foods.Add(new Food { Name = "Краб", Calories = "82", Fats = "1", Carb = "0", Proteins = "18.2" });
            foods.Add(new Food { Name = "Креветка", Calories = "98", Fats = "1.6", Carb = "0.3", Proteins = "20.5" });
            foods.Add(new Food { Name = "Лещ", Calories = "105", Fats = "4.4", Carb = "0", Proteins = "17.1" });
            foods.Add(new Food { Name = "Лосось (семга)", Calories = "153", Fats = "8.1", Carb = "0", Proteins = "20" });
            foods.Add(new Food { Name = "Маринка", Calories = "112", Fats = "5", Carb = "0", Proteins = "16.8" });
            foods.Add(new Food { Name = "Мидии", Calories = "77", Fats = "2", Carb = "3.3", Proteins = "11.5" });
            foods.Add(new Food { Name = "Минтай", Calories = "72", Fats = "0.9", Carb = "0", Proteins = "15.9" });
            foods.Add(new Food { Name = "Морская капуста", Calories = "24.9", Fats = "0.2", Carb = "3", Proteins = "0.9" });
            foods.Add(new Food { Name = "Налим", Calories = "90", Fats = "0.81", Carb = "0", Proteins = "19.31" });
            foods.Add(new Food { Name = "Окунь", Calories = "91", Fats = "0.92", Carb = "0", Proteins = "19.39" });
            foods.Add(new Food { Name = "Рак", Calories = "77", Fats = "0.95", Carb = "0", Proteins = "15.97" });
            foods.Add(new Food { Name = "Сельдь", Calories = "158", Fats = "9.04", Carb = "0", Proteins = "17.96" });
            foods.Add(new Food { Name = "Семга", Calories = "202", Fats = "12.5", Carb = "0", Proteins = "22.5" });
            foods.Add(new Food { Name = "Скумбрия", Calories = "105", Fats = "4.4", Carb = "0", Proteins = "17.1" });
            foods.Add(new Food { Name = "Треска", Calories = " 69", Fats = "4.4", Carb = "0", Proteins = "17.1" });
            foods.Add(new Food { Name = "Тунец", Calories = "139", Fats = "4.6", Carb = "0", Proteins = "24.4" });
            foods.Add(new Food { Name = "Форель", Calories = "119", Fats = "3.46", Carb = "0", Proteins = "20.48" });
            foods.Add(new Food { Name = "Шука", Calories = "84", Fats = "1.1", Carb = "0", Proteins = "18.4" });
            foods.Add(new Food { Name = "Язь", Calories = "117", Fats = "4.5", Carb = "0", Proteins = "19" });
            foods.Add(new Food { Name = "Яичный белок куриный", Calories = "48", Fats = "0.17", Carb = "1", Proteins = "11.1" });
            foods.Add(new Food { Name = "Яичный желток куриный", Calories = "322", Fats = "26.54", Carb = "3.59", Proteins = "15.86" });
            foods.Add(new Food { Name = "Яйцо куриное", Calories = "143", Fats = "9.51", Carb = "0.72", Proteins = "12.56" });
            foods.Add(new Food { Name = "Булгур", Calories = "342", Fats = "1.33", Carb = "63.37", Proteins = "12.29" });
            foods.Add(new Food { Name = "Гречка", Calories = "346", Fats = "2.71", Carb = "74.95", Proteins = "11.73" });
            foods.Add(new Food { Name = "Лапша яичная", Calories = "384", Fats = "4.44", Carb = "67.97", Proteins = "14.16" });
            foods.Add(new Food { Name = "Макароны из муки 1 сорта", Calories = "333", Fats = "1.6", Carb = "68.4", Proteins = "1.2" });
            foods.Add(new Food { Name = "Манная крупа", Calories = "333", Fats = "1", Carb = "70.6", Proteins = "10.3" });
            foods.Add(new Food { Name = "Овес, зерно", Calories = "316", Fats = "6.2", Carb = "55.1", Proteins = "10" });
            foods.Add(new Food { Name = "Пшеница твердая, зерно", Calories = "339", Fats = "2.47", Carb = "71.13", Proteins = "13.68" });
            foods.Add(new Food { Name = "Рис белый длиннозерный", Calories = "380", Fats = "0.94", Carb = "80.42", Proteins = "7.82" });
            foods.Add(new Food { Name = "Рис белый короткозерный", Calories = "358", Fats = "0.52", Carb = "79.15", Proteins = "6.5" });
            foods.Add(new Food { Name = "Ячневая крупа", Calories = "313", Fats = "1.3", Carb = "65.4", Proteins = "10" });
            foods.Add(new Food { Name = "Баранина", Calories = "209", Fats = "16.3", Carb = "0", Proteins = "15.6" });
            foods.Add(new Food { Name = "Говядина", Calories = "187", Fats = "12.4", Carb = "0", Proteins = "18.9" });
            foods.Add(new Food { Name = "Козлятина", Calories = "109", Fats = "2.31", Carb = "0", Proteins = "20.6" });
            foods.Add(new Food { Name = "Кролик", Calories = "114", Fats = "2.32", Carb = "0", Proteins = "21.79" });
            foods.Add(new Food { Name = "Лось", Calories = "111", Fats = "1.45", Carb = "0", Proteins = "22.95" });
            foods.Add(new Food { Name = "Олень", Calories = "120", Fats = "2.42", Carb = "0", Proteins = "22.96" });
            foods.Add(new Food { Name = "Свинина", Calories = "259", Fats = "21.6", Carb = "0", Proteins = "16" });
            foods.Add(new Food { Name = "Йогурт", Calories = "57", Fats = "1.5", Carb = "5.9", Proteins = "4.1" });
            foods.Add(new Food { Name = "Кефир", Calories = "41", Fats = "0.93", Carb = "4.48", Proteins = "3.27" });
            foods.Add(new Food { Name = "Масло сливочное", Calories = "661", Fats = "72.5", Carb = "1.3", Proteins = "0.8" });
            foods.Add(new Food { Name = "Молоко", Calories = "64", Fats = "3.6", Carb = "4.8", Proteins = "3.2" });
            foods.Add(new Food { Name = "Ряженка", Calories = "62", Fats = "4.88", Carb = "4.9", Proteins = "3.21" });
            foods.Add(new Food { Name = "Сметана", Calories = "136", Fats = "10.6", Carb = "7.1", Proteins = "3.5" });
            foods.Add(new Food { Name = "Сыр", Calories = "364", Fats = "29.5", Carb = "0", Proteins = "23.2" });
            foods.Add(new Food { Name = "Творог", Calories = "155.3", Fats = "9", Carb = "2", Proteins = "16.7" });
            foods.Add(new Food { Name = "Белый гриб", Calories = "34", Fats = "1.7", Carb = "1.1", Proteins = "3.7" });
            foods.Add(new Food { Name = "Груздь", Calories = "16", Fats = "0.8", Carb = "0.5", Proteins = "1.8" });
            foods.Add(new Food { Name = "Лисички", Calories = "32", Fats = "0.53", Carb = "3.06", Proteins = "1.49" });
            foods.Add(new Food { Name = "Маслята", Calories = "9", Fats = "0.7", Carb = "0.5", Proteins = "2.4" });
            foods.Add(new Food { Name = "Опенок", Calories = "22", Fats = "1.2", Carb = "0.5", Proteins = "2.2" });
            foods.Add(new Food { Name = "Подберезовик", Calories = "20", Fats = "0.9", Carb = "1.2", Proteins = "2.3" });
            foods.Add(new Food { Name = "Подосиновик", Calories = "22", Fats = "0.5", Carb = "1.2", Proteins = "3.3" });
            foods.Add(new Food { Name = "Рыжик", Calories = "22", Fats = "0.8", Carb = "0.5", Proteins = "1.9" });
            foods.Add(new Food { Name = "Сморчок", Calories = "31", Fats = "0.57", Carb = "2.3", Proteins = "3.12" });
            foods.Add(new Food { Name = "Сыроежки", Calories = "19", Fats = "0.7", Carb = "1.5", Proteins = "1.7" });
            foods.Add(new Food { Name = "Шампиньоны", Calories = "27", Fats = "1", Carb = "0.1", Proteins = "4.3" });
            foods.Add(new Food { Name = "Грецкий орех", Calories = "656", Fats = "60.08", Carb = "11.1", Proteins = "16.2" });
            foods.Add(new Food { Name = "Кедровый орех", Calories = "673", Fats = "68.37", Carb = "9.38", Proteins = "13.69" });
            foods.Add(new Food { Name = "Кешью", Calories = "600", Fats = "48.5", Carb = "22.5", Proteins = "18.5" });
            foods.Add(new Food { Name = "Миндаль", Calories = "609", Fats = "53.7", Carb = "13", Proteins = "18.6" });
            foods.Add(new Food { Name = "Фундук", Calories = "651", Fats = "61.5", Carb = "9.4", Proteins = "15" });
            foods.Add(new Food { Name = "Хлеб белый", Calories = "266", Fats = "3.3", Carb = "46.7", Proteins = "8.9" });
            foods.Add(new Food { Name = "Хлеб черный", Calories = "201", Fats = "1.4", Carb = "37.7", Proteins = "7.7" });
            #endregion

            // Привязка ItemSource, только в первый раз
            foodListView.ItemsSource = foods;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Фильтрация
            string keyword = searchBar.Text.ToLower();
            var results = foods.Where(f => f.Name.ToLower().Contains(keyword));

            // Привязка ItemSource
            foodListView.ItemsSource = results;
        }

        public class Food
        {
            public string Name { get; set; }
            public string Calories { get; set; }
            public string Proteins { get; set; }
            public string Fats { get; set; }
            public string Carb { get; set; }
        }

        private async void GoToWeekOnePage(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new WeekOne(), false);
        }

        private async void GoToUserPage(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new UserPage(), false);
        }
    }
}