using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace OrientationApp.Pages
{
    public class BasePage : ContentPage
    {
        public event EventHandler<DisplayOrientation> OnOrientationChanged;

        public BasePage()
        {
            DeviceDisplay.MainDisplayInfoChanged += OnMainDisplayInfoChanged;
        }
        void OnMainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            OnOrientationChanged?.Invoke(this, e.DisplayInfo.Orientation);
            Debug.WriteLine(e.DisplayInfo.Orientation.ToString());
        }
        
    }
}