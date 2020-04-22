using DonemProje.Model;
using System;
using System.Collections.Generic;
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
            MessagingCenter.Unsubscribe<Profile>(this, "Names");
            MessagingCenter.Subscribe<Profile>(this, "Names", (value) =>
            {
                lblheaders.TextColor = Color.Red;
                lblheaders.Text = value.name + " " + value.surname;
                MessagingCenter.Unsubscribe<Profile>(this, "Names");
            });
            NavigateCommand = new Command<Type>(async (Type pageType) =>
            {
                Page page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            });
            BindingContext = this;
        }
    }
}