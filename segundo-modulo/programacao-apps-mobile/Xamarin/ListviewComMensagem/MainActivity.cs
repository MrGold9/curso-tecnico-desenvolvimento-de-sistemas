using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace ListviewComMensagem
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView lista;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            string[] nomes = new string[]
            {

                "carro","moto","trem","bicicleta"

            };


            lista = FindViewById<ListView>(Resource.Id.lista);


            ArrayAdapter adaptador = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, nomes);
            lista.Adapter = adaptador;


            lista.ItemClick += Lista_ItemClick;

        }

        private void Lista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Android.App.AlertDialog.Builder caixa = new Android.App.AlertDialog.Builder(this);

            caixa.SetTitle("Item selecionado");
            caixa.SetIcon(Resource.Drawable.favicon);

            caixa.SetPositiveButton("Ok", delegate { caixa_Click_Ok(); });

            caixa.SetMessage("Teste da caixa de mensagem");
            caixa.Show();
        }

        private void caixa_Click_Ok()
        {
            Android.App.AlertDialog.Builder caixa2 = new Android.App.AlertDialog.Builder(this);
            caixa2.SetMessage("Clicou SIM");
            caixa2.Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}