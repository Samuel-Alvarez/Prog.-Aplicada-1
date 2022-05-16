namespace Cap3.Eje5;
class Program
{
    static void Main(string[] args)
    {
        double apotema, area, longlado, lados, perimetro;
        int opcion = 0;
        Console.WriteLine("Que operacin deseas hacer? ");
        Console.WriteLine("1- Perimetro");
        Console.WriteLine("2- Area");
        Console.Write("Digite el valor de apotema: ");
        apotema = double.Parse(Console.ReadLine());
        Console.Write("Digite el valor de longitud de lado: ");
        longlado = double.Parse(Console.ReadLine());
        Console.Write("Digite numero de lados: ");
        lados = double.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                perimetro = lados*longlado;
            break;
         
            case 2:
                area = apotema * apotema *lados*Math.Tan(Math.PI / lados);
            break;
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimetro: " + perimetro);
            Console.ReadKey();
        }
    }
}    


