using System.Collections.ObjectModel;

namespace CollectionViewTest;

public partial class MainPage : ContentPage
{
    int count = 0;

    private CollectionWrapper _items = new();

    public CollectionWrapper Items
    {
        get => _items;
        set
        {
            _items = value;
            OnPropertyChanged();
        }
    }

    public MainPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        _ = Task.Delay(2000).ContinueWith((_) =>
        {
            for (int i = 0; i < 1000; i++)
            {
                Items.ToDisplay.Add(new DisplayItem
                {
                    Name = "Test item " + i.ToString()
                });
            }
        });
    }
}

