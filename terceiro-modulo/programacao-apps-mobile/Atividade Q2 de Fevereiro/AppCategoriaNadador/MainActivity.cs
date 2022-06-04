using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace AppCategoriaNadador
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        LinearLayout linearLayout1, linearLayout2;
        RadioGroup radioGroup1;
        RadioButton rdInfA, rdInfB, rdJuvA, rdJuvB, rdSen;
        Button btnClique1;
        TextView lblIdade, lblCategoria, txtCategoria;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            linearLayout1 = FindViewById<LinearLayout>(Resource.Id.linearLayout1);
            linearLayout2 = FindViewById<LinearLayout>(Resource.Id.linearLayout3);

            radioGroup1 = FindViewById<RadioGroup>(Resource.Id.radioGroup1);

            rdInfA = FindViewById<RadioButton>(Resource.Id.rdInfA);
            rdInfB = FindViewById<RadioButton>(Resource.Id.rdInfB);
            rdJuvA = FindViewById<RadioButton>(Resource.Id.rdJuvA);
            rdJuvB = FindViewById<RadioButton>(Resource.Id.rdJuvB);
            rdSen = FindViewById<RadioButton>(Resource.Id.rdSen);

            btnClique1 = FindViewById<Button>(Resource.Id.btnClique);

            lblIdade = FindViewById<TextView>(Resource.Id.lblIdade);
            lblCategoria = FindViewById<TextView>(Resource.Id.lblCategoria);
            txtCategoria = FindViewById<TextView>(Resource.Id.txtCategoria);


            

            btnClique1.Click += BtnClique1_Click;
        }

        private void BtnClique1_Click(object sender, System.EventArgs e)
        {
            if (rdInfA.Checked == true)
            {
                txtCategoria.Text = "Infantil A";
            }

            else if (rdInfB.Checked == true)
            {
                txtCategoria.Text = "Infantil B";
            }

            else if (rdJuvA.Checked == true)
            {
                txtCategoria.Text = "Juvenil A";
            }

            else if (rdJuvB.Checked == true)
            {
                txtCategoria.Text = "Juvenil B";
            }

            else if (rdSen.Checked == true)
            {
                txtCategoria.Text = "Sênior";
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}