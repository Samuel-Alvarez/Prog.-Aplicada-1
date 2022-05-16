namespace Cap2.Eje3
{
    class Program
    {
        static void Main(string[] args)
        {
            float grado;
             double radian;

            Console.Write("Digite los Grados: ");
            grado = Convert.ToSingle(Console.ReadLine());

            radian = grado / 57.2957795;

            Console.WriteLine("Radianes: " + radian);
            Console.ReadKey();

           
        }
    }

}