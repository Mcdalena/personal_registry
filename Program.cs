using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace personal_registry
{
    class Program
    {
        public static List<Person> personList = new List<Person> { };
        public static int personId=0;
        public static List<Person> getInformation() {
            Console.WriteLine("Enter a first name.");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter a last name.");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter an age.");
            int.TryParse(Console.ReadLine(), out int age);
            Console.WriteLine("Enter a gender (k/m)");
            char gender = Console.ReadKey().KeyChar;
            Console.WriteLine("\n-------------------------------------");
            Console.ReadKey();
            Console.WriteLine("Enter a street name.");
            string streetName = Console.ReadLine();
            Console.WriteLine("Enter a house number/local number.");
            string houseNumber = Console.ReadLine();
            Console.WriteLine("Enter a zip code.");
            string zipCode = Console.ReadLine();
            Console.WriteLine("Enter a city.");
            string city = Console.ReadLine();
            
            Address address = new Address(streetName, houseNumber, zipCode, city);
            Person person = new Person(personId, firstName, lastName, age, gender, address);
            personId++;
            Console.WriteLine("\n PERSON: "+ person.getInfo());
            Console.WriteLine("ADDRESS: "+address.getAddress()+"\n");

            personList.Add(person);
            return personList;
        }
        public static void editElement(int element)
        {
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Replace the entire item");
            Console.WriteLine("2) Replace the personal information");
            Console.WriteLine("3) Replace the address information");
            Console.WriteLine("4) Do not replace anything");
            Console.WriteLine("--------------------------------------");
            int.TryParse(Console.ReadLine(), out int option);

            string firstName, lastName, streetName, houseNumber, zipCode, city;
            int age, choice;
            char gender;
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter a first name.");
                    firstName = Console.ReadLine();
                    Console.WriteLine("Enter a last name.");
                    lastName = Console.ReadLine();
                    Console.WriteLine("Enter an age.");
                    int.TryParse(Console.ReadLine(), out age);
                    Console.WriteLine("Enter a gender (k/m)");
                    gender = Console.ReadKey().KeyChar;
                    Console.WriteLine("\n-------------------------------------");
                    Console.ReadKey();
                    Console.WriteLine("Enter a street name.");
                    streetName = Console.ReadLine();
                    Console.WriteLine("Enter a house number/local number.");
                    houseNumber = Console.ReadLine();
                    Console.WriteLine("Enter a zip code.");
                    zipCode = Console.ReadLine();
                    Console.WriteLine("Enter a city.");
                    city = Console.ReadLine();

                    Address address = new Address(streetName, houseNumber, zipCode, city);
                    personList[element] = new Person(element, firstName, lastName, age, gender, address);
                    break;
                case 2:
                    Console.WriteLine("Choose an option: ");
                    Console.WriteLine("1) Replace the entire personal information");
                    Console.WriteLine("2) Replace the first name");
                    Console.WriteLine("3) Replace the last name");
                    Console.WriteLine("4) Replace the age");
                    Console.WriteLine("5) Replace the gender");
                    Console.WriteLine("--------------------------------------");
                    int.TryParse(Console.ReadLine(), out choice);
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter a first name.");
                            firstName = Console.ReadLine();
                            Console.WriteLine("Enter a last name.");
                            lastName = Console.ReadLine();
                            Console.WriteLine("Enter an age.");
                            int.TryParse(Console.ReadLine(), out age);
                            Console.WriteLine("Enter a gender (k/m)");
                            gender = Console.ReadKey().KeyChar;

                            personList[element].FirstName = firstName;
                            personList[element].LastName = lastName;
                            personList[element].Age = age;
                            personList[element].Gender = gender;
                            break;
                        case 2:
                            Console.WriteLine("Enter a first name.");
                            firstName = Console.ReadLine();
                            personList[element].FirstName = firstName;
                            break;
                        case 3:
                            Console.WriteLine("Enter a last name.");
                            lastName = Console.ReadLine();
                            personList[element].LastName = lastName;
                            break;
                        case 4:
                            Console.WriteLine("Enter an age.");
                            int.TryParse(Console.ReadLine(), out age);
                            personList[element].Age = age;
                            break;
                        case 5:
                            Console.WriteLine("Enter a gender (k/m)");
                            gender = Console.ReadKey().KeyChar;
                            personList[element].Gender = gender;
                            break;
                        default:
                            editElement(element);
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Choose an option: ");
                    Console.WriteLine("1) Replace the entire address information");
                    Console.WriteLine("2) Replace the street name");
                    Console.WriteLine("3) Replace the house number/local number");
                    Console.WriteLine("4) Replace the zip code");
                    Console.WriteLine("5) Replace the city");
                    Console.WriteLine("--------------------------------------");
                    int.TryParse(Console.ReadLine(), out choice);
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter a street name.");
                            streetName = Console.ReadLine();
                            Console.WriteLine("Enter a house number/local number.");
                            houseNumber = Console.ReadLine();
                            Console.WriteLine("Enter a zip code.");
                            zipCode = Console.ReadLine();
                            Console.WriteLine("Enter a city.");
                            city = Console.ReadLine();

                            personList[element].Address.StreetName = streetName;
                            personList[element].Address.HouseNumber = houseNumber;
                            personList[element].Address.ZipCode = zipCode;
                            personList[element].Address.City = city;
                            break;
                        case 2:
                            Console.WriteLine("Enter a street name.");
                            streetName = Console.ReadLine();
                            personList[element].Address.StreetName = streetName;
                            break;
                        case 3:
                            Console.WriteLine("Enter a house number/local number.");
                            houseNumber = Console.ReadLine();
                            personList[element].Address.HouseNumber = houseNumber;
                            break;
                        case 4:
                            Console.WriteLine("Enter a zip code.");
                            zipCode = Console.ReadLine();
                            personList[element].Address.ZipCode = zipCode;
                            break;
                        case 5:
                            Console.WriteLine("Enter a city.");
                            city = Console.ReadLine();
                            personList[element].Address.City = city;
                            break;
                        default:
                            editElement(element);
                            break;
                    }
                    break;
                case 4:
                    displayMenu();
                    break;
                default:
                    editElement(element);
                    break;
            }
           
        }
        public static void displayMenu()
        {
            Console.WriteLine("--------------MENU-------------");
            Console.WriteLine();
            Console.WriteLine("1) Add to the registry.");
            Console.WriteLine("2) Find and edit a record.");
            Console.WriteLine("3) Find and delete a record.");
            Console.WriteLine("4) Show all records");
            Console.WriteLine("5) Export to XML.");
            Console.WriteLine("6) Exit.");
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            Console.WriteLine("Choose an option");
            int.TryParse(Console.ReadLine(), out int choice);

            while (choice!= 6)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter all necessary informations");
                        getInformation();
                        personList.ForEach(Console.WriteLine);
                        displayMenu();

                        break;
                    case 2:

                        if (personList.Count == 0)
                            Console.WriteLine("The list is empty.");
                        else
                        {
                            personList.ForEach(Console.WriteLine);
                            Console.WriteLine("Enter an ID to edit the record: ");
                            int.TryParse(Console.ReadLine(), out int element);
                            if (personList.Count >= element)
                            {
                                editElement(element);
                            }
                        }

                        displayMenu();
                        break;
                    case 3:
                        if (personList.Count == 0)
                            Console.WriteLine("The list is empty.");
                        else
                        {
                            personList.ForEach(Console.WriteLine);
                            Console.WriteLine("Enter an ID to delete the record: ");
                        int.TryParse(Console.ReadLine(), out int item);


                            if (personList.Count >= item){
                                personList.RemoveAll(x=> x.PersonId == item);
                            }
                        }
                        displayMenu();
                        break;
                    case 4:
                        personList.ForEach(Console.WriteLine);
                        displayMenu();
                        break;
                    case 5:
                        ISerialize xmlSerialize = new XmlSerialization();
                        xmlSerialize.serialize(personList);
                        break;
                    default:
                        Console.WriteLine("Wrong option. Please choose again.");
                        displayMenu();
                        break;
                }
            }
            if (choice == 6)
            {
                Console.WriteLine("Closing application...");
                Environment.Exit(0);
            }
            
        }

        public static void Main(string[] args)
        {
            displayMenu();
        }
    }
}
