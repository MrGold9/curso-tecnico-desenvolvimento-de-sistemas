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

namespace ListViewPersonalizada.Resources
{
    class MeiosTransporteAdaptor : BaseAdapter<MeioTransporte>
    {

        private List<MeioTransporte> meioTransportes;

        Activity contexto;

        public MeiosTransporteAdaptor(List<MeioTransporte> meioTransportes, Activity activity)
        {
            this.meioTransportes = meioTransportes;
            this.contexto = activity;
        }

        public override MeioTransporte this[int position] => throw new NotImplementedException();

        public override int Count
        {
            get { return meioTransportes.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = meioTransportes[position];
            View view = convertView;
            if (view == null)
                view = contexto.LayoutInflater.Inflate(Resource.Layout.listItem, null);
            view.FindViewById<TextView>(Resource.Id.lista_transporte_personalizada_nome).Text = item.nome;
            view.FindViewById<TextView>(Resource.Id.lista_transporte_personalizada_descricao).Text = item.descricao;
            switch (item.imagem)
            {
                case 0:
                    view.FindViewById<ImageView>(Resource.Id.lista_transporte_personalizada_imagem).SetImageResource(Resource.Drawable.Aviao);
                    break;
                case 1:
                    view.FindViewById<ImageView>(Resource.Id.lista_transporte_personalizada_imagem).SetImageResource(Resource.Drawable.Carro);
                    break;
                case 2:
                    view.FindViewById<ImageView>(Resource.Id.lista_transporte_personalizada_imagem).SetImageResource(Resource.Drawable.Navio);
                    break;
                case 3:
                    view.FindViewById<ImageView>(Resource.Id.lista_transporte_personalizada_imagem).SetImageResource(Resource.Drawable.Onibus);
                    break;
            }
            return view;
        }
    }
}