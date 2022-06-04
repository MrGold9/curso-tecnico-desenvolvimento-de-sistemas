using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using ListViewPersonalizada.Resources;

namespace ListViewPersonalizada
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        ListView lv;
        List<MeioTransporte> listaTransportes;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            lv = FindViewById<ListView>(Resource.Id.lstTransportes);

            listaTransportes = new List<MeioTransporte>();

            listaTransportes.Add(new MeioTransporte
            {
                nome = "Aéreo",
                descricao = "Voos nacionais e internacionais",
                imagem = 0
            });
            listaTransportes.Add(new MeioTransporte
            {
                nome = "Automóveis",
                descricao = "Alugue um carro com conforto e praticidade",
                imagem = 1
            });
            listaTransportes.Add(new MeioTransporte
            {
                nome = "Cruzeiro",
                descricao = "Os mais belos navios da Costa Brasileira",
                imagem = 2
            });
            listaTransportes.Add(new MeioTransporte
            {
                nome = "Ônibus",
                descricao = "Viagens regionais com conforto e economia",
                imagem = 3
            });

            lv.Adapter = new MeiosTransporteAdaptor(listaTransportes, this);
            lv.ItemClick += Lv_ItemClick;
        }

        private void Lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var t = listaTransportes[e.Position];
            Toast.MakeText(this, t.nome, ToastLength.Short).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}