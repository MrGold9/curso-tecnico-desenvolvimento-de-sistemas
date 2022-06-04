using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Webkit;

namespace usandoWebView
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        EditText txtURL;
        Button btnOk;
        WebView webView1;
        string url;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            txtURL = FindViewById<EditText>(Resource.Id.txtURL);
            btnOk = FindViewById<Button>(Resource.Id.btnOk);
            webView1 = FindViewById<WebView>(Resource.Id.webView1);

            btnOk.Click += BtnOk_Click;

        }

        private void BtnOk_Click(object sender, System.EventArgs e)
        {
            webView1.SetWebViewClient(new MeuWebViewClient());
            url = txtURL.Text;
            if (!url.Contains("http://"))
            {
                url = "https://" + url;
            }
            webView1.LoadUrl(url);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}