using System.Collections.Generic;
using System.Linq;
namespace PracticingLamda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> listPersonInCity = new List<Person>();
            //AddRecords(listPersonInCity);
            Retriving_TopRecord(listPersonInCity);
        }
        private static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("2455623", "John", "12 MAin street", 15));
            listPersonInCity.Add(new Person("2455623", "Mathiv", "12 MAin street", 25));
            listPersonInCity.Add(new Person("2455623", "Marsel", "12 MAin street", 30));
            listPersonInCity.Add(new Person("2455623", "Megha", "12 MAin street", 60));
            listPersonInCity.Add(new Person("2455623", "Vicky", "12 MAin street", 80));
        }
        private static void Retriving_TopRecord(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age < 60)).Take(2))
            {
                Console.WriteLine("Name: " + person.Name + " Age: " + person.Age);
            }
        }
        //private static void RemoveSpecific(List<Person> listPersonInCity)
        //{
        //    foreach (Person person in listPersonInCity.FindAll(e => (e.Age < 60)).Take(2))
        //    {
        //        bool check=listPersonInCity.Re
        //        Console.WriteLine("Name: " + person.Name + " Age: " + person.Age);
        //    }
        //}
    }
}
