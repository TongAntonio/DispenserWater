using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DispenserWater
{
    public partial class HeaderContentView : ContentView
    {


        public HeaderContentView()
        {
            InitializeComponent();

            lblName.Text = Application.Current.Properties["first_name"].ToString() + " " + Application.Current.Properties["last_name"].ToString();
            lblEmail.Text = Application.Current.Properties["email"].ToString();

            ImageProfile.Source = Application.Current.Properties["picture"].ToString();
        }

      

    }
}
