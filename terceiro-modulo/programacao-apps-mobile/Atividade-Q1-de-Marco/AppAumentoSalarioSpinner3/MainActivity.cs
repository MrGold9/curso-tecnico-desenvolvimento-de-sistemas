using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using System.Collections;
using System;

namespace AppAumentoSalarioSpinner3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        LinearLayout linearLayout1, linearLayout2, linearLayout3, linearLayout4;

        TextView lblSpin;
        Spinner spnCategoria;
        ArrayList categorias;
        ArrayAdapter adapter;
        string categoria = "";

        EditText edtNome, edtSalario;
        Button btnResultado;
        TextView lblNome, lblCategoria, lblSalario;
        TextView txtNome, txtCategoria, txtSalario;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);



            linearLayout1 = FindViewById<LinearLayout>(Resource.Id.linearLayout1);
            linearLayout2 = FindViewById<LinearLayout>(Resource.Id.linearLayout2);
            linearLayout3 = FindViewById<LinearLayout>(Resource.Id.linearLayout3);
            linearLayout4 = FindViewById<LinearLayout>(Resource.Id.linearLayout4);

            lblSpin = FindViewById<TextView>(Resource.Id.lblSpin);
            spnCategoria = FindViewById<Spinner>(Resource.Id.spnCategoria);

            edtNome = FindViewById<EditText>(Resource.Id.edtNome);
            edtSalario = FindViewById<EditText>(Resource.Id.edtSalario);

            btnResultado = FindViewById<Button>(Resource.Id.btnResultado);

            lblNome = FindViewById<TextView>(Resource.Id.lblNome);
            lblCategoria = FindViewById<TextView>(Resource.Id.lblCategoria);
            lblSalario = FindViewById<TextView>(Resource.Id.lblSalario);

            txtNome = FindViewById<TextView>(Resource.Id.txtNome);
            txtCategoria = FindViewById<TextView>(Resource.Id.txtCategoria);
            txtSalario = FindViewById<TextView>(Resource.Id.txtSalario);



            //INSTÂNCIA DO ARRAY
            categorias = new ArrayList();
            //ADICIONANDO ITENS AO ARRAY
            categorias.Add("A");
            categorias.Add("B");
            categorias.Add("C");
            categorias.Add("D");
            categorias.Add("E");
            categorias.Add("F");
            categorias.Add("G");
            categorias.Add("H");
            categorias.Add("I");
            categorias.Add("J");
            categorias.Add("K");
            categorias.Add("L");
            categorias.Add("M");
            categorias.Add("N");
            categorias.Add("O");
            categorias.Add("P");
            categorias.Add("Q");
            categorias.Add("R");
            categorias.Add("S");
            categorias.Add("T");
            categorias.Add("U");
            categorias.Add("V");
            categorias.Add("W");
            categorias.Add("X");
            categorias.Add("Y");
            categorias.Add("Z");
            //instância do adapter
            adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, categorias);
            //vincula o adaptador ao controle spinner
            spnCategoria.Adapter = adapter;



            btnResultado.Click += BtnResultado_Click;
        }


        private void BtnResultado_Click(object sender, System.EventArgs e)
        {
            string nome;
            string categoria;
            double salario;
            nome = Convert.ToString(edtNome.Text);
            categoria = Convert.ToString(spnCategoria);
            salario = double.Parse(edtSalario.Text);

            int item = spnCategoria.SelectedItemPosition;


            if (edtNome.Text.Length == 0 && double.TryParse(edtSalario.Text, out salario) == false)
            {
                Toast.MakeText(Application.Context,
                    "Você esqueceu de digitar o nome e o salário!",
                    ToastLength.Long).Show();
            }
            else if(edtNome.Text.Length == 0)
            {
                Toast.MakeText(Application.Context,
                    "Você esqueceu de digitar o nome!",
                    ToastLength.Long).Show();
            }
            else if(double.TryParse(edtSalario.Text, out salario) == false)
            {
                Toast.MakeText(Application.Context,
                    "Você esqueceu de digitar o salário!",
                    ToastLength.Long).Show();
            }


            switch (item)
            {
                case 0:
                    categoria = "A";
                    salario = salario + (salario * 0.1);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + " , aumento de 10% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 1:
                    categoria = "B";
                    salario = salario + (salario * 0.15);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + " , aumento de 15% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 2:
                    categoria = "C";
                    salario = salario + (salario * 0.1);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 10% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 3:
                    categoria = "D";
                    salario = salario + (salario * 0.15);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 15% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 4:
                    categoria = "E";
                    salario = salario + (salario * 0.15);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 15% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 5:
                    categoria = "F";
                    salario = salario + (salario * 0.1);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 10% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 6:
                    categoria = "G";
                    //Não recebe mudança
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", sem aumento do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 7:
                    categoria = "H";
                    salario = salario + (salario * 0.1);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 10% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 8:
                    categoria = "I";
                    salario = salario + (salario * 0.15);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 15% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 9:
                    categoria = "J";
                    salario = salario + (salario * 0.15);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 15% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 10:
                    categoria = "K";
                    salario = salario + (salario * 0.25);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 25% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 11:
                    categoria = "L";
                    salario = salario + (salario * 0.35);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 35% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 12:
                    categoria = "M";
                    salario = salario + (salario * 0.35);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 35% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 13:
                    categoria = "N";
                    salario = salario + (salario * 0.35);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 35% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 14:
                    categoria = "O";
                    salario = salario + (salario * 0.35);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 35% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 15:
                    categoria = "P";
                    salario = salario + (salario * 0.35);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 35% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 16:
                    categoria = "Q";
                    salario = salario + (salario * 0.35);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 35% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 17:
                    categoria = "R";
                    salario = salario + (salario * 0.25);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 25% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 18:
                    categoria = "S";
                    salario = salario + (salario * 0.35);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 35% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 19:
                    categoria = "T";
                    salario = salario + (salario * 0.15);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 15% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 20:
                    categoria = "U";
                    salario = salario + (salario * 0.5);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 50% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 21:
                    categoria = "V";
                    salario = salario + (salario * 0.5);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 50% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 22:
                    categoria = "W";
                    salario = salario + (salario * 0.5);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 50% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 23:
                    categoria = "X";
                    salario = salario + (salario * 0.5);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 50% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 24:
                    categoria = "Y";
                    salario = salario + (salario * 0.5);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 50% do salário";
                    txtNome.Text = nome.ToString();
                    break;
                case 25:
                    categoria = "Z";
                    salario = salario + (salario * 0.5);
                    txtSalario.Text = salario.ToString();
                    txtCategoria.Text = categoria.ToString() + ", aumento de 50% do salário";
                    txtNome.Text = nome.ToString();
                    break;
            }

        }



        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}