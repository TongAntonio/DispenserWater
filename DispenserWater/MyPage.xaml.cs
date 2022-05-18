using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace DispenserWater
{
    public partial class MyPage : Shell
    {
        public MyPage()
        {
            InitializeComponent();
        }

        void MenuItem_Clicked(System.Object sender, System.EventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () => {
                var result = await this.DisplayAlert("Alert!", "ต้องการออกจากระบบ ?", "Yes", "No");
                if (result)
                {
                    Application.Current.Properties["id"] = null;
                    Application.Current.Properties["first_name"] = null;
                    Application.Current.Properties["last_name"] = null;
                    Application.Current.Properties["email"] = null;
                    Application.Current.Properties["picture"] = null;
                    Application.Current.Properties["Username"] = null;
                    Application.Current.Properties["Password"] = null;

                    App.Current.MainPage = new MainPage();
                }
            });

            
        }
    }
}
