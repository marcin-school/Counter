namespace Counter.Models
{
    public class CounterItem
    {
        public int Id { get; set; } = -1;
        public String Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int InitialValue { get; set; }
        public int Value { get; set; }
        public CounterItem() { }
        public CounterItem(String Name, String Description, int InitialValue) {
            this.Name = Name;
            this.Description = Description;
            this.InitialValue = InitialValue;
            this.Value = InitialValue;
        }
    }
}
