using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Retangulo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText txtBase, txtAltura;
        Button btnResultado;
        TextView lblP, lblPerimetro, lblA, lblArea;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            txtBase = FindViewById<EditText>(Resource.Id.txtBase);
            txtAltura = FindViewById<EditText>(Resource.Id.txtAltura);
            btnResultado = FindViewById<Button>(Resource.Id.btnResultado);
            lblP = FindViewById<TextView>(Resource.Id.lblP);
            lblPerimetro = FindViewById<TextView>(Resource.Id.lblPerimetro);
            lblA = FindViewById<TextView>(Resource.Id.lblA);
            lblArea = FindViewById<TextView>(Resource.Id.lblArea);


            btnResultado.Click += BtnResultado_Click;
        }

        private void BtnResultado_Click(object sender, System.EventArgs e)
        {
            double Base, Altura, Perimetro, Area;

            Base = double.Parse(txtBase.Text);
            Altura = double.Parse(txtAltura.Text);

            Perimetro = 2 * (Base * Altura);
            Area = Base * Altura;

            lblArea.Text = Area.ToString();
            lblPerimetro.Text = Perimetro.ToString();
        }
    }
}