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
using AppAtividadeSQLite.Resources.Model;
using Android.Util;


namespace AppAtividadeSQLite.Resources.DataBaseHelper
{
    class DataBase
    {



        string pasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        public bool CriarBancoDeDados()
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Veiculos.db")))
                {
                    conexao.CreateTable<Veiculo>();
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public bool InserirVeiculo(Veiculo veiculo)
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Veiculos.db")))
                {
                    conexao.Insert(veiculo);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public List<Veiculo> GetVeiculos()
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Veiculos.db")))
                {
                    return conexao.Table<Veiculo>().ToList();
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return null;
            }
        }
        public bool AtualizarVeiculo(Veiculo veiculo)
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Veiculos.db")))
                {
                    conexao.Query<Veiculo>("UPDATE Veiculo set NomeCarro=?,Placa=?, DataRevisao=?, DescRevisao=? Where Id=?", veiculo.NomeCarro, veiculo.Placa, veiculo.DataRevisao, veiculo.DescRevisao, veiculo.Id);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public bool DeletarVeiculo(Veiculo veiculo)
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Veiculos.db")))
                {
                    conexao.Delete(veiculo);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }
        public bool GetVeiculo(int Id)
        {
            try
            {
                using (var conexao = new SQLiteConnection(System.IO.Path.Combine(pasta, "Alunos.db")))
                {
                    conexao.Query<Veiculo>("SELECT * FROM Veiculo Where Id=?", Id);
                    //conexao.Update(aluno);
                    return true;
                }
            }
            catch (SQLiteException ex)
            {
                Log.Info("SQLiteEx", ex.Message);
                return false;
            }
        }

    }

}