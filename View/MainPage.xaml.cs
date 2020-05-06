using DonemProje.ViewModel;
using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DonemProje.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public ICommand NavigateCommand { get; set; }
        public MainPage()
        {
            InitializeComponent();
            lblheaders.Text = LoginViewModel.Profile.name + " " + LoginViewModel.Profile.surname;
            NavigateCommand = new Command<Type>(async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            });
            BindingContext = this;
        }
    }
}