namespace CEx6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu nome: ");
            string nome = Console.ReadLine()!;
            Console.Write("\nIforme o numero de horas trabalhadas: ");
            int quantidaeHoras = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIrforme o valor da hora: ");
            double valorhora = Convert.ToDouble(Console.ReadLine());

            double resultado = valorhora * quantidaeHoras;

            Console.WriteLine($"A renda total de {nome} é R$ {resultado:F2}");
        }
    }
}
