using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using System;
using System.Collections;
using Android.Content;

namespace AppDuasTelasGames
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView lblSelecioneGame;

        ListView lstEscolherGame;
        ArrayList escolherGame;
        ArrayAdapter adaptador;

        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            lblSelecioneGame = FindViewById<TextView>(Resource.Id.lblSelecioneGame);


            lstEscolherGame = FindViewById<ListView>(Resource.Id.lstEscolherGame);

            escolherGame = new ArrayList();
            escolherGame.Add("The Witcher 3");
            escolherGame.Add("Grand Theft Auto V");
            escolherGame.Add("Dark Souls III");

            adaptador = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, escolherGame);

            lstEscolherGame.Adapter = adaptador;

            lstEscolherGame.ItemClick += LstEscolherGame_ItemClick;
        }

        private void LstEscolherGame_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent telaGames = new Intent(this, typeof(Games));

            int valor = e.Position;

            switch (valor)
            {
                case 0:
                    telaGames.PutExtra("JogoUm", (string)escolherGame[0]);
                    StartActivity(telaGames);
                    break;
                case 1:
                    telaGames.PutExtra("JogoDois", (string)escolherGame[1]);
                    StartActivity(telaGames);
                    break;
                case 2:
                    telaGames.PutExtra("JogoTres", (string)escolherGame[2]);
                    StartActivity(telaGames);
                    break;
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}