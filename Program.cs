using System.Runtime.CompilerServices;
internal class Program
{
    static void Main(string[] args) {

        Program calculadora = new Program();

        Console.WriteLine("Ingrese un num: ");
        int numero1 = (Convert.ToInt16(Console.ReadLine()));

        Console.WriteLine("Ingrese el segundo num:");
        int numero2 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la operacion deseada: ");
        string operacion = Console.ReadLine();

        if (operacion == "+")
        {
            Console.WriteLine(Sumar(numero1, numero2));
        } 
        else if (operacion == "-" ) 
        {
            Console.WriteLine(Resta(numero1, numero2));
        }

        if (operacion == "*")
        {
            Console.WriteLine(Multiplicacion(numero1, numero2));
        }
        else if (operacion == "/")
        {
            Console.WriteLine(Division(numero1, numero2));
        }
    }
    public static int Sumar(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int Resta(int numero1, int numero2)
    {
        return numero1 - numero2;
    }
    public static int Multiplicacion(int Num1, int Num2)
    {
        return Num1 * Num2;
    }
    public static double Division(int Numero1, int Numero2)
    {
        return Numero1 / Numero2;
    }
}
