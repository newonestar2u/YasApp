using Android.App;
using Android.Widget;
using Android.OS;

namespace YasApp
{

    [Activity(Label = "YasApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //TextView textView = FindViewById<TextView>(Resource.Id.text_view_title);

            Button btn = FindViewById<Button>(Resource.Id.buttonClick);
            btn.Click += delegate
            {
                AlertDialog.Builder alert = new AlertDialog.Builder(this);

                alert.SetTitle("Login");

                if (string.IsNullOrEmpty(FindViewById<EditText>(Resource.Id.editTextUserId).Text) ||
                    string.IsNullOrEmpty(FindViewById<EditText>(Resource.Id.editTextPassword).Text))
                {
                    alert.SetMessage("User Name & Password can not be empty.");
                }
                else
                {
                    alert.SetMessage("Login Success");
                }
                //alert.SetPositiveButton("Delete", (senderAlert, args) => {
                //    Toast.MakeText(this, "Deleted!", ToastLength.Short).Show();
                //});

                //alert.SetNegativeButton("Cancel", (senderAlert, args) => {
                //    Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
                //});

                Dialog dialog = alert.Create();
                dialog.Show();

            };
        }
    }
}

