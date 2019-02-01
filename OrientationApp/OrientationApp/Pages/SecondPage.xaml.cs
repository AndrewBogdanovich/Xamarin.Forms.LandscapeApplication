using System.Collections.Generic;
using OrientationApp.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrientationApp.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SecondPage : BasePage
	{
	    public List<Article> Articles { get; set; }
        public SecondPage ()
		{
			InitializeComponent ();
		    foreach (var visualElement in new List<VisualElement>
		    {
		        FlowList
            })
		    {
		        VisualStateManager.GoToState(visualElement, DeviceDisplay.MainDisplayInfo.Orientation.ToString());
		    }
            ViewsForOrientation.Add(FlowList);
            GoToOrientation();
        }

	    protected override void OnAppearing()
	    {
	        base.OnAppearing();
	        SetData();
            FlowList.FlowItemsSource = Articles;
	    }
	    public void SetData()
	    {
	        Articles = new List<Article>();
	        Articles.Add(new Article() { Title = "news1", Description = "description1" });
	        Articles.Add(new Article() { Title = "news2", Description = "description2" });
	        Articles.Add(new Article() { Title = "news3", Description = "description3" });
	        Articles.Add(new Article() { Title = "news4", Description = "description4" });
	        Articles.Add(new Article() { Title = "news5", Description = "description5" });
	        Articles.Add(new Article() { Title = "news6", Description = "description6" });
	        Articles.Add(new Article() { Title = "news7", Description = "description7" });
	        Articles.Add(new Article() { Title = "news8", Description = "description8" });
	        Articles.Add(new Article() { Title = "news9", Description = "description9" });
	        Articles.Add(new Article() { Title = "news10", Description = "description10" });
	        Articles.Add(new Article() { Title = "news11", Description = "description11" });
	    }
    }
}