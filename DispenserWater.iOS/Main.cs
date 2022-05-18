using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace DispenserWater.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        [Obsolete]
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            //var tabs = new TabbedPage();
            //var page = new NavTestPage() { Title = "Page title" };
            //tabs.Children.Add(new NavigationPage(page) { Title = "Tab title" });



            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
