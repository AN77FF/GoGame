public static class Locator
{
    public static IViewService ViewService { get; } = new ViewService();
    public static IDataBase DataBase { get; } = new DataBase();
    public static IViewModel ViewModel { get; } = new ViewModel();
    public static IDispatcherHelper DispatcherHelper { get; } = new DispatcherHelper();
    public static IMessageBoxService MessageBoxService { get; } = new MessageBoxService();
}
