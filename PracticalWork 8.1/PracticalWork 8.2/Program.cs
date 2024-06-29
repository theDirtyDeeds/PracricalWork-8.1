namespace PracticalWork_8._2
{
    internal class Program
    {
        static Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            PhoneBook();
            FindContact();
        }
        #region Добавление контактов
        static void PhoneBook() 
        {
            
            while (true)
            {

                Console.WriteLine("Введите номер телефона");

                string phoneNumber = Console.ReadLine();

                if(String.IsNullOrEmpty(phoneNumber)) break;

                Console.WriteLine("Введите ФИО");

                string contactName = Console.ReadLine();

                phoneBook[phoneNumber] = contactName;

            }
            
        }
        #endregion
        #region Поиск контактов
        static void FindContact() 
        {
            
            Console.WriteLine("Для поиска введите номер абонента");

            string number  = Console.ReadLine();

            if (phoneBook.TryGetValue(number, out string contactName)) 
            {
                Console.WriteLine($"ФИО: {contactName}");
            }
            else
            {
                Console.WriteLine("Контакт не найден");
            }
        }
        #endregion
    }
}
