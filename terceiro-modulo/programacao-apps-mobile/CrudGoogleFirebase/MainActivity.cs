using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using CrudGoogleFirebase.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Android.Views;
using System;


namespace CrudGoogleFirebase
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText edtManga, edtEstoque, edtDescricao, edtNome;
        ListView lstMangas;
        ProgressBar circular_progress;
        List<mangas> listaMangas = new List<mangas>();
        MangaAdapter adapter;

        mangas mangaRegistro;

        Button btnSalvar, btnAdicionar, btnExcluir;

        private const string FirebaseURL = "https://crudfirebase-5dccb-default-rtdb.firebaseio.com/"; //URL do Firebase Database


        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            circular_progress = FindViewById<ProgressBar>(Resource.Id.circularProgress);
            edtManga = FindViewById<EditText>(Resource.Id.edtNomeManga);
            edtEstoque = FindViewById<EditText>(Resource.Id.edtEstoque);
            edtDescricao = FindViewById<EditText>(Resource.Id.edtDescManga);
            edtNome = FindViewById<EditText>(Resource.Id.edtNomePessoa);
            lstMangas = FindViewById<ListView>(Resource.Id.lstMangas);
            btnAdicionar = FindViewById<Button>(Resource.Id.btnAdicionar);
            btnSalvar = FindViewById<Button>(Resource.Id.btnSalvar);
            btnExcluir = FindViewById<Button>(Resource.Id.btnExcluir);

            circular_progress.Visibility = ViewStates.Invisible;

            lstMangas.ItemClick += LstMangas_ItemClick1;
            btnAdicionar.Click += BtnAdicionar_Click1;
            btnSalvar.Click += BtnSalvar_Click1;
            btnExcluir.Click += BtnExcluir_Click1;


            await carregaDados();

        }

        private void BtnExcluir_Click1(object sender, EventArgs e)
        {
            excluirManga();
        }

        private void BtnSalvar_Click1(object sender, EventArgs e)
        {
            gravarDados();
        }

        private void BtnAdicionar_Click1(object sender, EventArgs e)
        {
            criarManga();
        }

        private void LstMangas_ItemClick1(object sender, AdapterView.ItemClickEventArgs e)
        {
            mangaRegistro = listaMangas[e.Position];
            edtManga.Text = mangaRegistro.manga;
            edtEstoque.Text = "" + mangaRegistro.estoque;
            edtDescricao.Text = mangaRegistro.descricao;
            edtNome.Text = mangaRegistro.nome;
        }

        private async Task carregaDados()
        {
            circular_progress.Visibility = ViewStates.Visible;
            lstMangas.Visibility = ViewStates.Invisible;

            var firebase = new FirebaseClient(FirebaseURL);

            var itens = await firebase
                .Child("mangaInd")
                .OnceAsync<mangas>();

            listaMangas.Clear();
            adapter = null;
            foreach (var item in itens)
            {
                mangas mangaRegistro = new mangas();
                mangaRegistro.id = item.Key;
                mangaRegistro.manga = item.Object.manga;
                mangaRegistro.estoque = item.Object.estoque;
                mangaRegistro.descricao = item.Object.descricao;
                mangaRegistro.nome = item.Object.nome;

                listaMangas.Add(mangaRegistro);

                adapter = new MangaAdapter(this, listaMangas);
                adapter.NotifyDataSetChanged();
                lstMangas.Adapter = adapter;
                lstMangas.Visibility = ViewStates.Visible;
            }
            circular_progress.Visibility = ViewStates.Invisible;

        }
        private async void criarManga()
        {
            mangas mangaInd = new mangas();
            mangaInd.id = String.Empty;
            mangaInd.manga = edtManga.Text;
            mangaInd.estoque = int.Parse(edtEstoque.Text);
            mangaInd.descricao = edtDescricao.Text;
            mangaInd.nome = edtNome.Text;

            var firebase = new FirebaseClient(FirebaseURL);
            //Add Item
            var item = await firebase.Child("mangaInd").PostAsync<mangas>(mangaInd);
            await carregaDados();
            mangaInd.manga = "";
            mangaInd.estoque = 0;
            mangaInd.descricao = "";
            mangaInd.nome = "";
        }

        private async void excluirManga()
        {
            var firebase = new FirebaseClient(FirebaseURL);
            await firebase.Child("mangaInd").Child(mangaRegistro.id).DeleteAsync();
            await carregaDados();
        }


        private async void gravarDados()
        {
            var firebase = new FirebaseClient(FirebaseURL);
            await firebase.Child("mangaInd").Child(mangaRegistro.id).PutAsync(new mangas(edtManga.Text, int.Parse(edtEstoque.Text), edtDescricao.Text, edtNome.Text));

            await carregaDados();
            edtManga.Text = "";
            edtEstoque.Text = "";
            edtDescricao.Text = "";
            edtNome.Text = "";
        }



        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}