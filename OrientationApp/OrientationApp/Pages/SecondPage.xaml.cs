using Xamarin.Forms.Xaml;

namespace OrientationApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecondPage : BasePage
	{
	    public SecondPage ()
		{
			InitializeComponent ();
            ViewsForOrientation.Add(layout);
            GoToOrientation();
        }
	}
}