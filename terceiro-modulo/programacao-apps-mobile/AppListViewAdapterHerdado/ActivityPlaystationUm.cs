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

namespace AppListViewAdapterHerdado
{
    [Activity(Label = "ActivityPlaystationUm")]
    public class ActivityPlaystationUm : Activity
    {
        ImageView imgPsUm;
        TextView lblPsUm, txtPsUm;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.TelaPlaystationUm);

            imgPsUm = FindViewById<ImageView>(Resource.Id.imgPsUm);
            lblPsUm = FindViewById<TextView>(Resource.Id.lblPsUm);
            txtPsUm = FindViewById<TextView>(Resource.Id.txtPsUm);
        }
    }
}