using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


[assembly: Xamarin.Forms.Dependency(typeof(Database_android))]
namespace AppXamarin_Forms.Droid
{
    public class Database_android : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            var nomeDB = "projeto04.db";
            var caminhoDoBanco = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), nomeDB);
            return new SQLiteConnection(caminhoDoBanco);
        }
    }
}