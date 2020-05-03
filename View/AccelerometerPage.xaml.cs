using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DonemProje.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AccelerometerPage : ContentPage
    {
        public AccelerometerPage()
        {
            InitializeComponent();
            this.BindingContext = new AccelerometerViewModel();
        }
        //private void ButtonStart_Clicked(object sender, EventArgs e)
        //{
        //    if (Accelerometer.IsMonitoring)
        //        return;
        //    Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
        //    Accelerometer.Start(SensorSpeed.UI);
        //}
        //private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
        //{
        //    LabelX.Text = e.Reading.Acceleration.X.ToString();
        //    LabelY.Text = e.Reading.Acceleration.Y.ToString();
        //    LabelZ.Text = e.Reading.Acceleration.Z.ToString();
        //}
        //private void ButtonStop_Clicked(object sender, EventArgs e)
        //{
        //    if (!Accelerometer.IsMonitoring)
        //        return;
        //    Accelerometer.ReadingChanged -= Accelerometer_ReadingChanged;
        //    Accelerometer.Stop();
        //}
    }
}