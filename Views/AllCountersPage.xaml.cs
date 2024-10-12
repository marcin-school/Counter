namespace Counter.Views;

public partial class AllCountersPage : ContentPage
{
	public AllCountersPage()
	{
		InitializeComponent();
        LoadData();
	}

	private async void LoadData() {
        listView.ItemsSource = await App.Database.GetItemsAsync();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(CreateCounterPage));
    }
}