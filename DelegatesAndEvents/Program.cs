using System.Threading;
using System.Reflection.PortableExecutable;

class Program
{
    public static void Main(string[] args)
    {
        Semaphore s = new Semaphore();
        s.Init();
    }

}

enum Color {
    Red,
    Green,
    Yellow
}

class Semaphore
{
    Color color = Color.Red;
    public void Init()
    {
        while (true)
        {
            if (color == Color.Red) color = Color.Green;
            else if (color == Color.Green) color = Color.Yellow;
            else if (color == Color.Yellow) color = Color.Red;

            System.Console.WriteLine($"Change to: {color}");

            Thread.Sleep(2000);
        }
    }
}
