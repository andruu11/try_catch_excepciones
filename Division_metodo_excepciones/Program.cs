using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_metodo_excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca primer numero");
            int primer_numero = Convert.ToInt32(Console.ReadLine()); // almacenamos el primer numero en una variable double
            Console.WriteLine("Introduzca segundo numero");
            int segundo_numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La division de los numero es"+ " " + Dividir(primer_numero, segundo_numero)); // imprimos la division, invocamos al metodos (enviamos las variables a ser divididas)
            Console.ReadKey();
        }

       
        static string Dividir(int num1, int num2) //metodo de tipo string, que recibe variables tipo entero (declaramos nuevas variables para ser recibidas)
        {
            //el bolque try-catch es un controlador de excepciones
            try//en caso de que la division pueda realizarse
            {
                int div = num1 / num2; // almacenamos la division en una variable div
                return Convert.ToString(div); // convertimos en string el entero div para que sea devuelta ante la invocacion del metodo
            }
            catch (DivideByZeroException e)//en caso que un numero sea dividido entre 0
                //almacenamos la excepcion en una variable e
            {
                return Convert.ToString(e); // convertimos en tipo de dato string la excepcion para ser devuelta ante la invocacion del metodo
            }
            catch{// en caso de que  se considere otra excepcion
                return "Error de ejecucion"; // enviamos el mensaje tipo string ante la invocacion del metodo
            }
        }
    }
}
