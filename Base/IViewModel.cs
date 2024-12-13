public interface IViewModel
{
    void Initialize();
    event PropertyChangedEventHandler PropertyChanged;
}
