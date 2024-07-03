using System.Xml.Linq;

namespace PracticalWork_8._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XElement person = new XElement("Person");

            Console.WriteLine("Введите ФИО");

            string namePerson = Console.ReadLine();

            XAttribute name = new XAttribute("ФИО", namePerson);

            person.Add(name);

            XElement address  = new XElement("Address");

            XElement street = new XElement("Street");

            Console.WriteLine("Введите название улицы");

            string streetName = Console.ReadLine();

            street.Add(streetName);

            XElement houseNumber = new XElement("HouseNumber");

            Console.WriteLine("Введите номер дома");

            string house = Console.ReadLine();

            houseNumber.Add(house);

            XElement flatNumber = new XElement("FlatNumber");

            Console.WriteLine("Введите номер квартиры");

            string apartmentNumber = Console.ReadLine();

            flatNumber.Add(apartmentNumber);

            address.Add(street, houseNumber, flatNumber);

            XElement phones = new XElement("Phones");

            XElement mobile = new XElement("MobilePhone");

            Console.WriteLine("Введите номер мобильного");

            string mobilePhone = Console.ReadLine();

            mobile.Add(mobilePhone);

            XElement flatPhone = new XElement("FlatPhone");

            Console.WriteLine("Введите домашний номер");

            string homePhone = Console.ReadLine();

            flatPhone.Add(homePhone);

            phones.Add(mobile, flatPhone);

            person.Add(address, phones);

            person.Save(@"\Notebook.xml");
        }

    }
}
