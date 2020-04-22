using DonemProje.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DonemProje.ViewModel
{
    public class LoginViewModel : NotifyPropertyChanged
    {
        public LoginViewModel()
        {
            loginIn = new Command(LoginControl);
        }
        private string username;

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private ICommand loginIn;

        public ICommand LoginIn
        {
            get { return loginIn; }
            set { loginIn = value; }
        }
        static async Task<string> PostURI(Uri u, HttpContent c)
        {
            var response = string.Empty;
            using (var client = new HttpClient())
            {
                HttpResponseMessage result = await client.PostAsync(u, c);
                if (result.IsSuccessStatusCode)
                {
                    response = await result.Content.ReadAsStringAsync();
                }
            }
            return response;
        }
        public async void LoginControl()
        {
            var login = new Login()
            {
                username = "mobil",
                password = "mobiluygulamagelistirme",
            };
            Uri u = new Uri("http://yusufozgul.com:8282/login");
            var json = JsonConvert.SerializeObject(login);
            HttpContent c = new StringContent(json, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(u, c));
            t.Wait();
            if (t.Result.ToString() == "")
            {
                App.Current.MainPage.DisplayAlert("Message", "username veya password yanlış", "Ok");
            }
            else
            {
                string jsondata = JsonConvert.SerializeObject(t.Result);
                var deger = (string)jsondata[0].ToString();
                //write string to file
                App.Current.MainPage.DisplayAlert("Message", "Sayfaya Yönlendiriliyorsunuz", "Ok");
            }
        }
    }
}
