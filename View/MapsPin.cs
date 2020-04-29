using DonemProje.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace DonemProje.View
{
    public class MapsPin : ContentPage
    {
        public MapsPin()
        {
            Title = "Pins demo";
            Position position = new Position(LoginViewModel.Profile.lat, LoginViewModel.Profile.lon);
            MapSpan mapSpan = new MapSpan(position, 0.01, 0.01);
            Map map = new Map(mapSpan);

            Pin pin = new Pin
            {
                Label = LoginViewModel.Profile.city,
                Address = "Hasan Ferdi Turgutlu Teknoloji Fakültesi",
                Type = PinType.Place,
                Position = position
            };
            map.Pins.Add(pin);
            Content = new StackLayout
            {
                Margin = new Thickness(10),
                Children =
                {
                    map,
                }
            };
        }
    }
}
