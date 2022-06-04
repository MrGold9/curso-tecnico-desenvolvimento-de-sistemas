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
using AppAtividadeSQLite.Resources.Model;


namespace AppAtividadeSQLite
{
    class ListAdapter : BaseAdapter<Veiculo>
    {


        Activity context;
        private List<Veiculo> veiculos;
        public ListAdapter(Activity _context, List<Veiculo> _veiculos)
        {
            this.context = _context;
            this.veiculos = _veiculos;
        }
        public override int Count
        {
            get
            {
                return veiculos.Count;
            }
        }
        public override long GetItemId(int position)
        {
            return veiculos[position].Id;
            //return position;
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = veiculos[position];
            var view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.listViewLayout, null);


            var lsttxtNomeCarro = view.FindViewById<TextView>(Resource.Id.txtNomeCarro);
            var lsttxtPlaca = view.FindViewById<TextView>(Resource.Id.txtPlaca);
            var lsttxtDataRevisao = view.FindViewById<TextView>(Resource.Id.txtDataRevisao);
            var lsttxtDescRevisao = view.FindViewById<TextView>(Resource.Id.txtDescRevisao);

            lsttxtNomeCarro.Text = veiculos[position].NomeCarro;
            lsttxtPlaca.Text = veiculos[position].Placa;
            lsttxtDataRevisao.Text = "" + veiculos[position].DataRevisao;
            lsttxtDescRevisao.Text = veiculos[position].DescRevisao;
            return view;
        }
        public override Veiculo this[int position]
        {
            get
            {
                return veiculos[position];
            }
        }
        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

    }

}