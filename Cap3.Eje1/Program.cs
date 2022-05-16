namespace Cap3.Eje1;

 class Program
{
    static void Main(string[] args)
    {

        int numero;

        Console.Write("Escriba el numero: ");
        numero = Convert.ToInt32(Console.ReadLine());

        if(numero % 2 == 0)
        {
            Console.WriteLine("Numero par");
         }
        else
         {
             Console.WriteLine("Numero impar");
         }
        Console.ReadKey();

    }
}
