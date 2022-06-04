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
    class VideoGames
    {
        public string nome { get; set; }
        public string descricao { get; set; }
        public int imagem { get; set; }


        public VideoGames()
        {
            nome = "";
            descricao = "";
            imagem = 0;
        }
    }
}