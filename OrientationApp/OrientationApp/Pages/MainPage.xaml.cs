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
                Clabel, Dlabel, HeaderImage, GridState
            })
            {
                VisualStateManager.GoToState(visualElement, DeviceDisplay.MainDisplayInfo.Orientation.ToString());
            }

            GoToOrientation();
            ViewsForOrientation.AddRange(new List<View> { FirstFrameLayout, SecondFrameLayout, FirstFrame, SecondFrame,
                ThirdFrame, FourthFrame, Alabel, Blabel, Clabel, Dlabel, HeaderImage, GridState });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (Navigation.NavigationStack.Count > 0)
            {
                var pages = Navigation.NavigationStack;
                for (int i = 0; i < pages.Count; i++)
                {
                    if (pages[i] != this)
                    {
                        Navigation.RemovePage(pages[i]);
                    }
                }
            }
        }

        private async void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }
    }
}
