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
            label_name.Text = _item.Name;
            label_description.Text = _item.Description;
            label_value.Text = _item.Value.ToString();
        }

        private void btn_minus_Clicked(object sender, EventArgs e)
        {
            _item.Value -= 1;
            label_value.Text = _item.Value.ToString();
            App.Database.UpdateItem(_item);
        }

        private void btn_plus_Clicked(object sender, EventArgs e)
        {
            _item.Value += 1;
            label_value.Text = _item.Value.ToString();
            App.Database.UpdateItem(_item);
        }
    }
}