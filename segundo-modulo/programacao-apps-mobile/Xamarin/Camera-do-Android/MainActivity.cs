using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Android.Provider;
using Android.Graphics;

namespace Droid_Camera
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ImageView imgView1;
        Button btnCamera;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            btnCamera = FindViewById<Button>(Resource.Id.btnCamera);
            imgView1 = FindViewById<ImageView>(Resource.Id.imgvw1);

            btnCamera.Click += BtnCamera_Click;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data) 
        {
            base.OnActivityResult(requestCode, resultCode, data); 
            global::Android.Graphics.Bitmap bitmap = (Bitmap)data.Extras.Get("data"); 
            imgView1.SetImageBitmap(bitmap); 
        }
        private void BtnCamera_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(MediaStore.ActionImageCapture); StartActivityForResult(intent, 0);
        }
    }
}