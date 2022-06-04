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

namespace AppListViewAdapterHerdado
{
    class VideoGamesAdaptador : BaseAdapter<VideoGames>
    {
        private List<VideoGames> videoGame;


        Activity contexto;


        public VideoGamesAdaptador(List<VideoGames> videoGame, Activity activity)
        {
            this.videoGame = videoGame;
            this.contexto = activity;
        }


        public override VideoGames this[int position]
        {
            get { return videoGame[position]; }
        }

        public override int Count 
        {
            get { return videoGame.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = videoGame[position];
            View view = convertView;
            if (view == null)
            {
                view = contexto.LayoutInflater.Inflate(Resource.Layout.listItem, null);
            }
            view.FindViewById<TextView>(Resource.Id.lst_nome).Text = item.nome;
            view.FindViewById<TextView>(Resource.Id.lst_descricao).Text = item.descricao;

            switch (item.imagem)
            {
                case 0:
                    view.FindViewById<ImageView>(Resource.Id.lst_imagem).SetImageResource(Resource.Drawable.ps1);
                    break;
                case 1:
                    view.FindViewById<ImageView>(Resource.Id.lst_imagem).SetImageResource(Resource.Drawable.ps2);
                    break;
                case 2:
                    view.FindViewById<ImageView>(Resource.Id.lst_imagem).SetImageResource(Resource.Drawable.ps3);
                    break;
                case 3:
                    view.FindViewById<ImageView>(Resource.Id.lst_imagem).SetImageResource(Resource.Drawable.ps4);
                    break;
            }
            return view;
        }
    }
}