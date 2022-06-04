using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Core;

namespace Fone_Mundo
{
    [Activity(Label ="@string/app_name", Theme ="@style/AppTheme", MainLauncher = true)]

    public class MainActivity : Activity
    {
        static readonly List<string> numeroFone = new List<string>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            EditText NumeroTelefoneText = FindViewById<EditText>(Resource.Id.NumeroTelefoneText);
            Button BotaoTradutor = FindViewById<Button>(Resource.Id.BotaoTradutor);
            TextView FoneMundoTraduzido = FindViewById<TextView>(Resource.Id.FoneMundoTradutor);
            Button BotaoHistoricoTradutor = FindViewById<Button>(Resource.Id.BotaoHistoricoTradutor);

            BotaoTradutor.Click += (sender, e) =>
            {

                string traduziroNumero = Core.TraduzindoFoneMundo.ONumero(NumeroTelefoneText.Text);
                if (string.IsNullOrWhiteSpace(traduziroNumero))
                {
                    FoneMundoTraduzido.Text = string.Empty;
                }
                else
                {
                    FoneMundoTraduzido.Text = traduziroNumero;
                }
            };
            BotaoHistoricoTradutor.Click += (sender, e) =>
             {
                 var intent = new Intent(this, typeof(AtividadeHistoricoTradutor));

                 Intent.PutStringArrayListExtra("numeros_fone", numeroFone);
                 StartActivity(intent);
             };

            string NumeroTraduzido = string.Empty;
            BotaoTradutor.Click += (sender, e) =>
              {
                  NumeroTraduzido = TraduzindoFoneMundo.ONumero(NumeroTelefoneText.Text);

                  if (string.IsNullOrWhiteSpace(NumeroTraduzido))
                  {
                      FoneMundoTraduzido.Text = "";
                  }
                  else
                  {
                      FoneMundoTraduzido.Text = NumeroTraduzido;
                      numeroFone.Add(NumeroTraduzido);
                      BotaoHistoricoTradutor.Enabled = true;
                  }
              };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}