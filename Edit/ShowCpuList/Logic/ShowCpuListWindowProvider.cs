public class ShowCpuListWindowProvider : IShowCpuListWindowProvider
{
    public void ShowCpuList()
    {
        ShowCpuListWindow window = new ShowCpuListWindow();
        window.ShowDialog(); 
    }
}
