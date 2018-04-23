using Android.App;
using Android.Widget;
using Android.OS;

namespace TSUexplorenow
{
    [Activity(Label = "TSUexplorenow", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource 1
            SetContentView(Resource.Layout.Main);
        }
    }
}

