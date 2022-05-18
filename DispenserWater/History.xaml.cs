using System;
using System.Collections.Generic;
using DispenserWater.Model;
using Xamarin.Forms;
using DispenserWater.Helper;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Microcharts;
using System.Linq;

namespace DispenserWater
{
    public partial class History : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public List<Order> orders;
        private static readonly Random rand = new Random();

        public History()
        {
            InitializeComponent();

            string userID = Application.Current.Properties["id"].ToString();

            GetHistoryOrderByUserID(userID);
        }

        public async void GetHistoryOrderByUserID(string userID)
        {
            List<Order> orders = new List<Order>();
            orders = await firebaseHelper.GetHistoryOrderByUserID(userID);
            CollectionViewOrder.ItemsSource = orders;
        }

    }
}
