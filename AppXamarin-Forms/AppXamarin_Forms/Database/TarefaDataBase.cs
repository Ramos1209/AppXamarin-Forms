using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Xamarin.Forms;
using AppXamarin_Forms.Models;

namespace AppXamarin_Forms.Database
{
   public class TarefaDataBase
    {
        private SQLiteConnection _database;

        public TarefaDataBase()
        {
            _database = DependencyService.Get<IDatabase>().GetConnection();
            _database.CreateTable<Tarefa>();
        }

        public List<Tarefa> GetTarefa()
        {
            return _database.Table<Tarefa>().ToList();
        }
        public int SalvarTarefa(Tarefa tarefa)
        {
            return _database.Insert(tarefa);
        }

        public int UpdateTarefa(Tarefa tarefa)
        {
            return _database.Update(tarefa);
        }
        public int DeleteTarefa(Tarefa tarefa)
        {
            return _database.Delete(tarefa);
        }
    }
}
