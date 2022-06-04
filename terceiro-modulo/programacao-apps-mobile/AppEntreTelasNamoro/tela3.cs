using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AndroidX.AppCompat.App;
using System.Collections;

namespace AppEntreTelasNamoro
{
    [Activity(Label = "tela3", Theme = "@style/AppTheme")]
    public class tela3 : AppCompatActivity
    {
        TextView txtNome;
        ImageView imgFeliz;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.tela3);


            txtNome = FindViewById<TextView>(Resource.Id.txtNome);
            

            if (Intent.GetStringExtra("nomeCadastro") != null)
            {
                txtNome.Text = Intent.GetStringExtra("nomeCadastro").ToString() + ", seu cadastro foi efetuado com sucesso!";
            }
        }
    }
}