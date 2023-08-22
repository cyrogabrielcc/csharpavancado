using Microsoft.VisualBasic;

class Program
{
    public static void Main(string[] args)
    {
        NumberGenerator numberGenerator= new NumberGenerator();
        numberGenerator.OneGenerated += delegate(object sender, NumberEventsArgs args) 
    { 
        Console.WriteLine($"O numero gerado é {args.Number}");
    };
        numberGenerator.Start();
    }

}

public delegate void NumberHandler(object sender, NumberEventsArgs args);

class NumberGenerator
{
    public event NumberHandler OneGenerated;
    Random random = new Random();

    public void Start()
    {
        while (true)
        {
            var n = random.Next(10);

            if(OneGenerated != null)
            {
                NumberEventsArgs args = new NumberEventsArgs(){Number = n};
                OneGenerated(this, args);
            }

            Thread.Sleep(600);
        }
    }
}

public class NumberEventsArgs : EventArgs
{
    public int Number { get; set; }
}

