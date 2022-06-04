using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using Android.Widget;

namespace AppListViewPersonalizado
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView lv;
        List<MeioTransporte> lista;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            lv = FindViewById<ListView>(Resource.Id.lstTransportes);

            lista = new List<MeioTransporte>();


            lista.Add(new MeioTransporte
            {
                nome = "Aéreo",
                descricao = "Voo nacionais e internacionais",
                imagem = 0
            });

            lista.Add(new MeioTransporte
            {
                nome = "Automóveis",
                descricao = "Alugue os melhores carros",
                imagem = 1
            });

            lista.Add(new MeioTransporte
            {
                nome = "Cruzeiros",
                descricao = "Os melhores navios da costa brasileira",
                imagem = 2
            });

            lista.Add(new MeioTransporte
            {
                nome = "Rodoviário",
                descricao = "Viaje nos mais confortáveis ônibus",
                imagem = 4
            });

            lv.Adapter = new MeiosTransporteAdaptador(lista, this);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}