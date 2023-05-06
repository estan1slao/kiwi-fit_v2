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
	public partial class StepInstr2 : ContentPage
	{
		public StepInstr2 ()
		{
			InitializeComponent ();
            step2bg.Source = ImageSource.FromResource("kiwi-fit_v2.step2bg.png");
            step2bg.Aspect = Aspect.Fill;

            im9.Source = ImageSource.FromResource("kiwi-fit_v2.im9.png");
            im9.Aspect = Aspect.Fill;

            im10.Source = ImageSource.FromResource("kiwi-fit_v2.im10.png");
            im10.Aspect = Aspect.Fill;
        }
	}
}