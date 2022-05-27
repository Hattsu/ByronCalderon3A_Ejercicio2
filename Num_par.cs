using System;
namespace ByronCalderon3A_Ej2
{
    public class Num_par
    {
        private double numero
        {
            set; get;
        }
        public Num_par (double numero)
        {
            this.numero = numero;
        }
        public void Elegir_par()
        {
            if(numero % 2 == 0)
            {
                Console.WriteLine("El número ingresado es par -> "+numero);
            }
            else
            {
                Console.WriteLine("El número ingresado es impar -> "+numero);
            }
            Console.ReadKey();
        }
    }
} 
