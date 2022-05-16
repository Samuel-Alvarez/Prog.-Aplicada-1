namespace Cap4.Eje2;

class Program
{
    public static void Main()
    {
        int numero = 2, potencia = 7;
        double elevado = Math.Pow(numero, potencia);
        Console.WriteLine(string.Format("{0} elevado a {1} es: {2}", numero, potencia, elevado));
    }
}