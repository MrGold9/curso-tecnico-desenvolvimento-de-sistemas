using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;

namespace AppPesoIdealSpinner1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        LinearLayout = LinearLayout1; 
            Spinner = spnSexo;
            EditText = edtAltura;
            LinearLayout = linearLayout2;
            TextView = lblPI;
            TextView = txtPesoIdeal;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            linearLayout1 = FindViewById<LinearLayout>(Resource.Id.linearLayout1);
            Spinner = FindViewById<Spinner>(Resource.Id.spnSexo);
            edtAltura = FindViewById<EditText>(Resource.Id.edtAltura);
            linearLayout2 = FindViewById<LinearLayout>(Resource.Id.linearLayout2);
            lblPI = FindViewById<TextView>(Resource.Id.lblPI);
            txtPesoIdeal = FindViewById<TextView>(Resource.Id.txtPesoIdeal);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}