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
    [Activity(Label = "tela2", Theme = "@style/AppTheme")]
    public class tela2 : AppCompatActivity
    {
        TextView lblConfirmar, txtNome, txtSobrenome, txtIdade, txtAltura, txtSexo, txtReligiao;
        Button btnConfirmar, btnCorrigir;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.tela2);

            lblConfirmar = FindViewById<TextView>(Resource.Id.lblConfirmar);

            txtNome = FindViewById<TextView>(Resource.Id.txtNome);
            txtSobrenome = FindViewById<TextView>(Resource.Id.txtSobrenome);
            txtIdade = FindViewById<TextView>(Resource.Id.txtIdade);
            txtAltura = FindViewById<TextView>(Resource.Id.txtAltura);
            txtSexo = FindViewById<TextView>(Resource.Id.txtSexo);
            txtReligiao = FindViewById<TextView>(Resource.Id.txtReligiao);

            btnConfirmar = FindViewById<Button>(Resource.Id.btnConfirmar);
            btnCorrigir = FindViewById<Button>(Resource.Id.btnCorrigir);


            if (Intent.GetStringExtra("nome") != null)
            {
                txtNome.Text =Intent.GetStringExtra("nome").ToString();
            }
            if (Intent.GetStringExtra("sobrenome") != null)
            {
                txtSobrenome.Text =Intent.GetStringExtra("sobrenome").ToString();
            }
            if (Intent.GetStringExtra("idade") != null)
            {
                txtIdade.Text =Intent.GetStringExtra("idade").ToString();
            }
            if (Intent.GetStringExtra("altura") != null)
            {
                txtAltura.Text =Intent.GetStringExtra("altura").ToString();
            }
            if (Intent.GetStringExtra("sexo") != null)
            {
                txtSexo.Text =Intent.GetStringExtra("sexo").ToString();
            }

             if (Intent.GetStringExtra("religiao") != null)
            {
                txtReligiao.Text =Intent.GetStringExtra("religiao").ToString();
            }



            btnConfirmar.Click += BtnConfirmar_Click;

            btnCorrigir.Click += BtnCorrigir_Click;
        }

        private void BtnCorrigir_Click(object sender, EventArgs e)
        {

            base.OnBackPressed();

        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            Intent tela3 = new Intent(this, typeof(tela3));
            tela3.PutExtra("nomeCadastro", txtNome.Text);
            StartActivity(tela3);
        }

        /*internal static void PutExtra(string v, string text)
        {
            throw new NotImplementedException();
        }*/
    }
}