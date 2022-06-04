using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using System;
using System.Collections;

namespace AppEntreTelasIMC
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView lblGenero;

        ListView lstEscolher;
        ArrayList escolherGenero;
        ArrayAdapter adaptador;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            lblGenero = FindViewById<TextView>(Resource.Id.lblGenero);
            lstEscolher = FindViewById<ListView>(Resource.Id.lstEscolher);

            escolherGenero = new ArrayList();
            escolherGenero.Add("Masculino");
            escolherGenero.Add("Feminino");

            adaptador = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, escolherGenero);

            lstEscolher.Adapter = adaptador;


            lstEscolher.ItemClick += LstEscolher_ItemClick;

        }

        private void LstEscolher_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            int valor = e.Position;
            switch (valor)
            {
                case 0:
                    StartActivity(typeof(MasculinoActivity));
                    break;
                case 1:
                    StartActivity(typeof(FemininoActivity));
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