using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using xamarinFirebase.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Android.Views;
using System;
using Android.Widget;
using System.Collections;

namespace xamarinFirebase
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText txtNome, txtEmail;
        ListView lstUsuarios;
        ProgressBar circular_progress;
        List<ContaUsuario> listaUsuarios = new List<ContaUsuario>();
        UsuarioAdapter adapter;
        ContaUsuario conta;
        Button btnSalvar, btnAdicionar, btnExcluir;

        private const string FirebaseURL = "https://xamarinfirebase-aa458-default-rtdb.firebaseio.com/usuarios"; //URL do Firebase Database

        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);



            circular_progress = FindViewById<ProgressBar>(Resource.Id.circularProgress);
            txtNome = FindViewById<EditText>(Resource.Id.txtNome);
            txtEmail = FindViewById<EditText>(Resource.Id.txtEMail);
            lstUsuarios = FindViewById<ListView>(Resource.Id.lstUsuarios);
            btnAdicionar = FindViewById<Button>(Resource.Id.btnAdicionar);
            btnSalvar = FindViewById<Button>(Resource.Id.btnSalvar);
            btnExcluir = FindViewById<Button>(Resource.Id.btnExcluir);
            circular_progress.Visibility = ViewStates.Invisible;
            lstUsuarios.ItemClick += LstUsuarios_ItemClick;
            btnAdicionar.Click += BtnAdicionar_Click;
            btnSalvar.Click += BtnSalvar_Click;
            btnExcluir.Click += BtnExcluir_Click;

            await carregaDados();
        }

        private void BtnExcluir_Click(object sender, System.EventArgs e)
        {
            excluirUsuario();
        }

        private void BtnSalvar_Click(object sender, System.EventArgs e)
        {
            gravarDados();
        }

        private void BtnAdicionar_Click(object sender, System.EventArgs e)
        {
            criarUsuario();
        }

        private void LstUsuarios_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            conta = listaUsuarios[e.Position];
            txtNome.Text = conta.nome;
            txtEmail.Text = conta.email;
        }

        private async Task carregaDados()
        {
            circular_progress.Visibility = ViewStates.Visible;
            lstUsuarios.Visibility = ViewStates.Invisible;

            var firebase = new FirebaseClient(FirebaseURL);

            var itens = await firebase
           .Child("usuarios")
           .OnceAsync<ContaUsuario>();

            listaUsuarios.Clear();
            adapter = null;
            foreach (var item in itens)
            {
                ContaUsuario conta = new ContaUsuario();
                conta.id = item.Key;
                conta.nome = item.Object.nome;
                conta.email = item.Object.email;

                listaUsuarios.Add(conta);

                adapter = new UsuarioAdapter(this, listaUsuarios);
                adapter.NotifyDataSetChanged();
                lstUsuarios.Adapter = adapter;
                lstUsuarios.Visibility = ViewStates.Visible;
            }
            circular_progress.Visibility = ViewStates.Invisible;
        }
        private async void criarUsuario()
        {
            ContaUsuario usuario = new ContaUsuario();
            usuario.id = String.Empty;
            usuario.nome = txtNome.Text;
            usuario.email = txtEmail.Text;

            var firebase = new FirebaseClient(FirebaseURL);
            //Add Item
            var item = await firebase.Child("usuarios").PostAsync<ContaUsuario>(usuario);
            await carregaDados();
            txtNome.Text = "";
            txtEmail.Text = "";
        }

        private async void excluirUsuario()
        {
            var firebase = new FirebaseClient(FirebaseURL);
            await firebase.Child("usuarios").Child(conta.id).DeleteAsync();
            await carregaDados();
            txtNome.Text = "";
            txtEmail.Text = "";
        }

        private async void gravarDados()
        {
            var firebase = new FirebaseClient(FirebaseURL);
            await firebase.Child("usuarios").Child(conta.id).PutAsync(new ContaUsuario(txtNome.Text, txtEmail.Text));

            await carregaDados();
            txtNome.Text = "";
            txtEmail.Text = "";
        }





        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}