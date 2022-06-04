using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using System.Collections;
using Android.Widget;
using Android.Support.V4;
using System;
using Android.Support.V7.App;

namespace AppVariasTelas
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView lstMenu;
        ArrayList menuPrincipal;
        ArrayAdapter adaptador;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            lstMenu = FindViewById<ListView>(Resource.Id.lstMenu);
            menuPrincipal = new ArrayList();

            menuPrincipal.Add("Item 1");
            menuPrincipal.Add("Item 2");
            menuPrincipal.Add("Item 3");

            adaptador = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, menuPrincipal);

            lstMenu.Adapter = adaptador;

            lstMenu.ItemClick += LstMenu_ItemClick;
        }

        private void LstMenu_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            int valor = e.Position;
            switch (valor)
            {
                case 0:
                    StartActivity(typeof(Item1Activity));
                    break;

                /*  
                case 1:
                    StartActivity(typeof(Item2Activity));
                    break;
                case 2:
                    StartActivity(typeof(Item3Activity));
                    break;
                */
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}