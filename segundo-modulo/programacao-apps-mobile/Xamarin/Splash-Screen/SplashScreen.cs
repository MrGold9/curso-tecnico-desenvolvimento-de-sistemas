using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Java.Lang;

namespace Splash_Screen
{
    [Activity(Label = "SplashScreen", MainLauncher = true, Theme = "@style/Theme.Splash", NoHistory = true)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Display Splash Screen for 4 Sec  ​

            Thread.Sleep(4000);
            //Start Activity1 Activity  ​

            StartActivity(typeof(MainActivity));
        }
    }
}