namespace PracticalWork_8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindContact();
        }
        #region Добавление контактов
        static Dictionary<string, string> PhoneBook() 
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            while (true)
            {

                Console.WriteLine("Введите номер телефона");

                string phoneNumber = Console.ReadLine();

                if(String.IsNullOrEmpty(phoneNumber)) break;

                Console.WriteLine("Введите ФИО");

                string contactName = Console.ReadLine();

                phoneBook.Add(phoneNumber, contactName);
            }
            return phoneBook;
        }
        #endregion
        #region Поиск контактов
        static void FindContact() 
        {
            Dictionary<string, string> contactNumber = PhoneBook();

            Console.WriteLine("Для поиска введите номер абонента");

            string number  = Console.ReadLine();

            if (contactNumber.TryGetValue(number, out string contactName)) 
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
