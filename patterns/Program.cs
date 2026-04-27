var a = Singletone.Instance;
var b = Singletone.Instance;

Console.WriteLine(ReferenceEquals(a, b));
public class Singletone
{
    private static readonly Singletone _instance = new Singletone();

    public static Singletone Instance => _instance;
    
    private Singletone()
    {

    }
}

