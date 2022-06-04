using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace CalcularPrestacao
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText txtValor, txtTaxa, txtTempo;
        TextView lblP, lblPrestacao;
        Button btnCalcular;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            txtValor = FindViewById<EditText>(Resource.Id.txtValor);
            txtTaxa = FindViewById<EditText>(Resource.Id.txtTaxa);
            txtTempo = FindViewById<EditText>(Resource.Id.txtTempo);
            btnCalcular = FindViewById<Button>(Resource.Id.btnCalcular);
            lblP = FindViewById<TextView>(Resource.Id.lblP);
            lblPrestacao = FindViewById<TextView>(Resource.Id.lblPrestacao);


            btnCalcular.Click += BtnCalcular_Click;
        }

        private void BtnCalcular_Click(object sender, System.EventArgs e)
        {
            double valor, taxa, prestacao;
            int tempo;



            if (double.TryParse(txtValor.Text, out valor) == false &&
                double.TryParse(txtTaxa.Text, out taxa) == false &&
                int.TryParse(txtTempo.Text, out tempo) == false)
            {
                Toast.MakeText(Application.Context,
                    "Digite os valores para obter um resultado!",
                    ToastLength.Long).Show();
            }


            else if (double.TryParse(txtValor.Text, out valor) == false &&
                double.TryParse(txtTaxa.Text, out taxa) == false)
            {
                Toast.MakeText(Application.Context,
                    "Digite o valor da prestação e da taxa adicional para obter um resultado!",
                    ToastLength.Long).Show();
            }


            else if (double.TryParse(txtValor.Text, out valor) == false &&
                int.TryParse(txtTempo.Text, out tempo) == false)
            {
                Toast.MakeText(Application.Context,
                    "Digite o valor da prestação e do atraso para obter um resultado!",
                    ToastLength.Long).Show();
            }


            else if (double.TryParse(txtTaxa.Text, out taxa) == false &&
                int.TryParse(txtTempo.Text, out tempo) == false)
            {
                Toast.MakeText(Application.Context,
                    "Digite o valor da taxa adicional e do atraso para obter um resultado!",
                    ToastLength.Long).Show();
            }


            else if (double.TryParse(txtValor.Text, out valor) == false)
            {
                Toast.MakeText(Application.Context,
                    "Digite o valor da prestação para obter um resultado!",
                    ToastLength.Long).Show();
            }


            else if (double.TryParse(txtTaxa.Text, out taxa) == false)
            {
                Toast.MakeText(Application.Context,
                    "Digite a taxa adicional para obter um resultado!",
                    ToastLength.Long).Show();
            }


            else if (int.TryParse(txtTempo.Text, out tempo) == false)
            {
                Toast.MakeText(Application.Context,
                    "Digite o atraso para obter um resultado!",
                    ToastLength.Long).Show();
            }


            if (double.TryParse(txtValor.Text, out valor) == true &&
                double.TryParse(txtTaxa.Text, out taxa) == true &&
                int.TryParse(txtTempo.Text, out tempo) == true)
            {
                valor = double.Parse(txtValor.Text);
                taxa = double.Parse(txtTaxa.Text);
                tempo = int.Parse(txtTempo.Text);

                prestacao = valor + (valor * (taxa / 100) * tempo);

                lblPrestacao.Text = prestacao.ToString();
            }
            
        }
    }
}