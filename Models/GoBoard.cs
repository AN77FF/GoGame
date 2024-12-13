public class GoBoard
{
    public int Size { get; private set; }
    public Stone[,] Stones { get; private set; }

    public GoBoard(int size)
    {
        Size = size;
        Stones = new Stone[size, size];
    }

    public void PlaceStone(int x, int y, Stone stone)
    {
        if (Stones[x, y] == null)
        {
            Stones[x, y] = stone;
        }
    }
}
