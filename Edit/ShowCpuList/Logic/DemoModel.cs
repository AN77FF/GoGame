public class CpuModels
{
    public string Name { get; set; }
    public int Cores { get; set; }
    public double Speed { get; set; }

    public override string ToString()
    {
        return $"{Name} - {Cores} cores, {Speed} GHz";
    }
}
