using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiApp2.ViewModel;

//Used CommunityToolkit
public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        Items = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<string> items; // Items Property가 ObservableProperty에 의해서 자동으로 생성됨

    [ObservableProperty]
    string? text; // Text Property가 ObservableProperty에 의해서 자동으로 생성됨

    [RelayCommand]
    void Add()
    {
        if (string.IsNullOrWhiteSpace(Text))
            return;

        Items.Add(Text);
        // add our item
        Text = string.Empty;
    }

    [RelayCommand]
    void Delete(string s)
    {
        if (Items.Contains(s))
        {
            Items.Remove(s);
        }
    }
}

// Using CommunityToolkit.Mvvm, 위와 같이 간략히 표현
//public class MainViewModel : INotifyPropertyChanged
//{
//    string text;
//    public string Text
//    {
//        get => text;
//        set
//        {
//            text = value;
//            OnPropertyChanged(nameof(Text));
//        }
//    }
//    public event PropertyChangedEventHandler? PropertyChanged;
//    void OnPropertyChanged(string name) => 
//        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
//}
