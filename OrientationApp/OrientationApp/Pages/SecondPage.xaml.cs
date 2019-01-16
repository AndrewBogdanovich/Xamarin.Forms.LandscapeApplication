using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrientationApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecondPage : BasePage
	{
		public SecondPage ()
		{
			InitializeComponent ();
		    VisualStateManager.GoToState(layout, DeviceDisplay.MainDisplayInfo.Orientation.ToString());
		    OnOrientationChanged += (sender, orientation) =>
		    {
		        VisualStateManager.GoToState(layout, orientation.ToString());
		    };
        }

	}
}