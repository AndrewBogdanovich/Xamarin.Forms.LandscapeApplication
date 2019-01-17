using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace OrientationApp.Pages
{
    public partial class MainPage : BasePage
    {
        public MainPage()
        {
            InitializeComponent();
            GoToOrientation();
            ViewsForOrientation.AddRange(new List<View> { ImageLayout, InfoLayout });
        }
        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SecondPage());
        }
    }
}
