using DonemProje.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DonemProje.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class gRPCPage : ContentPage
    {
        public gRPCPage()
        {
            InitializeComponent();
            this.BindingContext = new gRPCViewModel();
        }
    }
}