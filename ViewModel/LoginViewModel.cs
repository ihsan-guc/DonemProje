using DonemProje.Model;
using DonemProje.View;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Http;
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
        public static Profile Profile;
        private string username;
        public string UserName
        {
            get { return username; }
            set { username = value; OnPropertyChanged(); }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(); }
        }
        private ICommand loginIn;
        public ICommand LoginIn
        {
            get { return loginIn; }
            set { loginIn = value; }
        }
        private string error;
        public string Error
        {
            get { return error; }
            set { error = value; OnPropertyChanged(); }
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
                password = "mobiluygulamagelistirme" /*"mobiluygulamagelistirme",*/
            };
            Uri u = new Uri("http://yusufozgul.com:8282/login");
            var json = JsonConvert.SerializeObject(login);
            HttpContent c = new StringContent(json, Encoding.UTF8, "application/json");
            var t = Task.Run(() => PostURI(u, c));
            t.Wait();
            if (t.Result.ToString() == "")
            {
                Error = "Username ya da Şifre Yanlış...";
            }
            else
            {
                JObject Jsonparse = JObject.Parse(t.Result);
                string jsondata = JsonConvert.SerializeObject(t.Result);
                string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Data.json");
                JsonDataWrite(fileName, jsondata);
                var text = TextReplace(fileName);
                var profile = new Profile()
                {
                    Message = text.Substring(9, 8),
                    success = text.Substring(27, 4),
                    name = text.Substring(42, 5),
                    surname = text.Substring(58, 11),
                    city = text.Substring(77, 6),
                    lat = 38.5002,
                    lon = 27.7084
                };
                Profile = profile;
                await App.Current.MainPage.DisplayAlert("Message", "Sayfaya Yönlendiriliyorsunuz", "Ok");
                await App.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new MainPage()));
            }
        }
        public void JsonDataWrite(string file, string jsondata)
        {
            System.IO.File.WriteAllText(file, jsondata);
        }
        public string TextReplace(string filename)
        {
            string text = File.ReadAllText(filename);
            text = text.Replace("\\", string.Empty);
            text = text.Replace("'\'", string.Empty);
            text = text.Replace("{", string.Empty);
            text = text.Replace("}", string.Empty);
            text = text.Replace(":", string.Empty);
            text = text.Replace("data", string.Empty);
            text = text.Replace("profile", string.Empty);
            text = text.Replace("location", string.Empty);
            text = text.Replace(",", string.Empty);
            text = text.Replace('"', ' ');
            text = text.Trim('"');
            text = text.Trim();
            return text;
        }
    }
}
