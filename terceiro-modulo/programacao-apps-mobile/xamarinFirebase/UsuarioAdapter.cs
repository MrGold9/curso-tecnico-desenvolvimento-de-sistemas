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

using xamarinFirebase.Model;

namespace xamarinFirebase
{
    class UsuarioAdapter : BaseAdapter<ContaUsuario>
    {


        Activity activity;
        List<ContaUsuario> listaUsuarios;

        public UsuarioAdapter(Activity activity, List<ContaUsuario> listaUsuarios)
        {
            this.activity = activity;
            this.listaUsuarios = listaUsuarios;

        }

        public override ContaUsuario this[int position]
        {
            get { return listaUsuarios[position]; }
        }

        public override int Count
        {
            get { return listaUsuarios.Count; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = listaUsuarios[position];
            View itemView = convertView;
            if (itemView == null)
            {
                itemView = activity.LayoutInflater.Inflate(Resource.Layout.itemLista, null);
            }
            itemView.FindViewById<TextView>(Resource.Id.list_nome).Text = item.nome;
            itemView.FindViewById<TextView>(Resource.Id.list_email).Text = item.email;
            return itemView;
        }


    }
}