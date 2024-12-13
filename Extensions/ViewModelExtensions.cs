public static class ViewModelExtensions
{
    public static void UpdateData<T>(this ViewModelT<T> viewModel, T newData)
    {
        viewModel.Data = newData;
    }
}
