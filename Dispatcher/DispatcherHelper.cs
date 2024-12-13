public class DispatcherHelper : IDispatcherHelper
{
    public void Invoke(Action action)
    {
        Application.Current.Dispatcher.Invoke(action);
    }
}
