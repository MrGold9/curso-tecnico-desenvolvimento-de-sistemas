using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using System;

namespace AppPesoIdeal
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        LinearLayout linearLayout1, linearLayout2;
        RadioGroup radioGroup1;
        RadioButton rdHomem, rdMulher;
        EditText edtAltura;
        Button btnResultado;
        TextView lblPesoIdeal, txtPesoIdeal, lblKg;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            linearLayout1 = FindViewById<LinearLayout>(Resource.Id.linearLayout1);
            linearLayout2 = FindViewById<LinearLayout>(Resource.Id.linearLayout2);
            radioGroup1 = FindViewById<RadioGroup>(Resource.Id.radioGroup1);
            rdHomem = FindViewById<RadioButton>(Resource.Id.rdHomem);
            rdMulher = FindViewById<RadioButton>(Resource.Id.rdMulher);
            edtAltura = FindViewById<EditText>(Resource.Id.edtAltura);
            btnResultado = FindViewById<Button>(Resource.Id.btnResultado);
            lblPesoIdeal = FindViewById<TextView>(Resource.Id.lblPesoIdeal);
            txtPesoIdeal = FindViewById<TextView>(Resource.Id.txtPesoIdeal);
            lblKg = FindViewById<TextView>(Resource.Id.lblKg);


            btnResultado.Click += BtnResultado_Click;
        }


        private void BtnResultado_Click(object sender, EventArgs e)
        {
            double altura, peso;


            if (rdHomem.Checked == false && rdMulher.Checked == false)
            {
                Toast.MakeText(Application.Context,
                    "Selecione se você é homem ou mulher!",
                    ToastLength.Short).Show();
            }

            if (edtAltura.Text.Length == 0)
            {
                Toast.MakeText(Application.Context,
                    "Digite a sua altura!",
                    ToastLength.Short).Show();
            }

            else if (rdHomem.Checked == true || rdMulher.Checked == true) 
            {
                altura = double.Parse(edtAltura.Text.Replace(".", ","));

                if (double.TryParse(edtAltura.Text, out altura) == true && rdHomem.Checked)
                {
                    peso = (72.7 * altura) - 58;
                    txtPesoIdeal.Text = peso.ToString();
                }
                else if (double.TryParse(edtAltura.Text, out altura) == true && rdMulher.Checked)
                {
                    peso = (62.1 * altura) - 44.7;
                    txtPesoIdeal.Text = peso.ToString();
                }
            }

        }



        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}