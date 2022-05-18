using System;
using System.Collections.Generic;
using System.Linq;
using DispenserWater.Helper;
using DispenserWater.Model;
using Microcharts;
using Xamarin.Forms;

namespace DispenserWater
{
    public partial class Charts : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public List<Order> orders;
        private static readonly Random rand = new Random();

        public Charts()
        {
            InitializeComponent();

            string userID = Application.Current.Properties["id"].ToString();

            GetHistoryOrderByUserID(userID);
        }

        public async void GetHistoryOrderByUserID(string userID)
        {
            List<Order> orders = new List<Order>();
            orders = await firebaseHelper.GetHistoryOrderByUserID(userID);

            List<Microcharts.ChartEntry> entries = new List<Microcharts.ChartEntry>();
            if (orders != null)
            {
                var QueryOrder = orders.GroupBy(u => u.PurchaseDateTime.Date)
                                    .Select(x => new
                                    {
                                        PurchaseDate = x.Key,
                                        Count = x.Count(),
                                        Amount = x.Sum(ta => ta.AmountWater)
                                    }).ToList();

                for (int i = 0; i < QueryOrder.Count; i++)
                {
                    Microcharts.ChartEntry chartEntry = new Microcharts.ChartEntry(QueryOrder[i].Amount);
                    chartEntry.Label = QueryOrder[i].PurchaseDate.ToLongDateString();
                    chartEntry.ValueLabel = QueryOrder[i].Amount.ToString();
                    chartEntry.Color = SkiaSharp.SKColor.Parse(GetRandomColour().ToHex());
                    entries.Add(chartEntry);
                }

                ChartRadialGaugeChart.Chart = new RadialGaugeChart { Entries = entries };
                ChartLineChart.Chart = new LineChart { Entries = entries };
                ChartDonutChart.Chart = new DonutChart { Entries = entries };
                ChartBarChart.Chart = new BarChart { Entries = entries };

            }
        }

        private Color GetRandomColour()
        {
            return Color.FromRgb(rand.Next(256), rand.Next(256), rand.Next(256));
        }
    }
}
