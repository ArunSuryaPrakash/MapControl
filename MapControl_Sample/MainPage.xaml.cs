using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MapControl_Sample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void mapControl_Loaded(object sender, RoutedEventArgs e) // sample line
        {
            if(mapControl.Is3DSupported)
            {
                mapControl.Style = MapStyle.Aerial3DWithRoads;
                BasicGeoposition position = new BasicGeoposition();
                position.Latitude = 40.7204;
                position.Longitude = -74.0091;

                Geopoint location = new Geopoint(position);

                MapScene mapScene = MapScene.CreateFromLocationAndRadius(location, 500, 150, 70);
                await mapControl.TrySetSceneAsync(mapScene);

            }
        }
    }
}
