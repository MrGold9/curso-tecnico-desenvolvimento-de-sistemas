using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Fone_Mundo

{
    [Activity(Label = "AtividadeHistoricoTradutor")]
    public class AtividadeHistoricoTradutor : Activity
    {
        public ArrayAdapter<string> ListAdapter { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            var NumeroTelefones = Intent.Extras.GetStringArrayList("fone_numeros") ?? new string[0];

            this.ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1,NumeroTelefones);
        }
    }
}