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
	public partial class StepInstr1 : ContentPage
	{
		public StepInstr1 ()
		{
			InitializeComponent ();
            stepbg.Source = ImageSource.FromResource("kiwi-fit_v2.stepsbg.png");
            stepbg.Aspect = Aspect.Fill;
            im9.Source = ImageSource.FromResource("kiwi-fit_v2.im9.png");
            im9.Aspect = Aspect.Fill;

            im10.Source = ImageSource.FromResource("kiwi-fit_v2.im10.png");
            im10.Aspect = Aspect.Fill;
        }
	}
}