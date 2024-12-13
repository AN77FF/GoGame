public class GoViewModel : ViewModel
{
    public GoBoard Board { get; private set; }
    public Cpu Ai { get; private set; }
    public ICommand PlaceStoneCommand { get; private set; }

    public GoViewModel(int size)
    {
        Board = new GoBoard(size);
        Ai = new Cpu(Board);
        PlaceStoneCommand = new RelayCommand(ExecutePlaceStone);
    }

    private void ExecutePlaceStone()
    {
        
        Ai.MakeMove();
        OnPropertyChanged(nameof(Board));
    }
}
