using System.IO;
using SQLite;
using AppXamarin_Forms.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(Database_ios))]
namespace AppXamarin_Forms.iOS
{
    public class Database_ios : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            var nomeDB = "projeto04.db";
            var personalFolder = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal));

            string LibraryFolder = Path.Combine(personalFolder, "..", "Lybray");

            string caminhoDoBanco = Path.Combine(LibraryFolder, nomeDB);

            return new SQLiteConnection(caminhoDoBanco);
        }

       
    }
}
