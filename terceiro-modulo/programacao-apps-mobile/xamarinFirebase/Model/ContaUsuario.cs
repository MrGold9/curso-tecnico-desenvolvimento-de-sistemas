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

namespace xamarinFirebase.Model
{
    public class ContaUsuario
    {
            public string id { get; set; }
            public string nome { get; set; }
            public string email { get; set; }
            public ContaUsuario()
            {

            }

            public ContaUsuario(string nome, string email)
            {
                this.nome = nome;
                this.email = email;
            }
    }


}