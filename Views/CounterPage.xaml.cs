using Counter.Models;

namespace Counter.Views
{
    public partial class CounterPage : ContentPage
    {
        private CounterItem _item;
        public CounterPage()
        {
            InitializeComponent();
            if (AllCounters.CurrentItem == null) throw new Exception();
            _item = AllCounters.CurrentItem;
        }
    }
}