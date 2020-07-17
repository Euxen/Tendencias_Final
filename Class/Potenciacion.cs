using System;

namespace tendencias_lab_final.Class
{
    public class Calculator
    {
        public static int Potencia(int base_in, int exponent_in)
        {
            
            if (exponent_in < 0 || base_in > int.MaxValue || exponent_in > int.MaxValue)
            {
                return 0;
            }
            

            int temp = base_in, result = base_in;

            for (int i = 1; i < exponent_in; i++)
            {
                result = result * temp;
            }

            return result;
        }

    }
    
}