using System;
class Program
{
    public static void Main(string[] args)
    {
        


        Temperature t= new Temperature();
        
        Console.WriteLine("Insira a medida: ");
        var tempMetric = Console.ReadLine();
        
        Console.WriteLine("Insira o valor: ");
        var value = Double.Parse(Console.ReadLine());
        
        //TempConverter convertToC = t.ToCelcius;
        //TempConverter convertToF = t.ToFiren;

        // Aceita metodos void
        Action<double> AconvertToF = t.PrintToFiren;
        Action<double> AconvertToC = t.PrintToCelcius;

        // Não aceita void
        Func<double, double> convertToF = t.ToFiren;
        Func<double, double> convertToC = t.ToCelcius;
        
        if (tempMetric == "F") Console.WriteLine(convertToF(value));
        if (tempMetric == "C") Console.WriteLine(convertToC(value));
        else Console.WriteLine("Não Encontrado!");
          
            
        
    }
}

public delegate double TempConverter(double temp);

class Temperature
{
    public double ToFiren(double celcius)
    {
       return (celcius * 9 / 5) + 32;
    }

    public double ToCelcius(double firen)
    {
        return (firen  - 32) * 5/9;
    }

    public void PrintToCelcius(double firen)
    {
        Console.WriteLine($"O valor em Firenheit é: {ToCelcius(firen).ToString("F2")}");
    }
    public void PrintToFiren(double celcius)
    {
        Console.WriteLine($"O valor em Celcius é: {ToFiren(celcius).ToString("F2")}");
    }
}