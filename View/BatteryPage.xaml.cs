using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DonemProje.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BatteryPage : ContentPage
    {
        public BatteryPage()
        {
            InitializeComponent();
            SetBackGround(Battery.ChargeLevel,Battery.State == BatteryState.Charging);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Battery.BatteryInfoChanged += Battery_BatteryInfoChanged;
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Battery.BatteryInfoChanged -= Battery_BatteryInfoChanged;
        }
        private void Battery_BatteryInfoChanged(object sender, BatteryInfoChangedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
        void SetBackGround(double level, bool charging)
        {
            Color? color = null;

            var status = charging ? "Charging" : "Not charging";
            if (level > .5f)
                color = Color.Green.MultiplyAlpha(level);
            else if (level > .1f)
                color = Color.Yellow.MultiplyAlpha(level);
            else
                color = Color.Red.MultiplyAlpha(level);

            BackgroundColor = color.Value;
            LabelBatteryLevel.Text = status;

        }
    }
}