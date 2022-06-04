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

namespace CrudGoogleFirebase.Model
{
    public class mangas
    {

        public string id { get; set; }
        public string manga { get; set; }
        public int estoque { get; set; }
        public string descricao { get; set; }
        public string nome { get; set; }


        public mangas()
        {

        }

        public mangas(string manga, int estoque, string descricao, string nome)
        {
            this.manga = manga;
            this.estoque = estoque;
            this.descricao = descricao;
            this.nome = nome;
        }



    }
}