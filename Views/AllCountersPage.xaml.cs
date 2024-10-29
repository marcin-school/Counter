using Counter.Models;

namespace Counter.Views;

public partial class AllCountersPage : ContentPage
{
    public static AllCountersPage Instance { get; private set; }
	public AllCountersPage()
	{
        Instance = this;
		InitializeComponent();
        UpdateData();
    }

    public void UpdateData() {
        listView.ItemsSource = null;
        listView.ItemsSource = new AllCounters().Items;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(CreateCounterPage));
    }
}