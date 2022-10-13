using System;

namespace ejercicio_6_tp_6
{
    class Program
    {
        static void Main(string[] args)
        {   float a,b,resultado=0;
            int eleccion;

            Console.Clear();

            Console.WriteLine("¡Que operacion desea realizar?");
            Console.WriteLine("Presione 1 para Suma");
            Console.WriteLine("Presione 2 para Resta");
            Console.WriteLine("Presione 3 para Multiplicacion");
            Console.WriteLine("Presione 4 para Division");
            eleccion = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();

            Console.WriteLine("Digite el primer numero: ");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero: ");
            b = float.Parse(Console.ReadLine());
            
            
            
            switch (eleccion)
            {
                case 1: 
                resultado =  SumaNumeros(a,b);
                Console.WriteLine("El resultado es: {0}",resultado);
                break;

                case 2:
                resultado =  RestaNumeros(a,b);
                Console.WriteLine("El resultado es: {0}",resultado);
                break;

                case 3:
                resultado =  ProductoNumeros(a,b);
                Console.WriteLine("El resultado es: {0}",resultado);
                break;

                case 4:
                resultado =  DivisionNumeros(a,b);
                Console.WriteLine("El resultado es: {0}",resultado);
                break;

                default:
                Console.WriteLine("Reinicie el programa");
                break;
            }

          
            
        }

        static float SumaNumeros(float a,float b){
            
            return a + b;
            
        }

        static float RestaNumeros(float a,float b){
            
            return a - b;
            
        }

        static float ProductoNumeros(float a,float b){
            
            return a * b;
            
        }
        
        
        static float DivisionNumeros(float a,float b){
            
            return a / b;
            
        }
    }
}
