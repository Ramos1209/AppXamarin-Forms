using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Windows.Storage;
using System.IO;

namespace AppXamarin_Forms.UWP
{
    public class Database_WP : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            var nomeDB = "projeto04.db";
            var caminhoDoBanco = Path.Combine(ApplicationData.Current.LocalFolder.Path ,nomeDB);
            return new SQLiteConnection(caminhoDoBanco);
        }
    }
}
