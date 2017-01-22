using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Recycler.mCode;

namespace Recycler
{
    [Activity(Label = "Recycler Array", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private RecyclerView rv;
        private MyAdapter adapter;
        private readonly string[] spacecrafts = {"Casini","Enterprise","Juno","Kepler","Spitzer","Curiosity","Voyager","WMAP"};

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //RECYCLERVIEW
            rv = FindViewById<RecyclerView>(Resource.Id.mRecylcerID);

            //SET ITS LAYOUT
            rv.SetLayoutManager(new LinearLayoutManager(this));
            rv.SetItemAnimator(new DefaultItemAnimator());

            //ADAPTER
            adapter = new MyAdapter(spacecrafts);
            rv.SetAdapter(adapter);

        }
    }
}

