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
    [Activity(Label = "ActivityPlaystationQuatro")]
    public class ActivityPlaystationQuatro : Activity
    {
        ImageView imgPsQuatro;
        TextView lblPsQuatro, txtPsQuatro;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.TelaPlaystationQuatro);

            imgPsQuatro = FindViewById<ImageView>(Resource.Id.imgPsQuatro);
            lblPsQuatro = FindViewById<TextView>(Resource.Id.lblPsQuatro);
            txtPsQuatro = FindViewById<TextView>(Resource.Id.txtPsQuatro);
        }
    }
}