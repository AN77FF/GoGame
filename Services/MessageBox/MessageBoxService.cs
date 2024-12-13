public class MessageBoxService : IMessageBoxService
{
    public void ShowMessage(string message)
    {
        MessageBox.Show(message);
    }
}
