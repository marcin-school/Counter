using Counter.Models;

namespace Counter.Views;

public partial class CreateCounterPage : ContentPage
{
    public CreateCounterPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        String name = NameEntry.Text;
        String description = DescriptionEntry.Text;
        int initialValue = Int32.Parse(InitialValueEntry.Text);
        CounterItem counter = new CounterItem(name, description, initialValue);
        await App.Database.SaveItemAsync(counter);
    }
}