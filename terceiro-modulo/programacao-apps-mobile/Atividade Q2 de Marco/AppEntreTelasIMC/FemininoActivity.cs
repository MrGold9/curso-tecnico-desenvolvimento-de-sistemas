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
    [Activity(Label = "FemininoActivity", Theme = "@style/AppTheme")]
    public class FemininoActivity : AppCompatActivity
    {
        TextView lblEscolhaFem, lblImcFem, txtImcFem;
        EditText edtPesoFem, edtAlturaFem;
        Button btnResultadoFem;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            lblEscolhaFem = FindViewById<TextView>(Resource.Id.lblEscolhaFem);
            lblImcFem = FindViewById<TextView>(Resource.Id.lblImcFem);
            txtImcFem = FindViewById<TextView>(Resource.Id.txtImcFem);

            edtPesoFem = FindViewById<EditText>(Resource.Id.edtPesoFem);
            edtAlturaFem = FindViewById<EditText>(Resource.Id.edtAlturaFem);

            btnResultadoFem = FindViewById<Button>(Resource.Id.btnResultadoFem);


            btnResultadoFem.Click += BtnResultadoFem_Click;
        }

        private void BtnResultadoFem_Click(object sender, EventArgs e)
        {
            int peso = 0;
            double altura = 0, imc = 0;


            //Teste de exceções
            if (int.TryParse(edtPesoFem.Text, out peso) == false &&
                double.TryParse(edtAlturaFem.Text, out altura) == false)
            {
                Toast.MakeText(Application.Context,
                    "Digite os valores para obter um resultado!",
                    ToastLength.Long).Show();
            }
            else if (int.TryParse(edtPesoFem.Text, out peso) == false)
            {
                Toast.MakeText(Application.Context,
                    "Você esqueceu de digitar o peso!",
                    ToastLength.Long).Show();
            }
            else if (double.TryParse(edtAlturaFem.Text, out altura) == false)
            {
                Toast.MakeText(Application.Context,
                    "Você esqueceu de digitar a altura!",
                    ToastLength.Long).Show();
            }

            imc = peso / (altura * altura);

            txtImcFem.Text = imc.ToString();

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