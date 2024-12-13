public class ShowCpuListViewModel : ViewModel
{
    public ObservableCollection<CpuModels> CpuList { get; }

    public ShowCpuListViewModel()
    {
        CpuList = new ObservableCollection<CpuModels>();
        LoadCpuList(); 
    }

    private void LoadCpuList()
    {
        
        CpuList.Add(new CpuModels { Name = "AlphaGo", SkillLevel = 10, Strategy = "Aggressive" });
        CpuList.Add(new CpuModels { Name = "DeepMind", SkillLevel = 8, Strategy = "Defensive" });
    }
}
