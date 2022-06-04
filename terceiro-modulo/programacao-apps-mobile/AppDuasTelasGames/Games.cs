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

namespace AppDuasTelasGames
{
    [Activity(Label = "Games")]
    public class Games : Activity
    {
        TextView lblWitcher, lblGTA, lblDark;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.games);

            // Create your application here

            lblWitcher = FindViewById<TextView>(Resource.Id.lblWitcher);
            lblGTA = FindViewById<TextView>(Resource.Id.lblGTA);
            lblDark = FindViewById<TextView>(Resource.Id.lblDark);


            if(Intent.GetStringExtra("JogoUm") != null)
            {
                lblWitcher.Text = Intent.GetStringExtra("JogoUm").ToString() +
                "\nProdutora: CD Project Red" +
                "\nLançamento: 2015" +
                "\nGênero: RPG de ação";
            }
            if (Intent.GetStringExtra("JogoDois") != null)
            {
                lblGTA.Text = Intent.GetStringExtra("JogoDois").ToString() +
                "\nProdutora: Rockstar Games" +
                "\nLançamento: 2013" +
                "\nGênero: Ação-aventura";
            }
            if (Intent.GetStringExtra("JogoTres") != null)
            {
                lblDark.Text = Intent.GetStringExtra("JogoTres").ToString() +
                    "\nProdutora: From Software" +
                "\nLançamento: 2016" +
                "\nGênero: RPG de ação";
            }
        }
    }
}