using System;
using System.Collections.Generic;
using DispenserWater.Helper;
using DispenserWater.Model;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DispenserWater
{
    public partial class Ordering2 : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        KBankHelper kBankHelper = new KBankHelper();

        public int MachineID = 1;
        public string UserID = "";
        public Double latitude;
        public Double longitude;

        public Ordering2()
        {
            InitializeComponent();
        }

        void btnGlass1_Clicked(System.Object sender, System.EventArgs e)
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

                        await firebaseHelper.AddOrder(_Machine.MachineID, UserID, AmountWater, Point);
                        await DisplayAlert("Success", "ทำการสั่งซื้อสำเร็จ", "OK");
                    }

                }
            });
        }

        void btnGlass3_Clicked(System.Object sender, System.EventArgs e)
        {
            int AmountWater = 3;
            int Point = 60;
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

                        await firebaseHelper.AddOrder(_Machine.MachineID, UserID, AmountWater, Point);
                        await DisplayAlert("Success", "ทำการสั่งซื้อสำเร็จ", "OK");
                    }

                }
            });
        }

        void btnGlass5_Clicked(System.Object sender, System.EventArgs e)
        {
            int AmountWater = 5;
            int Point = 100;
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

                        await firebaseHelper.AddOrder(_Machine.MachineID, UserID, AmountWater, Point);
                        await DisplayAlert("Success", "ทำการสั่งซื้อสำเร็จ", "OK");
                    }

                }
            });
        }

        void btnGlass7_Clicked(System.Object sender, System.EventArgs e)
        {
            int AmountWater = 7;
            int Point = 140;
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

                        await firebaseHelper.AddOrder(_Machine.MachineID, UserID, AmountWater, Point);
                        await DisplayAlert("Success", "ทำการสั่งซื้อสำเร็จ", "OK");
                    }

                }
            });
        }

        void btnGlass9_Clicked(System.Object sender, System.EventArgs e)
        {
            int AmountWater = 9;
            int Point = 180;
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

                        await firebaseHelper.AddOrder(_Machine.MachineID, UserID, AmountWater, Point);
                        await DisplayAlert("Success", "ทำการสั่งซื้อสำเร็จ", "OK");
                    }

                }
            });
        }

        void btnGlass2_Clicked(System.Object sender, System.EventArgs e)
        {
            int AmountWater = 2;
            int Point = 180;
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

                        await firebaseHelper.AddOrder(_Machine.MachineID, UserID, AmountWater, Point);
                        await DisplayAlert("Success", "ทำการสั่งซื้อสำเร็จ", "OK");
                    }

                }
            });
        }

        void btnGlass4_Clicked(System.Object sender, System.EventArgs e)
        {
            int AmountWater = 4;
            int Point = 160;
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

                        await firebaseHelper.AddOrder(_Machine.MachineID, UserID, AmountWater, Point);
                        await DisplayAlert("Success", "ทำการสั่งซื้อสำเร็จ", "OK");
                    }

                }
            });
        }

        void btnGlass6_Clicked(System.Object sender, System.EventArgs e)
        {
            int AmountWater = 6;
            int Point = 120;
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

                        await firebaseHelper.AddOrder(_Machine.MachineID, UserID, AmountWater, Point);
                        await DisplayAlert("Success", "ทำการสั่งซื้อสำเร็จ", "OK");
                    }

                }
            });
        }

        void btnGlass8_Clicked(System.Object sender, System.EventArgs e)
        {
            int AmountWater = 8;
            int Point = 160;
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

                        await firebaseHelper.AddOrder(_Machine.MachineID, UserID, AmountWater, Point);
                        await DisplayAlert("Success", "ทำการสั่งซื้อสำเร็จ", "OK");
                    }

                }
            });
        }

        void btnGlass10_Clicked(System.Object sender, System.EventArgs e)
        {
            int AmountWater = 10;
            int Point = 1000;
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

                        await firebaseHelper.AddOrder(_Machine.MachineID, UserID, AmountWater, Point);
                        await DisplayAlert("Success", "ทำการสั่งซื้อสำเร็จ", "OK");
                    }

                }
            });
        }
    }
}
