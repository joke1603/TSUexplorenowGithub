using Android.App;
using Android.Widget;
using Android.OS;
using Android.Gms.Maps;

namespace TSUexplorenow
{
    [Activity(Label = "TSUexplorenow", MainLauncher = true)]
    public class MainActivity : Activity, IOnMapReadyCallback
    {

        private GoogleMap mMap;

        public void OnMapReady(GoogleMap googleMap)
        {
            throw new System.NotImplementedException();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource 1
            SetContentView(Resource.Layout.Main);
        }

        private void SetUpMap()
        {
            if (mMap == null)
            {
                FragmentManager.FindFragmentById<MapFragment>(Resource.Id.map).GetMapAsync(this);
            }
        }
    }
}

