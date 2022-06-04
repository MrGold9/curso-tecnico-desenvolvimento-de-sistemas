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

using AppSQLite.Resources.Model;

namespace AppSQLite
{
    class ListAdapter : BaseAdapter<Aluno>
    {
        Activity context;

        private List<Aluno> alunos;

        public ListAdapter(Activity _context, List<Aluno> _alunos)
        {
            this.context = _context;

            this.alunos = _alunos;
        }

        public override int Count

        {
            get
            {
                return alunos.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return alunos[position].Id;

            //return position; 
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = alunos[position];

            var view = convertView;

            if (view == null)

                view = context.LayoutInflater.Inflate(Resource.Layout.listViewLayout, null);

            var lvtxtNome = view.FindViewById<TextView>(Resource.Id.txtvNome);

            var lvtxtIdade = view.FindViewById<TextView>(Resource.Id.txtvIdade);

            var lvtxtEmail = view.FindViewById<TextView>(Resource.Id.txtvEmail);

            lvtxtNome.Text = alunos[position].Nome;

            lvtxtIdade.Text = "" + alunos[position].Idade;

            lvtxtEmail.Text = alunos[position].Email;

            return view;
        }

        public override Aluno this[int position]
        {
            get
            {
                return alunos[position];
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

    }
} 