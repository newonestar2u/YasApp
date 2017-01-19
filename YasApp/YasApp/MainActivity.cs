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
            btn.Click += Btn_Click;
            //btn.Click += delegate
            //{
            // AlertDialog.Builder alert = new AlertDialog.Builder(this);

            //    alert.SetTitle("Login");

            //if (string.IsNullOrEmpty(FindViewById<EditText>(Resource.Id.editTextUserId).Text) ||
            //    string.IsNullOrEmpty(FindViewById<EditText>(Resource.Id.editTextPassword).Text))
            //{
            //    alert.SetMessage("User Name & Password can not be empty.");
            //}
            //else
            //{
            //    alert.SetMessage("Hi Dubbi how are you");
            //}
            //alert.SetPositiveButton("Delete", (senderAlert, args) => {
            //    Toast.MakeText(this, "Deleted!", ToastLength.Short).Show();
            //});

            //    //alert.SetNegativeButton("Cancel", (senderAlert, args) => {
            //    //    Toast.MakeText(this, "Cancelled!", ToastLength.Short).Show();
            //    //});

            //    Dialog dialog = alert.Create();
            //    dialog.Show();

            //};
        }

        private void Btn_Click(object sender, System.EventArgs e)
        {
            var fragmentTransaction = FragmentManager.BeginTransaction();
            var login = new DialogLogin();
            login.Show(fragmentTransaction, "Dubbi");
            login.LoginEvent += Login_LoginEvent;
        }

        private void Login_LoginEvent(object sender, EventArgs.LoginArgs e)
        {
            this.FindViewById<TextView>(Resource.Id.text_view_title).Text = "Welcome to Yas app.";
        }
    }
}

