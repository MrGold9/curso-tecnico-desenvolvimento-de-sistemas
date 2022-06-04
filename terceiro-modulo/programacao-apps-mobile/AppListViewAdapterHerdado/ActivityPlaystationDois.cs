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

namespace AppListViewAdapterHerdado
{
    [Activity(Label = "ActivityPlaystationDois")]
    public class ActivityPlaystationDois : Activity
    {
        ImageView imgPsDois;
        TextView lblPsDois, txtPsDois;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.TelaPlaystationDois);

            imgPsDois = FindViewById<ImageView>(Resource.Id.imgPsDois);
            lblPsDois = FindViewById<TextView>(Resource.Id.lblPsDois);
            txtPsDois = FindViewById<TextView>(Resource.Id.txtPsDois);
        }
    }
}