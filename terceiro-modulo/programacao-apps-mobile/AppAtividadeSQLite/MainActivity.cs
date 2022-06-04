using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using System.Collections.Generic;
using AppAtividadeSQLite.Resources.Model;
using AppAtividadeSQLite.Resources.DataBaseHelper;
using Android.Content;
using System;
using AlertDialog = Android.App.AlertDialog;


namespace AppAtividadeSQLite
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView lstDados;
        List<Veiculo> listaVeiculos = new List<Veiculo>();
        DataBase db = new DataBase();


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);


            //criar banco de dados
            CriarBancoDados();
            lstDados = FindViewById<ListView>(Resource.Id.lstDados);
            var edtNomeCarro = FindViewById<EditText>(Resource.Id.edtNomeCarro);
            var edtPlaca = FindViewById<EditText>(Resource.Id.edtPlaca);
            var dateDataRevisao = FindViewById<EditText>(Resource.Id.dateDataRevisao);
            var edtDescRevisao = FindViewById<EditText>(Resource.Id.edtDescRevisao);

            var btnIncluir = FindViewById<Button>(Resource.Id.btnIncluir);
            var btnEditar = FindViewById<Button>(Resource.Id.btnEditar);
            var btnDeletar = FindViewById<Button>(Resource.Id.btnDeletar);
            //carregar Dados
            CarregarDados();
            //botão Incluir
            btnIncluir.Click += delegate
            {
                Veiculo veiculo = new Veiculo()
                {
                    NomeCarro = edtNomeCarro.Text,
                    Placa = edtPlaca.Text,
                    DataRevisao = DateTime.Parse(dateDataRevisao.Text),
                    DescRevisao = edtDescRevisao.Text
                };
                db.InserirVeiculo(veiculo);

                CarregarDados();
            };
            //botão editar
            btnEditar.Click += delegate
            {
                Veiculo veiculo = new Veiculo()
                {
                    Id = int.Parse(edtNomeCarro.Tag.ToString()),
                    NomeCarro = edtNomeCarro.Text,
                    Placa = edtPlaca.Text,
                    DataRevisao = DateTime.Parse(dateDataRevisao.Text),
                    DescRevisao = edtDescRevisao.Text
                };
                db.AtualizarVeiculo(veiculo);
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
                    Veiculo veiculo = new Veiculo()
                    {
                        Id = int.Parse(edtNomeCarro.Tag.ToString()),
                        NomeCarro = edtNomeCarro.Text,
                        Placa = edtPlaca.Text,
                        DataRevisao = DateTime.Parse(dateDataRevisao.Text),
                        DescRevisao = edtDescRevisao.Text
                    };
                    db.DeletarVeiculo(veiculo);
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
            lstDados.ItemClick += (s, e) =>
            {
                for (int i = 0; i < lstDados.Count; i++)
                {
                    if (e.Position == i)
                        lstDados.GetChildAt(i).SetBackgroundColor(Android.Graphics.Color.LightBlue);
                    else
                        lstDados.GetChildAt(i).SetBackgroundColor(Android.Graphics.Color.Transparent);
                }
                //vinculando dados do listview 
                var lsttxtNomeCarro = e.View.FindViewById<TextView>(Resource.Id.txtNomeCarro);
                var lsttxtPlaca = e.View.FindViewById<TextView>(Resource.Id.txtPlaca);
                var lsttxtDataRevisao = e.View.FindViewById<TextView>(Resource.Id.txtDataRevisao);
                var lsttxtDescRevisao = e.View.FindViewById<TextView>(Resource.Id.txtDescRevisao);

                edtNomeCarro.Text = lsttxtNomeCarro.Text;
                edtNomeCarro.Tag = e.Id;
                edtPlaca.Text = lsttxtPlaca.Text;
                dateDataRevisao.Text = lsttxtDataRevisao.Text;
                edtDescRevisao.Text = lsttxtDescRevisao.Text;
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
            listaVeiculos = db.GetVeiculos();
            var adapter = new ListAdapter(this, listaVeiculos);
            lstDados.Adapter = adapter;
        }



        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}