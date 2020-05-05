using DonemProje.ViewModel;
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
            this.BindingContext = new PhotoViewModel();
        }
        private async void BtnTakePhoto_Clicked(object sender, System.EventArgs e)
        {
        }
    }
}