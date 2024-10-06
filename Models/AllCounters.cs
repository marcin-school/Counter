namespace Counter.Models
{
    public class AllCounters
    {
        public Task<List<CounterItem>> Items {
            get {
                return App.Database.GetItemsAsync();
            }
        }
    }
}
