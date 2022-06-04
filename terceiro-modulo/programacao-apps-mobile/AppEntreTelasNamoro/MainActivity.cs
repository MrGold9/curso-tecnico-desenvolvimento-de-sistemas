using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using System;
using System.Collections;
using Android.Content;

namespace AppEntreTelasNamoro
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView lblNomeApp, lblSexo, lblReligiao;
        EditText edtNome, edtSobrenome, edtIdade, edtAltura;
        RadioGroup rdGroupEscolherSexo;
        RadioButton rdBtnHomem, rdBtnMulher;
        Button btnCadastrar;

        Spinner spnReligiao;
        ArrayList religioes;
        ArrayAdapter adapter;
        string religiao = "";


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            lblNomeApp = FindViewById<TextView>(Resource.Id.lblNomeApp);
            lblSexo = FindViewById<TextView>(Resource.Id.lblSexo);
            lblReligiao = FindViewById<TextView>(Resource.Id.lblReligiao);

            edtNome = FindViewById<EditText>(Resource.Id.edtNome);
            edtSobrenome = FindViewById<EditText>(Resource.Id.edtSobrenome);
            edtIdade = FindViewById<EditText>(Resource.Id.edtIdade);
            edtAltura = FindViewById<EditText>(Resource.Id.edtAltura);

            rdGroupEscolherSexo = FindViewById<RadioGroup>(Resource.Id.rdGroupEscolherSexo);
            rdBtnHomem = FindViewById<RadioButton>(Resource.Id.rdBtnHomem);
            rdBtnMulher = FindViewById<RadioButton>(Resource.Id.rdBtnMulher);

            btnCadastrar = FindViewById<Button>(Resource.Id.btnCadastrar);



            spnReligiao = FindViewById<Spinner>(Resource.Id.spnReligiao);

            religioes = new ArrayList();

            religioes.Add("Católico(a)");
            religioes.Add("Protestante");
            religioes.Add("Espírita");
            religioes.Add("Budista");
            religioes.Add("Xintoísta");
            religioes.Add("Agnóstico(a)");
            religioes.Add("Ateu/Ateia");
            
            adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, religioes);
            
            spnReligiao.Adapter = adapter;


            spnReligiao.ItemSelected += SpnReligiao_ItemSelected;

            btnCadastrar.Click += BtnCadastrar_Click;
        }

        private void SpnReligiao_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Intent tela2 = new Intent(this, typeof(tela2));

            int valor = e.Position;
            switch (valor)
            {
                case 0:
                    religiao = "Católico(a)";
                    tela2.PutExtra("religiao", religiao);
                    break;
                case 1:
                    religiao = "Protestante";
                    tela2.PutExtra("religiao", religiao);
                    break;
                case 2:
                    religiao = "Espírita";
                    tela2.PutExtra("religiao", religiao);
                    break;
                case 3:
                    religiao = "Budista";
                    tela2.PutExtra("religiao", religiao);
                    break;
                case 4:
                    religiao = "Xintoísta";
                    tela2.PutExtra("religiao", religiao);
                    break;
                case 5:
                    religiao = "Agnóstico(a)";
                    tela2.PutExtra("religiao", religiao);
                    break;
                case 6:
                    religiao = "Ateu/Ateia";
                    tela2.PutExtra("religiao", religiao);
                    break;
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Intent tela2 = new Intent(this, typeof(tela2));

            tela2.PutExtra("nome", edtNome.Text);
            tela2.PutExtra("sobrenome", edtSobrenome.Text);
            tela2.PutExtra("idade", edtIdade.Text);
            tela2.PutExtra("altura", edtAltura.Text);

            if (rdBtnHomem.Checked)
            {
                tela2.PutExtra("sexo", rdBtnHomem.Text);
            }
            else if (rdBtnMulher.Checked)
            {
                tela2.PutExtra("sexo", rdBtnMulher.Text);
            }

              tela2.PutExtra("religiao", religiao);

            StartActivity(tela2);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}