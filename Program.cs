internal class Program
{

    static void Main(string[] args) {
        Program calculadora = new Program();
        Console.WriteLine(calculadora.Sumar(2, 3));
    }
    public int Sumar(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Resta(int numero1, int numero2)
    {
        return numero1 - numero2;
    }
    public int Multipicacion(int Num1, int Num2)
    {
        return Num1 * Num2;
    }
    public double Divion(int Numero1, int Numero2)
    {
        return Numero1 / Numero2;
    }
}
