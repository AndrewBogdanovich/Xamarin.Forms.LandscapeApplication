using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace OrientationApp.Pages
{
    public partial class MainPage : BasePage
    {
        
        public MainPage()
        {
            InitializeComponent();
            VisualStateManager.GoToState(ImageLayout, DeviceDisplay.MainDisplayInfo.Orientation.ToString());
            VisualStateManager.GoToState(InfoLayout, DeviceDisplay.MainDisplayInfo.Orientation.ToString());
            OnOrientationChanged += (sender, orientation) =>
            {
                VisualStateManager.GoToState(ImageLayout, orientation.ToString());
                VisualStateManager.GoToState(InfoLayout, orientation.ToString());
            };
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SecondPage());
        }
    }
}
