using System.Threading;
using System.Reflection.PortableExecutable;
using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        Semaphore s = new Semaphore();
    
        for (int i=1; i<=3; i++)
        {
            Vehicle vehicle= new Vehicle(i);
            s.AddCallback(vehicle.AlteredSemaphore);
        }
        
        s.Init();
    }

    

}


// Create Delegate
delegate void SemaphoreHandler(Color color);

enum Color 
{
    Red,
    Green,
    Yellow
}

class Semaphore
{
    Color color = Color.Red;
    SemaphoreHandler? callbacks;
    public void Init()
    {
        while (true)
        {
            if (color == Color.Red) color = Color.Green;
            else if (color == Color.Green) color = Color.Yellow;
            else if (color == Color.Yellow) color = Color.Red;

            System.Console.WriteLine($"Change to: {color}");
            callbacks(color);
            Thread.Sleep(2000);
        }
    }

    public void AddCallback(SemaphoreHandler handler) => callbacks += handler;
}
class Vehicle
{
    int id;
    public Vehicle(int id) => this.id = id;

    public void AlteredSemaphore(Color color) => System.Console.WriteLine($"Carro notificado - Cor: {color}");
}