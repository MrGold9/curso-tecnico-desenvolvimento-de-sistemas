using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using System.Collections;
using System;

namespace AppValorVendaRadioButton
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        LinearLayout linearLayout1, linearLayout2;
        EditText edtValor;
        RadioGroup radioGroup1;
        RadioButton rdVista, rdPrazo1, rdPrazo2, rdPrazo3, rdDebito, rdCredito;
        Button btnCalcular;
        TextView lblValor, txtValor;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            linearLayout1 = FindViewById<LinearLayout>(Resource.Id.linearLayout1);
            linearLayout2 = FindViewById<LinearLayout>(Resource.Id.linearLayout2);

            edtValor = FindViewById<EditText>(Resource.Id.edtValor);

            radioGroup1 = FindViewById<RadioGroup>(Resource.Id.radioGroup1);
            rdVista = FindViewById<RadioButton>(Resource.Id.rdVista);
            rdPrazo1 = FindViewById<RadioButton>(Resource.Id.rdPrazo1);
            rdPrazo2 = FindViewById<RadioButton>(Resource.Id.rdPrazo2);
            rdPrazo3 = FindViewById<RadioButton>(Resource.Id.rdPrazo3);
            rdDebito = FindViewById<RadioButton>(Resource.Id.rdDebito);
            rdCredito = FindViewById<RadioButton>(Resource.Id.rdCredito);

            btnCalcular = FindViewById<Button>(Resource.Id.btnCalcular);

            lblValor = FindViewById<TextView>(Resource.Id.lblValor);
            txtValor = FindViewById<TextView>(Resource.Id.txtValor);


            btnCalcular.Click += BtnCalcular_Click;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double valor;


            if (double.TryParse(edtValor.Text, out valor) == false)
            {
                Toast.MakeText(Application.Context,
                    "Você esqueceu de digitar o valor!",
                    ToastLength.Long).Show();
            }

            else if (rdVista.Checked)
            {
                valor = double.Parse(edtValor.Text);
                valor = valor - (valor * 0.1);
                txtValor.Text = valor.ToString();
            }

            else if (rdPrazo1.Checked)
            {
                valor = double.Parse(edtValor.Text);
                valor = valor - (valor * 0.05);
                txtValor.Text = valor.ToString();
            }

            else if (rdPrazo2.Checked)
            {
                valor = double.Parse(edtValor.Text);
                //Mesmo preço
                valor = valor;
                txtValor.Text = valor.ToString();
            }

            else if (rdPrazo3.Checked)
            {
                valor = double.Parse(edtValor.Text);
                valor = valor + (valor * 0.05);
                txtValor.Text = valor.ToString();
            }

            else if (rdDebito.Checked)
            {
                valor = double.Parse(edtValor.Text);
                valor = valor - (valor * 0.08);
                txtValor.Text = valor.ToString();
            }

            else if (rdCredito.Checked)
            {
                valor = double.Parse(edtValor.Text);
                valor = valor - (valor * 0.07);
                txtValor.Text = valor.ToString();
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}