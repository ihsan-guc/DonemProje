using Plugin.Media;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DonemProje.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhotoView : ContentPage
    {
        public PhotoView()
        {
            InitializeComponent();
        }
        private async void BtnPickPhoto_Clicked(object sender, System.EventArgs e)
        {
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                DisplayAlert("UYARI", "Galeriye erişme yetkiniz yok!", "OK");
                return;
            }
            var file = await CrossMedia.Current.PickPhotoAsync();

            if (file == null)
                return;

            _img.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
        }
        private async void BtnTakePhoto_Clicked(object sender, System.EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                DisplayAlert("UYARI", "Cihazınızın kamerası aktif değil!", "OK");
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(
                new Plugin.Media.Abstractions.StoreCameraMediaOptions
                {
                    Directory = "MediaPluginPhoto",
                    Name = DateTime.Now + ".jpg",
                    DefaultCamera = Plugin.Media.Abstractions.CameraDevice.Front
                });

            if (file == null)
                return;

            _img.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
        }
    }
}