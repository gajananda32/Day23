using System;

namespace AddbUC7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> listPerson = new List<Person>();
            //DuplicateNameOf_Person(listPerson);
            //Search_Person_inCity(listPerson);
            //Count_NumberofPerson_inState(listPerson);
        }
        private static void ListPerson(List<Person> listofPerson)
        {
            listofPerson.Add(new Person("Anil", "Mumbai", "Maharastra"));
            listofPerson.Add(new Person("Ramesh", "Mumbai", "Maharastra"));
            listofPerson.Add(new Person("Aniket", "Bengaluru", "Karnataka"));
            listofPerson.Add(new Person("Joel", "Pune", "Maharastra"));
            listofPerson.Add(new Person("Anil", "Patna", "Bihar"));
        }
        /// <summary>
        /// AddressBook UC 7 No Duplicate 
        /// </summary>
        /// <param name="listofPerson"></param>
        private static void DuplicateNameOf_Person(List<Person> listofPerson)
        {
            foreach (Person i in listofPerson.FindAll(e =>( e.Name == e.Name)))
            Console.WriteLine("Name: " + i.Name+" CityName: "+i.City+" StateName: "+i.State);
        }
        /// <summary>
        /// AddressBook UC 9 Srearching the person in city
        /// </summary>
        /// <param name="listofPerson"></param>
        private static void Search_Person_inCity(List<Person> listofPerson)
        {
            foreach (Person i in listofPerson.FindAll(e => (e.City=="Anil")))
                Console.WriteLine("Name: " + i.Name + " CityName: " + i.City + " StateName: " + i.State);
        }
        private static void Search_Person_inState(List<Person> listofPerson)
        {
            foreach (Person i in listofPerson.FindAll(e => (e.State == "Anil")))
                Console.WriteLine("Name: " + i.Name + " CityName: " + i.City + " StateName: " + i.State);
        }
        /// <summary>
        /// AddressBook UC10 Counting the person in state
        /// </summary>
        /// <param name="listofPerson"></param>
        private static void Count_NumberofPerson_inState(List<Person> listofPerson)
        {
            foreach (Person i in listofPerson.Count(e => (e.State == "Maharastra"))
            {
                Console.WriteLine("Name: " + i.Name + " CityName: " + i.City + " StateName: " + i.State); 
            }
        }
    }
}