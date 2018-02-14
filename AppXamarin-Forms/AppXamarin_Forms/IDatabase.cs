using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;



namespace AppXamarin_Forms
{
    public interface IDatabase
    {
        SQLiteConnection GetConnection();
    }
}
