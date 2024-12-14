using System.Windows;

public partial class EditCpuWindow : Window
{
    public EditCpuWindow(CpuModels model)
    {
        InitializeComponent();
        DataContext = new EditCpuViewModel(model);
    }
}
