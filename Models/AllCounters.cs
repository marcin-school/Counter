namespace Counter.Models
{
    public class AllCounters
    {
        public List<CounterItem> Items {
            get {
                return App.Database.GetItems();
            }
        }
    }
}
