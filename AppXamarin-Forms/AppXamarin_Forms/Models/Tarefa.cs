using System;
using System.Collections.Generic;
using SQLite;

namespace AppXamarin_Forms.Models
{
    [Table("Tbl_Tarefa")]
   public class Tarefa
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Finalizado { get; set; }
    }
}
