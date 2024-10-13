using Counter.Models;

namespace Counter.Data
{
    public class Database
    {
        public Database(String dbPath) {}
        public List<CounterItem> GetItems() {
            return new List<CounterItem>();
        }
        public int SaveItem(CounterItem counter) {
            return 0;
        }
        public int UpdateItem(CounterItem counter) {
            return 0;
        }
    }
}
