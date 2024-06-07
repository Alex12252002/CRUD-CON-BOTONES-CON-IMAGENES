using System;
using System.IO;
using Xamarin.Forms;

namespace CRUD
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        static SQLiteHelper db;

        public static SQLiteHelper SQLiteDb
        {
            get
            {
                if (db == null)
                {
                    string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "XamarinSQLite.db3");
                    db = new SQLiteHelper(dbPath);
                }
                return db;
            }
        }

    }
}
