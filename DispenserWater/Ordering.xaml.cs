using System;
using System.Collections.Generic;
using Firebase.Database;
using Xamarin.Forms;
using DispenserWater.Helper;
using System.Threading.Tasks;
using Xamarin.Essentials;
using System.Threading;
using DispenserWater.Model;

namespace DispenserWater
{
    public partial class Ordering : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        KBankHelper kBankHelper = new KBankHelper();
        
        public int MachineID = 1;
        public string UserID = "";
        public Double latitude;
        public Double longitude;

        public Ordering()
        {
            InitializeComponent();
        }

        private void btnGlass1_Clicked(System.Object sender, System.EventArgs e)
        {
            int AmountWater = 1;
            int Point = 20;
            UserID = Application.Current.Properties["id"].ToString();

            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Alert!", "ชำระเงินตามรายการที่สั่งซื้อและทำรายการการสั่งซื้อ?", "Yes", "No");
                if (result)
                {
                    var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                    var location = await Geolocation.GetLocationAsync(request);

                    if (location != null)
                    {
                        latitude = Convert.ToDouble(location.Latitude.ToString());
                        longitude = Convert.ToDouble(location.Longitude.ToString());
                        Machine _Machine = new Machine();
                        _Machine = await firebaseHelper.CheckAvailableMachineAsync(latitude, longitude);

                        //if (_Machine.MachineID != 0)
                        //{
                            //await firebaseHelper.AddOrder(_Machine.MachineID, UserID, AmountWater, Point);
                        await firebaseHelper.AddOrder(1, UserID, AmountWater, Point);
                        await DisplayAlert("Success", "ทำการสั่งซื้อสำเร็จ", "OK");
                        //}
                        //else
                        //{
                         //   await DisplayAlert("Failture", "คุณไม่ได้อยู่ในระยะที่ตั้งของตู้กดน้ำ", "OK");
                        //}
                    }

                }
            });
        }

        void btnGlass3_Clicked(System.Object sender, System.EventArgs e)
        {
        }

        void btnGlass5_Clicked(System.Object sender, System.EventArgs e)
        {
        }

        void btnGlass7_Clicked(System.Object sender, System.EventArgs e)
        {
        }

        void btnGlass9_Clicked(System.Object sender, System.EventArgs e)
        {
        }

        void btnGlass2_Clicked(System.Object sender, System.EventArgs e)
        {
        }

        void btnGlass4_Clicked(System.Object sender, System.EventArgs e)
        {
        }

        void btnGlass6_Clicked(System.Object sender, System.EventArgs e)
        {
        }

        void btnGlass8_Clicked(System.Object sender, System.EventArgs e)
        {
        }

        void btnGlass10_Clicked(System.Object sender, System.EventArgs e)
        {
        }
    }
}
