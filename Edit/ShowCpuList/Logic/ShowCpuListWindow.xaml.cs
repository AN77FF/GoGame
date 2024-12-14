using System.Collections.Generic;
using System.Windows;

public partial class ShowCpuListWindow : Window
{
    public List<CpuModels> CpuList { get; set; }

    public ShowCpuListWindow()
    {
        InitializeComponent();
        LoadCpuList();
        DataContext = this;
    }

    private void LoadCpuList()
    {
        
        CpuList = new List<CpuModels>
        {
            new CpuModels { Name = "Intel Core i7", Cores = 8, Speed = 3.6 },
            new CpuModels { Name = "AMD Ryzen 5", Cores = 6, Speed = 3.4 }
        };
    }
}
