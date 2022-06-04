using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace Entre_telas
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText txtNome, txtEndereco, txtTelefone;
        Button btnOk;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            txtNome = FindViewById<EditText>(Resource.Id.txtNome);
            txtEndereco = FindViewById<EditText>(Resource.Id.txtEndereco);
            txtTelefone = FindViewById<EditText>(Resource.Id.txtTelefone);

            btnOk = FindViewById<Button>(Resource.Id.btnOk);
            btnOk.Click += BtnOk_Click;
        }


        private void BtnOk_Click(object sender, System.EventArgs e)
        {
            //Instancia uma nova Intent
            Intent novaTela = new Intent(this, typeof(tela2));
            //Adiciona os valores ao método PutExtra
            novaTela.PutExtra("nome", txtNome.Text);
            novaTela.PutExtra("endereço", txtEndereco.Text);
            novaTela.PutExtra("telefone", txtTelefone.Text);
            StartActivity(novaTela);
        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}