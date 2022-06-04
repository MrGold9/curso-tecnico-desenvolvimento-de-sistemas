using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Entre_telas
{
    [Activity(Label = "tela2")]
    public class tela2 : Activity
    {
        TextView lblNome, lblEndereco, lblTelefone;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.tela2);

            // Create your application here
            lblNome = FindViewById<TextView>(Resource.Id.lblNome);
            lblEndereco = FindViewById<TextView>(Resource.Id.lblEndereco);
            lblTelefone = FindViewById<TextView>(Resource.Id.lblTelefone);

            if (Intent.GetStringExtra("nome") != null)
                lblNome.Text = Intent.GetStringExtra("nome").ToString();
            if (Intent.GetStringExtra("endereço") != null)
                lblEndereco.Text = Intent.GetStringExtra("endereço").ToString();
            if (Intent.GetStringExtra("telefone") != null)
                lblTelefone.Text = Intent.GetStringExtra("telefone").ToString();
        }
    }
}