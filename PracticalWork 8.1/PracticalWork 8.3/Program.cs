
namespace PracticalWork_8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            while (true)
            {
                Console.WriteLine("Введите число в коллекцию");

                string number = Console.ReadLine();

                if (String.IsNullOrEmpty(number)) break;

                if (set.Contains(number))
                {

                    Console.WriteLine("Такое число уже есть");
                }
                else 
                {
                    set.Add(number);
                    Console.WriteLine("Число добавлено в коллекцию");
                }
                
            }
            foreach (string s in set)
            {
                Console.WriteLine(s);
            }
        }
    }
}
