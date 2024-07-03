using System.Xml.Linq;

namespace PracticalWork_8._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Info(person);

            Filling(person); 
        }
        static void Info(Person person) 
        {
            Console.WriteLine("Введите ФИО");

            person.Name = Console.ReadLine() ?? "";

            Console.WriteLine("Введите название улицы");

            person.StreetName = Console.ReadLine() ?? "";

            Console.WriteLine("Введите номер дома");

            person.HouseNumber = Console.ReadLine() ?? "";

            Console.WriteLine("Введите номер квартиры");

            person.FlatNumber = Console.ReadLine() ?? "";

            Console.WriteLine("Введите номер мобильного");

            person.Mobile = Console.ReadLine() ?? "";

            Console.WriteLine("Введите домашний номер");

            person.FlatPhone = Console.ReadLine() ?? "";
        }
        static void Filling(Person person) 
        {
            
            XElement xPerson = new XElement("Person");

            if(person.Name != null) 
            { 

            XAttribute name = new XAttribute("ФИО", person.Name);

            xPerson.Add(name);
            }


            XElement address = new XElement("Address");

            XElement street = new XElement("Street");

            street.Add(person.StreetName);



            XElement houseNumber = new XElement("HouseNumber");

            houseNumber.Add(person.HouseNumber);

            XElement flatNumber = new XElement("FlatNumber");

            flatNumber.Add(person.FlatNumber);


            address.Add(street, houseNumber, flatNumber);


            XElement phones = new XElement("Phones");

            XElement mobile = new XElement("MobilePhone");

            mobile.Add(person.Mobile);


            XElement flatPhone = new XElement("FlatPhone");

            flatPhone.Add(person.FlatPhone);


            phones.Add(mobile, flatPhone);


            xPerson.Add(address, phones);


            xPerson.Save(@"E:\Notebook2.xml");

        }
    }
}
