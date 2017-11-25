using Android.App;
using Android.Widget;
using Android.OS;

namespace Hackathon_App
{
    [Activity(Label = "Hackathon_App", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            var gridview = FindViewById<GridView>(Resource.Id.gridview);
            gridview.Adapter = new MyImageAdapter(this);

            gridview.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                Toast.MakeText(this, args.Position.ToString(), ToastLength.Short).Show();
            };
        }
    }
}

