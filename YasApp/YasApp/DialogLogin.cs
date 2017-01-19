using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using YasApp.EventArgs;

namespace YasApp
{
    class DialogLogin : DialogFragment
    {
        private string userId, password;
        View view;
        public event EventHandler<LoginArgs> LoginEvent;
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            var view = inflater.Inflate(Resource.Layout.Login, container, false);


            var button = view.FindViewById<Button>(Resource.Id.buttonClick);

            button.Click += Button_Click;

            this.view = view;
            return view;
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            AlertDialog.Builder alert = new AlertDialog.Builder(view.Context);
            alert.SetTitle("Login");
            userId = view.FindViewById<EditText>(Resource.Id.editTextUserId).Text;
            password = view.FindViewById<EditText>(Resource.Id.editTextPassword).Text;

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(password))
            {
                alert.SetMessage("User Name & Password can not be empty.");
                Dialog dialog = alert.Create();
                dialog.Show();
            }
            else
            {
                //alert.SetMessage("Hi Dubbi how are you");
                //Dialog dialog = alert.Create();
                //dialog.Show();
                if (LoginEvent != null)
                    LoginEvent.Invoke(this, new LoginArgs() { IsLoggedIn = true });
                Dialog.Dismiss();
            }
        }
    }
}