using Xamarin.Forms.Maps;

namespace DonemProje.Model
{
    public class Profile
    {
        public string Name { get; set; }
        public string surname { get; set; }
        public string City { get; set; }
        public double lat { get; set; }
        public double lon { get; set; }
        public Position Position{ get; set; }
    }
}
