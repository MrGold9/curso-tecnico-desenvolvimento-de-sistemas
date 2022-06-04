using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using System.Collections.Generic;
using AppSQLite.Resources.Model;
using AppSQLite.Resources.DataBaseHelper;
using Android.Content;
using AlertDialog = Android.App.AlertDialog;

namespace AppSQLite
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView lvDados;
        List<Aluno> listaAlunos = new List<Aluno>();
        DataBase db = new DataBase();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //criar banco de dados 

            CriarBancoDados();

            lvDados = FindViewById<ListView>(Resource.Id.lvDados);

            var txtNome = FindViewById<EditText>(Resource.Id.txtNome);

            var txtIdade = FindViewById<EditText>(Resource.Id.txtIdade);

            var txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);

            var btnIncluir = FindViewById<Button>(Resource.Id.btnIncluir);

            var btnEditar = FindViewById<Button>(Resource.Id.btnEditar);

            var btnDeletar = FindViewById<Button>(Resource.Id.btnDeletar);

            //carregar Dados 

            CarregarDados();

            //botão Incluir 

            btnIncluir.Click += delegate
            {
                Aluno aluno = new Aluno()
                {
                    Nome = txtNome.Text,

                    Idade = int.Parse(txtIdade.Text),

                    Email = txtEmail.Text
                };

                db.InserirAluno(aluno);



                CarregarDados();
            };

            //botão editar 

            btnEditar.Click += delegate
            { 
                Aluno aluno = new Aluno()

                {

                    Id = int.Parse(txtNome.Tag.ToString()),

                    Nome = txtNome.Text,

                    Idade = int.Parse(txtIdade.Text),

                    Email = txtEmail.Text
                };

                db.AtualizarAluno(aluno);

                CarregarDados();
            };

            //botão deletar 

            btnDeletar.Click += delegate
            {

                //define o alerta para executar a tarefa 

                AlertDialog.Builder alerta = new AlertDialog.Builder(this);

                //define o titulo e o ícone a exibir no dialogo 

                alerta.SetTitle("Atenção");

                alerta.SetIcon(Android.Resource.Drawable.IcDelete);

                //define a mensagem 

                alerta.SetMessage("Deseja realmente excluir?");

                //define o botão positivo 

                alerta.SetPositiveButton("Sim", (senderAlert, args) =>
                {
                    Aluno aluno = new Aluno()
                    {
                        Id = int.Parse(txtNome.Tag.ToString()),

                        Nome = txtNome.Text,

                        Idade = int.Parse(txtIdade.Text),

                        Email = txtEmail.Text
                    };

                    db.DeletarAluno(aluno);

                    CarregarDados();
                });



                alerta.SetNegativeButton("Não", (senderAlert, args) =>
                {
                    Toast.MakeText(this, "Dados Preservados", ToastLength.Short).Show();
                });



                //cria o alerta e exibe 

                Dialog dialog = alerta.Create();

                dialog.Show();
            };

            //evento itemClick do ListView 

            lvDados.ItemClick += (s, e) =>
            {
                for (int i = 0; i < lvDados.Count; i++)
                {
                    if (e.Position == i)

                        lvDados.GetChildAt(i).SetBackgroundColor(Android.Graphics.Color.Chocolate);

                    else

                        lvDados.GetChildAt(i).SetBackgroundColor(Android.Graphics.Color.Transparent);
                }

                //vinculando dados do listview  

                var lvtxtNome = e.View.FindViewById<TextView>(Resource.Id.txtvNome);

                var lvtxtIdade = e.View.FindViewById<TextView>(Resource.Id.txtvIdade);

                var lvtxtEmail = e.View.FindViewById<TextView>(Resource.Id.txtvEmail);

                txtNome.Text = lvtxtNome.Text;

                txtNome.Tag = e.Id;

                txtIdade.Text = lvtxtIdade.Text;

                txtEmail.Text = lvtxtEmail.Text;
            };
        }

        //rotina para criar o banco de dados 

        private void CriarBancoDados()
        {
            db = new DataBase();

            db.CriarBancoDeDados();
        }

        //Obtem todos os alunos da tabela Aluno e exibe no ListView 

        private void CarregarDados()
        {
            listaAlunos = db.GetAlunos();

            var adapter = new ListAdapter(this, listaAlunos);

            lvDados.Adapter = adapter;
        }



        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}