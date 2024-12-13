public class ViewModel : INotifyPropertyChanged, IViewModel
{
    public event PropertyChangedEventHandler PropertyChanged;

    public virtual void Initialize() { /* Initialization logic */ }

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
