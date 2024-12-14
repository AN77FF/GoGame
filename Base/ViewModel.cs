public class ViewModel : INotifyPropertyChanged, IViewModel
{
    public event PropertyChangedEventHandler PropertyChanged;

    private List<CpuModels> _cpuList;
    public List<CpuModels> CpuList
    {
        get => _cpuList;
        set
        {
            if (_cpuList != value)
            {
                _cpuList = value;
                OnPropertyChanged(nameof(CpuList));
            }
        }
    }

    public virtual void Initialize()
    {
        
        LoadCpuList();
    }

    private void LoadCpuList()
    {
        
        CpuList = new List<CpuModels>
        {
            new CpuModels { Name = "Intel Core i7", Cores = 8, Speed = 3.6 },
            new CpuModels { Name = "AMD Ryzen 5", Cores = 6, Speed = 3.4 },
            new CpuModels { Name = "Intel Core i5", Cores = 4, Speed = 3.0 },
            new CpuModels { Name = "AMD Ryzen 7", Cores = 8, Speed = 3.5 }
        };
    }

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
