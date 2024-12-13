public class Cpu
{
    private GoBoard _board;

    public Cpu(GoBoard board)
    {
        _board = board;
    }

    public void MakeMove()
    {
        Random random = new Random();
        int x, y;

        do
        {
            x = random.Next(0, _board.Size);
            y = random.Next(0, _board.Size);
        } while (_board.Stones[x, y] != null);

        _board.PlaceStone(x, y, new Stone { Color = "Black" }); 
    }
}
