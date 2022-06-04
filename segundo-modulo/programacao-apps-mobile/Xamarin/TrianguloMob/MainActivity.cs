using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace TrianguloMob
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Triangulo triangulo = new Triangulo();
        EditText txtLado1, txtLado2, txtLado3;
        Button btnCalcular;
        TextView txtMsg;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            txtLado1 = FindViewById<EditText>(Resource.Id.txtLado1);
            txtLado2 = FindViewById<EditText>(Resource.Id.txtLado2);
            txtLado3 = FindViewById<EditText>(Resource.Id.txtLado3);
            btnCalcular = FindViewById<Button>(Resource.Id.btnCalcular);
            txtMsg = FindViewById<TextView>(Resource.Id.txtMsg);

            btnCalcular.Click += BtnCalcular_Click;

        }

        private void BtnCalcular_Click(object sender, System.EventArgs e)
        {
            double[] lado = { double.Parse(txtLado1.Text), double.Parse(txtLado2.Text), double.Parse(txtLado3.Text) };

            triangulo = new Triangulo(lado);

            //triangulo.lado[0] = double.Parse(txtLado1.Text);
            //triangulo.lado[1] = double.Parse(txtLado2.Text);
            //triangulo.lado[2] = double.Parse(txtLado3.Text);

            if (triangulo.isTriangle())
            {
                txtMsg.Text = "Tipo = " + triangulo.tipo +
                    "\nÁrea = " + triangulo.calcularArea() +
                    "\nPerímetro = " + triangulo.perimetro;
            }
            else
            {
                txtMsg.Text = "Os lados informados não formam um triângulo";
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}