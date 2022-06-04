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
using Java.Lang;
using CrudGoogleFirebase.Model;



namespace CrudGoogleFirebase
{
    class MangaAdapter : BaseAdapter<mangas>
    {

        Activity activity;
        List<mangas> listaMangas;

        public MangaAdapter(Activity activity, List<mangas> listaMangas)
        {
            this.activity = activity;
            this.listaMangas = listaMangas;
        }

        public override mangas this[int position]
        {
            get { return listaMangas[position]; }
        }

        public override int Count
        {
            get { return listaMangas.Count; }
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
            var item = listaMangas[position];
            View itemView = convertView;
            if (itemView == null)
            {
                itemView = activity.LayoutInflater.Inflate(Resource.Layout.itemLista, null);
            }
            itemView.FindViewById<TextView>(Resource.Id.list_NomeManga).Text = item.manga;
            itemView.FindViewById<TextView>(Resource.Id.list_Estoque).Text = "" + item.estoque;
            itemView.FindViewById<TextView>(Resource.Id.list_DescManga).Text = item.descricao;
            itemView.FindViewById<TextView>(Resource.Id.list_NomePessoa).Text = item.nome;
            return itemView;
        }


    }
}