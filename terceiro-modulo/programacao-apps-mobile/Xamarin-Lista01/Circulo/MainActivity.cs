using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace Circulo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText txtRaio;
        Button btnResultado;
        TextView lblP, lblPerimetro, lblA, lblArea;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            txtRaio = FindViewById<EditText>(Resource.Id.txtRaio);
            btnResultado = FindViewById<Button>(Resource.Id.btnResultado);
            lblP = FindViewById<TextView>(Resource.Id.lblP);
            lblPerimetro = FindViewById<TextView>(Resource.Id.lblPerimetro);
            lblA = FindViewById<TextView>(Resource.Id.lblA);
            lblArea = FindViewById<TextView>(Resource.Id.lblArea);


            btnResultado.Click += BtnResultado_Click;
        }

        private void BtnResultado_Click(object sender, System.EventArgs e)
        {
            double Raio, Perimetro, Area;
            double pi = Math.PI;

            Raio = double.Parse(txtRaio.Text);

            Perimetro = 2 * pi * Raio;
            Area = (Raio * Raio) * pi;

            lblPerimetro.Text = Perimetro.ToString();
            lblArea.Text = Area.ToString();
        }
    }
}