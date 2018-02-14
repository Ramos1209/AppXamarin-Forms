using AppXamarin_Forms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppXamarin_Forms.ViewModel
{
   public class TelaPrincipalViewModel
    {
        public List<Tarefa> tarefas { get; set; }

        public TelaPrincipalViewModel()
        {
            tarefas = new List<Tarefa>();
            tarefas.Add(new Tarefa { Id = 1, Nome = "tarefa 01", Finalizado = false });
            tarefas.Add(new Tarefa { Id = 2, Nome = "tarefa 02", Finalizado = false });
        }
    }
}
