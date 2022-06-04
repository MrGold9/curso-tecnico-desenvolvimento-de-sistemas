﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace App.Crud_Xamarin.Resources
{
    class Aluno
    {


        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }

        public Aluno()
        { }


    }
}