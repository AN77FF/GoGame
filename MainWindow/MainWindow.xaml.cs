public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
public ICommand ShowCpuListCommand { get; private set; }
public ICommand EditCpuCommand { get; private set; }

public GoViewModel(int size)
{
    Board = new GoBoard(size);
    Ai = new Cpu(Board);
    ShowCpuListCommand = new RelayCommand(ShowCpuList);
    EditCpuCommand = new RelayCommand(EditCpu);
}

private void ShowCpuList()
{
    Locator.ShowCpuListWindowProvider.ShowCpuList();
}

private void EditCpu()
{
    
    if (Ai.CpuModels != null && Ai.CpuModels.Any())
    {
        Locator.EditWindowProvider.ShowEditWindow(Ai.CpuModels[0]);
    }
}
    }
}
