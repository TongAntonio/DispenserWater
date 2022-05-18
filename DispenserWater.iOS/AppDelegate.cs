﻿using System;
using System.Collections.Generic;
using System.Linq;
using Facebook.CoreKit;
using Foundation;
using UIKit;


namespace DispenserWater.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            //Firebase.Core.App.Configure();
            LoadApplication(new App());

            //ApplicationDelegate.SharedInstance.FinishedLaunching(app, options);
            //FacebookLoginButtonRenderer.Init();
            //Profile.EnableUpdatesOnAccessTokenChange(true);
           
            global::Xamarin.Auth.Presenters.XamarinIOS.AuthenticationConfiguration.Init();
            var ignore_chartView = new Microcharts.Forms.ChartView();

            return base.FinishedLaunching(app, options);
        }

        //public override bool OpenUrl(UIApplication application, NSUrl url,string sourceApplication, NSObject annotation)
       // {
          //  return ApplicationDelegate.SharedInstance.OpenUrl(application,
            //         url, sourceApplication, annotation);
        //}
    }
}
