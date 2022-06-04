using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Java.Util;
using Android.Nfc;
using System;
using Java.Security;

namespace TesteDeSoma
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        TextView N1, N2, Placar, Mensagem;
        Button btnConferir, btnJogar;
        EditText edtResult;

        int n1 = 0, n2 = 0, res = 0, pontos = 0;
        System.Random gerador = new System.Random();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            N1 = FindViewById<TextView>(Resource.Id.txtN1);

            N2 = FindViewById<TextView>(Resource.Id.txtN2);

            Placar = FindViewById<TextView>(Resource.Id.txtPlacar);

            Mensagem = FindViewById<TextView>(Resource.Id.txtMensagem);

            edtResult = FindViewById<EditText>(Resource.Id.edtResultado);

            btnConferir = FindViewById<Button>(Resource.Id.btnConferir);

            btnJogar = FindViewById<Button>(Resource.Id.btnJogar);


            btnJogar.Click += BtnJogar_Click;

            btnConferir.Click += BtnConferir_Click;
        }

        private void BtnConferir_Click(object sender, EventArgs e)
        {

            res = n1 + n2;
            int resposta = int.Parse(edtResult.Text);

            if(res == resposta)
            {
                Mensagem.Text = "Parabéns! Resposta Correta!";
                pontos++;
            }
            else
            {
                Mensagem.Text = "Tente novamente! O correto seria " + res.ToString();
                pontos--;
            }
            Placar.Text = pontos.ToString() + " Pontos";

        }

        private void BtnJogar_Click(object sender, EventArgs e)
        {

            n1 = gerador.Next(1, 10);
            n2 = gerador.Next(1, 10);

            N1.Text = n1.ToString();
            N2.Text = n2.ToString();

        }



        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}