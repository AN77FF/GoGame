public class DataBase : IDataBase
{
    private GoBoard _board;

    public DataBase(GoBoard board)
    {
        _board = board;
    }

    public void Save(string filePath)
    {
        
        using (var writer = new StreamWriter(filePath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(GoBoard));
            serializer.Serialize(writer, _board);
        }
    }

    public void Load(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(GoBoard));
            _board = (GoBoard)serializer.Deserialize(reader);
        }
    }
}
