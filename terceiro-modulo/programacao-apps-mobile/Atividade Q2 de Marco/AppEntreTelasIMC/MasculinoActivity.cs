using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AndroidX.AppCompat.App;


namespace AppEntreTelasIMC
{
    [Activity(Label = "MasculinoActivity", Theme = "@style/AppTheme")]
    public class MasculinoActivity : AppCompatActivity
    {
        TextView lblEscolhaMas, lblImcMas, txtImcMas;
        EditText edtPesoMas, edtAlturaMas;
        Button btnResultadoMas;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_Masculino);


            lblEscolhaMas = FindViewById<TextView>(Resource.Id.lblEscolhaMas);
            lblImcMas = FindViewById<TextView>(Resource.Id.lblImcMas);
            txtImcMas = FindViewById<TextView>(Resource.Id.txtImcMas);

            edtPesoMas = FindViewById<EditText>(Resource.Id.edtPesoMas);
            edtAlturaMas = FindViewById<EditText>(Resource.Id.edtAlturaMas);

            btnResultadoMas = FindViewById<Button>(Resource.Id.btnResultadoMas);


            btnResultadoMas.Click += BtnResultadoMas_Click;
        }

        private void BtnResultadoMas_Click(object sender, EventArgs e)
        {
            int peso=0;
            double altura=0, imc=0;


            //Teste de exceções
            if (int.TryParse(edtPesoMas.Text, out peso) == false &&
                double.TryParse(edtAlturaMas.Text, out altura) == false)
            {
                Toast.MakeText(Application.Context,
                    "Digite os valores para obter um resultado!",
                    ToastLength.Long).Show();
            }
            else if (int.TryParse(edtPesoMas.Text, out peso) == false)
            {
                Toast.MakeText(Application.Context,
                    "Você esqueceu de digitar o peso!",
                    ToastLength.Long).Show();
            }
            else if (double.TryParse(edtAlturaMas.Text, out altura) == false)
            {
                Toast.MakeText(Application.Context,
                    "Você esqueceu de digitar a altura!",
                    ToastLength.Long).Show();
            }

            imc = peso / (altura * altura);

            txtImcMas.Text = imc.ToString();

            //Verificando IMC
            if (imc < 18.5)
            {
                Toast.MakeText(Application.Context, "Abaixo do peso", ToastLength.Long).Show();
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Toast.MakeText(Application.Context, "Peso normal", ToastLength.Long).Show();
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Toast.MakeText(Application.Context, "Sobrepeso", ToastLength.Long).Show();
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Toast.MakeText(Application.Context, "Obesidade grau 1", ToastLength.Long).Show();
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Toast.MakeText(Application.Context, "Obesidade grau 2", ToastLength.Long).Show();
            }
            else if (imc >= 40)
            {
                Toast.MakeText(Application.Context, "Obesidade grau 3", ToastLength.Long).Show();
            }
        }
    }
}