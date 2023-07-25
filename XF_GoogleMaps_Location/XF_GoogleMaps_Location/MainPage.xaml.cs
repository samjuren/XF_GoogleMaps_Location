using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace XF_GoogleMaps_Location
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Pin pinPaulista = new Pin()
            {
                Label="Paulista",
                Position = new Position(-23.4914908, -46.718843)
            };

            maps.Pins.Add(pinPaulista);
            maps.MoveToRegion(MapSpan.FromCenterAndRadius(pinPaulista.Position, Distance.FromMeters(1000)));
        }
    }
}
    