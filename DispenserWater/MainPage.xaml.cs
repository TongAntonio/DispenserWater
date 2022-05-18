using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DispenserWater.Model;
using Xamarin.Forms;
using Xamarin.Essentials;
using System.Diagnostics;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.Threading;
using Xamarin.Auth;
using System.Net.Http;
using DispenserWater.Helper;

namespace DispenserWater
{
    public partial class MainPage : ContentPage
    {

        
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var username = Username.Text;
            var password = Password.Text;

            var chk = CheckUser(username, password).Result;

            if (chk)
            {
                App.Current.MainPage = new MyPage();
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("กรุณากรอก Username และ Password ให้ถูกต้อง", "", "OK");
            }
        }

        public async Task<bool> CheckUser(string username, string password)
        {
            FirebaseHelper firebaseHelper = new FirebaseHelper();
            List<User> _user = new List<User>();
            _user = await firebaseHelper.GetUserDetailByUsernameAndPassword(username, password);

            if (_user != null)
            {
                Application.Current.Properties["id"] = _user[0].UserID;
                Application.Current.Properties["first_name"] = _user[0].Firstname;
                Application.Current.Properties["last_name"] = _user[0].Surname;
                Application.Current.Properties["email"] = _user[0].Email;
                Application.Current.Properties["picture"] = _user[0].Picture;
                return true;
            }
            else
            {
                Username.Text = "";
                Password.Text = "";
                return false;
            }
        }

        private void btnLoginFacebook_Clicked(System.Object sender, System.EventArgs e)
        {
            string clientId = Constants.FacebookClientID;

            var Authenticator = new OAuth2Authenticator(clientId, Constants.FacebookScope, new Uri(Constants.FacebookAuthorizeUrl), new Uri(Constants.FacebookIOSRedirectUrl), null, false);

            Authenticator.AllowCancel = true;

            var presenter = new Xamarin.Auth.Presenters.OAuthLoginPresenter();
            presenter.Login(Authenticator);

            Authenticator.Completed += async (senders, obj) =>
            {
                if (obj.IsAuthenticated)
                {
                    var clientData = new HttpClient();
                    var token = obj.Account.Properties["access_token"];

                    //call facebook api to fetch logged in user profile info 
                    var resData = await clientData.GetAsync("https://graph.facebook.com/me?fields=id,first_name,last_name,email,picture&access_token=" + token);
                    var jsonData = await resData.Content.ReadAsStringAsync();

                    // deserlize the jsondata and intilize in facebook AuthClass
                    Facebook facebookObject = JsonConvert.DeserializeObject<Facebook>(jsonData);

                    //you can access following property after login
                    string id = facebookObject.id;
                    string first_name = facebookObject.first_name;
                    string last_name = facebookObject.last_name;
                    string email = facebookObject.email;
                    facebookObject.Picture = facebookObject.Picture;
                    var picture = facebookObject.Picture;

                    FirebaseHelper firebaseHelper = new FirebaseHelper();

                    Int64 _id = Convert.ToInt64(id);
                    _ = firebaseHelper.AddUser(_id, first_name, last_name, email, picture.Data.Url);

                    

                    Application.Current.Properties["id"] = id;
                    Application.Current.Properties["first_name"] = first_name;
                    Application.Current.Properties["last_name"] = last_name;
                    Application.Current.Properties["email"] = email;

                    Application.Current.Properties["Username"] = email;
                    Application.Current.Properties["Password"] = "1234";

                    Application.Current.Properties["picture"] = picture.Data.Url;

                    //firebaseHelper.AddMachine(1,"001", "ตู้กดน้ำศูนย์อาหารคณะวิทยาศาสตร์", 20, 1, 13.846024498103802, 100.57125601265548);
                    //firebaseHelper.AddMachine(2,"002", "ตู้กดน้ำ Standup Condo ", 50, 0, 13.890082400029069, 100.61171567133441);
                    //firebaseHelper.AddMachine(3,"003", "ตู้กดน้ำ 7-Eleven คณะวิทยาศาสตร์", 20, 0, 13.845761208588879, 100.57100020109708);

                    App.Current.MainPage = new MyPage();
                }
                else
                {
                    //Authentication fail
                    // write the code to handle when auth failed
                   _ = DisplayAlert("Facebook Authentication Error", "Please contact administrator", "OK");
                }
            };
            //Authenticator.Error += onAuthError;

        }

        private void onAuthError(object sender, AuthenticatorErrorEventArgs e)
        {
            DisplayAlert("Facebook Authentication Error", e.Message, "OK");
        }

        
    }
}
