public class EditCpuWindowProvider : IEditWindowProvider
{
    public void ShowEditWindow()
    {
        EditCpuWindow window = new EditCpuWindow();
        window.ShowDialog();
    }
}
