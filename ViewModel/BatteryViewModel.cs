using Xamarin.Essentials;
namespace DonemProje.ViewModel
{
	public class BatteryViewModel : NotifyPropertyChanged
    {
		public BatteryViewModel()
		{
			SetBackGround(Battery.ChargeLevel, Battery.State == BatteryState.Charging);
			LabelBatteryFull = BatteryState.Full.ToString();
			LabelBatteryPower = Battery.PowerSource.ToString();
		}
		private string labelBatteryLevel;
		public string LabelBatteryLevel
		{
			get { return labelBatteryLevel; }
			set { labelBatteryLevel = value; OnPropertyChanged(); }
		}
		private string labelBatteryFull;
		public string LabelBatteryFull
		{
			get { return labelBatteryFull; }
			set { labelBatteryFull = value;OnPropertyChanged(); }
		}
		private string labelBatteryPower;
		public string LabelBatteryPower
		{
			get { return labelBatteryPower; }
			set { labelBatteryPower = value; OnPropertyChanged(); }
		}
		private string backgroundColor;
		public string BackgroundColor
		{
			get { return backgroundColor; }
			set { backgroundColor = value; OnPropertyChanged(); }
		}
		void SetBackGround(double level, bool charging)
		{
			var status = charging ? "Şarj Doluyor" : "Şarj Dolmuyor";
			if (level > .5f)
				BackgroundColor = "Green";
			else if (level > .1f)
				BackgroundColor = "Yellow";
			else
				BackgroundColor = "Red";
			LabelBatteryLevel = status;
		}
	}
}
