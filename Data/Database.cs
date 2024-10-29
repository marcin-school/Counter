using Counter.Models;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Counter.Data
{
    public class Database
    {
        private readonly String _file;
        private readonly List<CounterItem> _items = new();
        public Database(String dbPath) {
            _file = dbPath;
            CreateStructureIfNotExist();
            LoadFile();
        }
        protected void CreateStructureIfNotExist() {
            if (!File.Exists(_file))
            {
                String content = "{\"items\": []}";
                File.WriteAllText(_file, content);
            }
        }
        protected void LoadFile() {
            String content = File.ReadAllText(_file);
            JsonArray array = JsonNode.Parse(content)["items"].AsArray();
            foreach (JsonNode item in array.ToList())
            {
                _items.Add(JsonSerializer.Deserialize<CounterItem>(item.ToString()));
            }
        }
        protected void UpdateFile() {
            String array = JsonSerializer.Serialize(_items);
            String content = "{\"items\": " + array + "}";
            File.WriteAllText(_file, content);
        }
        public List<CounterItem> GetItems() {
            return _items;
        }
        public int SaveItem(CounterItem counter) {
            int newId = -1;
            foreach (CounterItem item in _items)
            {
                newId = Math.Max(item.Id, newId);
            }
            newId = (newId != -1) ? newId + 1 : 0;
            counter.Id = newId;
            _items.Add(counter);
            UpdateFile();
            return newId;
        }
        public int UpdateItem(CounterItem counter) {
            int counterId = counter.Id;
            if (counterId == -1) throw new Exception("CounterItem does not have any valid id");
            if (!_items.Exists(item => item.Id == counterId)) throw new Exception("Cannot find CounterItem with given id");
            int arrayId = _items.FindIndex(item => item.Id == counterId);
            _items[arrayId] = counter;
            UpdateFile();
            return counterId;
        }
        public void DeleteItem(CounterItem counter) {
            int counterId = counter.Id;
            if (counterId == -1) throw new Exception("CounterItem does not have any valid id");
            if (!_items.Exists(item => item.Id == counterId)) throw new Exception("Cannot find CounterItem with given id");
            _items.Remove(counter);
            UpdateFile();
        }
    }
}
