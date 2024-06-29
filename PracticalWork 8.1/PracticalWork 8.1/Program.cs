namespace PracticalWork_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Delete();
        }
        #region Заполнение
        static List<int> Filling()
        {
            Console.WriteLine("Исходный список");

            Random rand = new Random();

            List<int> numbers = new List<int>();

            for (int i = 0; i <= 100; i++)
            {
                numbers.Add(rand.Next(0, 101));
            }
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            return numbers;
        }
        #endregion
        #region Удаление элементов
        static void Delete()
        {
            List<int> numbers = Filling();

            numbers.RemoveAll(n => n > 25 && n < 50);

            Console.WriteLine("Нажмите любую клавишу для удаления элементов");

            Console.ReadLine();

            Console.WriteLine("Cписок после удаления");

            Output(numbers);
            
        }
        #endregion
        #region Вывод на экран
        static void Output(List<int> numbers)
        {
            foreach (int number in numbers) 
            {
                Console.WriteLine(number);
            }

        }
        #endregion
    }

}
