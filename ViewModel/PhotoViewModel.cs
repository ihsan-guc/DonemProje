using Plugin.Media;
using System.Windows.Input;
using Xamarin.Forms;

namespace DonemProje.ViewModel
{
    public class PhotoViewModel : NotifyPropertyChanged
    {
        public PhotoViewModel()
        {
            pickPhoto = new Command(AddPickPhoto);
        }
        private ImageSource _img;
        public ImageSource _Img
        {
            get { return _img; }
            set
            { _img = value; OnPropertyChanged(); }
        }
        private ICommand pickPhoto;
        public ICommand PickPhoto
        {
            get { return pickPhoto; }
            set { pickPhoto = value; OnPropertyChanged(); }
        }
        public async void AddPickPhoto()
        {
            await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await App.Current.MainPage.DisplayAlert("UYARI", "Galeriye erişme yetkiniz yok!", "OK");
                return;
            }
            var file = await CrossMedia.Current.PickPhotoAsync();
            if (file == null)
                return;
            _Img = ImageSource.FromStream(() => file.GetStream());
        }

    }
}
