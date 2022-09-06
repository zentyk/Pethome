﻿using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Pethome.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pethome.Droid
{
    [Activity(Label = "Pethome", Icon = "@mipmap/icon", Theme = "@style/theme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize)]
    public class Splashscreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));

            // Create your application here
        }
    }
}