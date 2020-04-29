using DonemProje.View;
using Xamarin.Essentials;
using Xamarin.Forms;
namespace DonemProje
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            VersionTracking.Track();
            MainPage = new LoginView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }
        protected override void OnResume()
        {
        }
    }
}
