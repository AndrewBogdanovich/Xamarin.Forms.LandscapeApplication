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
            ViewsForOrientation.AddRange(new List<View> { FirstFrameLayout, SecondFrameLayout, FirstFrame, SecondFrame, ThirdFrame, FourthFrame, Alabel, Blabel, Clabel, Dlabel });
        }
        
    }
}
