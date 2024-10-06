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
                    var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "items.db");
                    database = new Database(dbPath);
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
