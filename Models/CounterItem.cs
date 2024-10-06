using SQLite;

namespace Counter.Models
{
    public class CounterItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public String Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int InitialValue { get; set; }
        public int Value { get; set; }
        public CounterItem() { }
        public CounterItem(String Name, String Description, int InitialValue) {
            this.Name = Name;
            this.Description = Description;
            this.InitialValue = InitialValue;
        }
    }
}
