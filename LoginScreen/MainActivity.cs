using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views;

namespace LoginScreen
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            SupportActionBar.Title = "iNN Diary";
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_items, menu);
            return base.OnCreateOptionsMenu(menu);
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int i = item.ItemId;
            if(i==Resource.Id.close)
            {
                Android.App.AlertDialog.Builder closing = new Android.App.AlertDialog.Builder(this);
                closing.SetTitle("Closing Application");
                closing.SetMessage("Do you want to close iNN Diary now?");
                closing.SetPositiveButton("Yes", delegate
                {
                    this.Finish();
                });
                closing.SetNegativeButton("No", delegate
                {
                    //do nothing here

                });

                Android.App.AlertDialog alert = closing.Create();
                alert.Show();
            }
            return base.OnOptionsItemSelected(item);
        }
    }
}