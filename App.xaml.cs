using DonemProje.View;
using Xamarin.Forms;
namespace DonemProje
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
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
