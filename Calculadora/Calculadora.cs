namespace Calculadora;

public class Calculadora
{
        public double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Restar(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Dividir(double num1, double num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir entre 0.");
                return double.NaN;
            }
            return num1 / num2;
        }
    }
