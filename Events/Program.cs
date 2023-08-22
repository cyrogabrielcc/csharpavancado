class Program
{
    public static void Main(string[] args)
    {
        NumberGenerator numberGenerator= new NumberGenerator();
        numberGenerator.OneGenerated += NumberGenerated;
        numberGenerator.Start();
    }

    static void NumberGenerated(int n) => Console.WriteLine($"O numero gerado é {n}");
}

public delegate void NumberHandler(int i);

class NumberGenerator
{
    public event NumberHandler OneGenerated;
    Random random = new Random();

    public void Start()
    {
        while (true)
        {
            var n = random.Next(100);

            if(OneGenerated != null)  OneGenerated(n) ;

            Thread.Sleep(600);
        }
    }
}