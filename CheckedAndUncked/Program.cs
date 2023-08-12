class Program {
    public static void Main(String[] args){
        short short1 = 32000; 
        short short2 = 25000;
        /*
        checked{
        short short3 = (short) (short1+short2);
        Console.WriteLine(short3);
        }*/

        unchecked{
        short short3 = (short) (short1+short2);
        Console.WriteLine(short3);
        }
    }
}
