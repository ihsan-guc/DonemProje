using DonemProje.Model;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace DonemProje.View
{
    public class MapsPin : ContentPage
    {
        public MapsPin()
        {
            Title = "Pins demo";
            Position position = new Position(38.5002, 27.7084);
            MapSpan mapSpan = new MapSpan(position, 0.01, 0.01);
            Map map = new Map(mapSpan);

            Pin pin = new Pin
            {
                Label = "Manisa",
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
