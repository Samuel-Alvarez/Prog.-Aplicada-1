namespace Cap4.Eje1;
class Program
{
    static void Main(string[] args)
    {
        int numero, resultado;
        Console.WriteLine("Digite el numero a multiplicar: ");
        numero = Convert.ToInt32(Console.ReadLine());

        for(int i = 1; i <= 10; i++)
        {
            resultado = numero * i; 
            Console.WriteLine($"{numero} x {i} = {resultado}");                 
        }
            
    }
}
