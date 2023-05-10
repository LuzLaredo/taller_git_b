namespace nro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int num,num2,sum;
            string name = "luzlaredo";
            string apellido = "esmeralda";
            string nombrecompleto = name + apellido;
            Console.WriteLine("ingrese un numero");
            num=int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            sum = num + num2;

        }
    }
}