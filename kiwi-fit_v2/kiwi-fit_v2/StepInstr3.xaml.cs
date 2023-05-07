using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kiwi_fit_v2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StepInstr3 : ContentPage
	{
		public StepInstr3 ()
		{
			InitializeComponent ();
            stepbg.Source = ImageSource.FromResource("kiwi-fit_v2.stepsbg.png");
            stepbg.Aspect = Aspect.Fill;

            menuPic.Source = ImageSource.FromResource("kiwi-fit_v2.menu.png");
            menuPic.Aspect = Aspect.Fill;
        }
	}
}