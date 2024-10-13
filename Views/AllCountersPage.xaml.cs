using Counter.Models;

namespace Counter.Views;

public partial class AllCountersPage : ContentPage
{
	public AllCountersPage()
	{
		InitializeComponent();
        listView.ItemsSource = new AllCounters().Items;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(CreateCounterPage));
    }
}