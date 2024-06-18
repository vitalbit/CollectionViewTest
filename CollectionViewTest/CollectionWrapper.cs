using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewTest;
public class CollectionWrapper : INotifyPropertyChanged
{
    private ObservableCollection<DisplayItem> _toDisplay = [];

    public ObservableCollection<DisplayItem> ToDisplay
    {
        get { return _toDisplay; }
        set 
        { 
            _toDisplay = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        if (propertyName is not null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
