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
            foreach (var visualElement in new List<VisualElement>
            {
                FirstFrameLayout, SecondFrameLayout, FirstFrame, SecondFrame, ThirdFrame, FourthFrame, Alabel, Blabel,
                Clabel, Dlabel
            })
            {
                VisualStateManager.GoToState(visualElement, DeviceDisplay.MainDisplayInfo.Orientation.ToString());
            }

            GoToOrientation();
            ViewsForOrientation.AddRange(new List<View> { FirstFrameLayout, SecondFrameLayout, FirstFrame, SecondFrame, ThirdFrame, FourthFrame, Alabel, Blabel, Clabel, Dlabel });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}
