using DonemProje.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DonemProje.ViewModel
{
    public class AccelerometerViewModel : NotifyPropertyChanged
    {
		public AccelerometerViewModel()
		{
			startBtn = new Command(ButtonStart);
			stopBtn = new Command(ButtonStop);
		}
		private string labelX;
		public string LabelX
		{
			get { return labelX; }
			set { labelX = value; OnPropertyChanged();}
		}
		private string labelY;
		public string LabelY
		{
			get { return labelY; }
			set { labelY = value; OnPropertyChanged();}
		}
		private string labelZ;
		public string LabelZ
		{
			get { return labelZ; }
			set { labelZ = value; OnPropertyChanged();}
		}
		private ICommand startBtn;
		public ICommand StartBtn
		{
			get { return startBtn; }
			set { startBtn = value; }
		}
		private ICommand stopBtn;
		public ICommand StopBtn
		{
			get { return stopBtn; }
			set { stopBtn = value; }
		}
		public void ButtonStart()
		{
			if (Accelerometer.IsMonitoring)
				return;
			Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
			Accelerometer.Start(SensorSpeed.UI);
		}
		private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
		{
			LabelX = e.Reading.Acceleration.X.ToString();
			LabelY = e.Reading.Acceleration.Y.ToString();
			LabelZ = e.Reading.Acceleration.Z.ToString();
		}
		public void ButtonStop()
		{
			if (!Accelerometer.IsMonitoring)
				return;
			Accelerometer.ReadingChanged -= Accelerometer_ReadingChanged;
			Accelerometer.Stop();
		}
	}
}
