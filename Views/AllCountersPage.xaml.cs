namespace Counter.Views;

public partial class AllCountersPage : ContentPage
{
	public AllCountersPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(CreateCounterPage));
    }
}