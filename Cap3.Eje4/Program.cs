namespace Cap3.Eje4;
class Program
{
 static void Main(string[] args)
    {

        int numero;

        Console.Write("Digite un numero: ");
        numero = Convert.ToInt32(Console.ReadLine());

    if (numero == 1)
        Console.WriteLine("Lunes");
    else if (numero == 2)
        Console.WriteLine("Martes");
    else if (numero == 3)
        Console.WriteLine("Miercoles");
    else if (numero == 4)
        Console.WriteLine("Jueves");
    else if (numero == 5)
        Console.WriteLine("Viernes");
     else if (numero==6)
        Console.WriteLine("Sabado");
    else if (numero == 7)
         Console.WriteLine("Domingo");
     else
        Console.WriteLine("No es un dia de la semana!");
        Console.ReadKey();
    }
}

