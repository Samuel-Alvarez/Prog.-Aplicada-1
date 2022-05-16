namespace Cap2Eje1;

class Program
{
    static void Main(String[] args)
    {
        int cantlados;
        float lado, perimetro;

        Console.Write("Cantidad de lados de la figura: ");
        cantlados = Int32.Parse(Console.ReadLine());
        Console.Write("\nMedida lado: ");
        lado = Single.Parse(Console.ReadLine());

        perimetro = cantlados * lado;

        Console.WriteLine("Perimetro: {0} ", perimetro);
    }
    
}
