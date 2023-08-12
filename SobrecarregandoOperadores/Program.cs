using SobrecarregandoOperadores;

class Program
{
    public static void Main(string[] args)
    {
        Fracao f1 = new Fracao(5 ,15);
        Fracao f2 = new Fracao(5 ,15);
        Fracao f3 = f1*f2;

        System.Console.WriteLine(f3);
    }
}
