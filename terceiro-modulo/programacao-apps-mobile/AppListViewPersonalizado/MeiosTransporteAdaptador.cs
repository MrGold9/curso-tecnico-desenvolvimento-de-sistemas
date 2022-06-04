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

namespace AppListViewPersonalizado
{
    class MeiosTransporteAdaptador : BaseAdapter<MeioTransporte>
    {
        //CRIAR A LISTA TIPADA BASEADA EM MeioTransporte
        private List<MeioTransporte> meioTransporte;

        //Criar um objeto do tipo Activity para inflar telas
        Activity contexto;


        //Método construtor que receberá a lista de itens
        //a ser inserida na ListView
        public MeiosTransporteAdaptador(List<MeioTransporte>meioTransporte, Activity activity)
        {
            this.meioTransporte = meioTransporte;
            this.contexto = activity;
        }

        public override MeioTransporte this[int position] 
        {
            get { return meioTransporte[position]; }
        }

        public override int Count 
        {
            get { return meioTransporte.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = meioTransporte[position];
            View view = convertView;
            if (view == null)
                view = contexto.LayoutInflater.Inflate(Resource.Layout.listItem, null);
            view.FindViewById<TextView>(Resource.Layout.nome).Text = item.nome;
            view.FindViewById<TextView>(Resource.Layout.descricao).Text = item.descricao;

            switch (item.imagem)
            {
                case 0:
                    view.FindViewById<ImageView>(Resource.Layout.imagem).SetImageResource(Resource.Drawable.aviao);
                    break;
                case 1:
                    view.FindViewById<ImageView>(Resource.Layout.imagem).SetImageResource(Resource.Drawable.carro);
                    break;
                case 2:
                    view.FindViewById<ImageView>(Resource.Layout.imagem).SetImageResource(Resource.Drawable.navio);
                    break;
                case 3:
                    view.FindViewById<ImageView>(Resource.Layout.imagem).SetImageResource(Resource.Drawable.onibus);
                    break;
            }
            return view;
        }
    }
}