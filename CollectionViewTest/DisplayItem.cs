using CommunityToolkit.Mvvm.ComponentModel;

namespace CollectionViewTest;
public partial class DisplayItem : ObservableObject
{
    [ObservableProperty] private string _name;
}
