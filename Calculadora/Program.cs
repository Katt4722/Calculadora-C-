namespace Calculadora;
internal class Program
{
static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            double resultado = 0;
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Ingrese el primer número:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el operador:");
                string operador = Console.ReadLine();

                Console.WriteLine("Ingrese el segundo número:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                switch (operador)
                {
                    case "+":
                        resultado = calc.Sumar(num1, num2);
                        break;
                    case "-":
                        resultado = calc.Restar(num1, num2);
                        break;
                    case "*":
                        resultado = calc.Multiplicar(num1, num2);
                        break;
                    case "/":
                        resultado = calc.Dividir(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Operador no válido.");
                        continue;
                }

                Console.WriteLine($"El resultado es: {resultado}");

                Console.WriteLine("¿Quieres ingresar más números? (si/no)");
                string respuesta = Console.ReadLine().ToLower();

                if (respuesta != "si")
                {
                    continuar = false;
                }
            }

            Console.WriteLine("¡Gracias por usar la calculadora!");
        } 
}