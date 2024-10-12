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
        if (NameEntry.Text == null) return;
        if (DescriptionEntry.Text == null) return;
        if (InitialValueEntry.Text == null) return;
        String name = NameEntry.Text;
        String description = DescriptionEntry.Text;
        int initialValue = Int32.Parse(InitialValueEntry.Text);
        NameEntry.Text = null;
        DescriptionEntry.Text = null;
        InitialValueEntry.Text = null;
        CounterItem counter = new CounterItem(name, description, initialValue);
        await App.Database.SaveItemAsync(counter);
        await Shell.Current.GoToAsync("..");
    }
}