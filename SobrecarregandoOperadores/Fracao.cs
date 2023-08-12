namespace SobrecarregandoOperadores
{
    public class Fracao : IEquatable<Fracao>
    {
       
        public Fracao(int numerador, int denominador) 
        {
            this.Numerador = numerador;
            this.Denominador = denominador;
        }
        public int Numerador { get; set; }
        public int Denominador { get; set;}

        public double Resultado => (double) Numerador / Denominador;

        public override string ToString()
        {
            return $" {Numerador}/{Denominador}";
        }

        public static Fracao operator *(Fracao f1, Fracao f2)
        {
            return new Fracao(f1.Numerador * f2.Numerador, f1.Denominador * f2.Denominador);
        }

        public static Fracao operator *(Fracao f, int n)
        {
            return new Fracao(f.Numerador * n, f.Denominador);
        }

        public static bool operator <=(Fracao f, Fracao f1)
        {
            return f.Resultado <= f1.Resultado ;
        }

        public static bool operator >= (Fracao f, Fracao f1)
        {
            return f.Resultado >= f1.Resultado ;
        }

        public static bool operator ==(Fracao f, Fracao f1)
        {
            return f.Equals(f1) ;
        }

        public static bool operator !=(Fracao f, Fracao f1)
        {
            return !f.Equals(f1) ;
        }

        public bool Equals(Fracao other)
        {
            return this.Resultado == other.Resultado;
        }

        public override bool Equals(object obj)
        {
            Fracao f = obj as Fracao;

            if (f == null)
            {
                return Equals(f);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Resultado.GetHashCode();
        }
    }
}