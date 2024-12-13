public class EditCpuViewModel : ViewModel
{
    public CpuModels CpuModel { get; set; }
    public ICommand SaveCommand { get; }

    public EditCpuViewModel(CpuModels model)
    {
        CpuModel = model;

        SaveCommand = new RelayCommand(SaveChanges);
    }

    public void SaveChanges()
    {
        
        MessageBox.Show($"Сохранено: {CpuModel.ToString()}");
    }
}
