using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrientationApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : BasePage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		    foreach (var visualElement in new List<VisualElement>
		    {
		        CredLayout
		    })
		    {
		        VisualStateManager.GoToState(visualElement, DeviceDisplay.MainDisplayInfo.Orientation.ToString());
		    }
		    ViewsForOrientation.Add(CredLayout);
		    GoToOrientation();
        }

	    private async void Button_OnClicked(object sender, EventArgs e)
	    {
	        await Navigation.PushAsync(new MainPage());
	    }
	}
}