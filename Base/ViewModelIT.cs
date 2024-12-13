public class ViewModelT<T> : ViewModel
{
    private T _data;
    public T Data
    {
        get => _data;
        set
        {
            _data = value;
            OnPropertyChanged(nameof(Data));
        }
    }
}
