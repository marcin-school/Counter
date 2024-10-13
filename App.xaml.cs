using Counter.Data;

namespace Counter
{
    public partial class App : Application
    {
        private static Database? database;
        public static Database Database {
            get {
                if (database == null)
                {
                    var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    var databasePath = Path.Combine(folderPath, "database.json");
                    database = new Database(databasePath);
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
