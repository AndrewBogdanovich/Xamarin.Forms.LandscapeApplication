using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace OrientationApp.Pages
{
    public class BasePage : ContentPage, IDisposable
    {
        protected List<View> ViewsForOrientation = new List<View>();
        public BasePage()
        {
            DeviceDisplay.MainDisplayInfoChanged += OnMainDisplayInfoChanged;
        }

        public void Dispose()
        {
            DeviceDisplay.MainDisplayInfoChanged -= OnMainDisplayInfoChanged;
        }
        void OnMainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            GoToOrientation();
        }

        protected void GoToOrientation()
        {
            foreach (var view in ViewsForOrientation)
            {
                VisualStateManager.GoToState(view, DeviceDisplay.MainDisplayInfo.Orientation.ToString());
            }
        }
    }
}