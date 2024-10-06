using SQLite;
using Counter.Models;

namespace Counter.Data
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;
        public Database(String dpPath) {
            _database = new SQLiteAsyncConnection(dpPath);
            _database.CreateTableAsync<CounterItem>().Wait();
        }
        public async Task<List<CounterItem>> GetItemsAsync() {
            return await _database.Table<CounterItem>().ToListAsync();
        }
        public async Task<int> SaveItemAsync(CounterItem counter) {
            return await _database.InsertAsync(counter);
        }
        public async Task<int> UpdateItemAsync(CounterItem counter) {
            return await _database.UpdateAsync(counter);
        }
    }
}
