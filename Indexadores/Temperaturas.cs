using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Indexadores
{
    public class Temperaturas
    {
        int [] temperaturas = { 35,33,32,24,26,28,16,25,32,34,38,40,40,41,29};

        public int this[int mes] 
        { 
            get
            {
                return temperaturas[mes-1];
            }

            set
            {
                temperaturas[mes-1] = value;
            }
        }
        public int this[string mes]
        {
            get
            {
                switch (mes)
                {
                    case "jan" : return temperaturas[0];                    
                    case "fev" : return temperaturas[1];                    
                    case "mar" : return temperaturas[2];                    
                    case "abr" : return temperaturas[3];                    
                    case "mai" : return temperaturas[4];                    
                    case "jun" : return temperaturas[5];                    
                    case "jul" : return temperaturas[6];                    
                    case "ago" : return temperaturas[7];                    
                    case "set" : return temperaturas[8];                    
                    case "out" : return temperaturas[9];                    
                    case "nov" : return temperaturas[10];                    
                    case "dez" : return temperaturas[11];                    
                
                    default : return -1;
                }
            }
        }
    }
}