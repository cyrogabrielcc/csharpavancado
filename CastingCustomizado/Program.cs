class Program
{
    public static void Main(string[] args)
    {
        LetraAlfabeto la = new LetraAlfabeto("b");
        char c = la
    }
}

class LetraAlfabeto
{
    char caractere;

    public Program(char caractere)
    {
        this.caractere = char.ToUpper(caractere);
    }

    public static implicit operator char(LetraAlfabeto la)
    {
        return la.caractere;
    }

       public static implicit operator LetraAlfabeto(char c)
    {
        return new LetraAlfabeto(c);
    }
}