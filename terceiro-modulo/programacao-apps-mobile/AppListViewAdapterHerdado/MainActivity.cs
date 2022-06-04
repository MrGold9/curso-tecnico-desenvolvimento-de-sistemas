using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using System.Collections.Generic;
using Android.Content;

namespace AppListViewAdapterHerdado
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView lstView;
        List<VideoGames> lista = new List<VideoGames>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            lstView = FindViewById<ListView>(Resource.Id.lstVideoGames);

            lista.Add(new VideoGames
            {
                nome = "Playstation 1",
                descricao = "Lançado em 3 de dezembro de 1994",
                imagem = 0
            });

            lista.Add(new VideoGames
            {
                nome = "Playstation 2",
                descricao = "Lançado em 4 de março de 2000",
                imagem = 1
            });

            lista.Add(new VideoGames
            {
                nome = "Playstation 3",
                descricao = "Lançado em 11 de novembro de 2006",
                imagem = 2
            });

            lista.Add(new VideoGames
            {
                nome = "Playstation 4",
                descricao = "Lançado em 15 de novembro de 2013",
                imagem = 3
            });

            lstView.Adapter = new VideoGamesAdaptador(lista, this);
            lstView.ItemClick += LstView_ItemClick;
        }

        private void LstView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var item = lista[e.Position];
            Toast.MakeText(this, item.nome, ToastLength.Short).Show();

            Intent telaPlaystationUm = new Intent(this, typeof(ActivityPlaystationUm));
            Intent telaPlaystationDois = new Intent(this, typeof(ActivityPlaystationDois));
            Intent telaPlaystationTres = new Intent(this, typeof(ActivityPlaystationTres));
            Intent telaPlaystationQuatro = new Intent(this, typeof(ActivityPlaystationQuatro));

            int valor = e.Position;
            switch (valor)
            {
                case 0:
                    StartActivity(telaPlaystationUm);
                    break;
                case 1:
                    StartActivity(telaPlaystationDois);
                    break;
                case 2:
                    StartActivity(telaPlaystationTres);
                    break;
                case 3:
                    StartActivity(telaPlaystationQuatro);
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