namespace CEx3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1º número! ");
            int num1 = int.Parse(Console.ReadLine()!);
            Console.Write("\nDgite o 2º Número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int maior = Math.Max(num1, num2);

            Console.WriteLine($"\n0 Numero {maior} é o maior valor!");
        }
    }
}
