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
using SQLite;

namespace AppAtividadeSQLite.Resources.Model
{
    class Veiculo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string NomeCarro { get; set; }
        public string Placa { get; set; }
        public DateTime DataRevisao { get; set; }
        public string DescRevisao {get;set;}

        public Veiculo()
        { }

    }
}