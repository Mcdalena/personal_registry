using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace personal_registry
{
    [Serializable]
    [XmlRoot("Person")]
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private char gender;
        private Address address;
        private int personId;


        public Person(int personId,string firstName, string lastName, int age, char gender, Address address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gender = gender;
            this.address = address;
            this.personId = personId;
        }
        public Person()
        {
        }

        [XmlAttribute("PersonId")]
        public int PersonId
        {
            get => personId;
            set => personId = value;
        }

        [XmlAttribute("PersonName")]
        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        [XmlAttribute("PersonName")]

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        [XmlAttribute("PersonAge")]
        public int Age
        {
            get => age;
            set => age = value;
        }

        [XmlAttribute("PersonGender")]
        public char Gender
        {
            get => gender;
            set => gender = value;
        }

        [XmlElement("PersonAddress")]
        public Address Address
        {
            get => address;
            set => address = value;
        }

        public string getInfo()
        {
            string g = (gender == 'k') ? "female" : "man";

            return $"Person: {firstName} {lastName}, {age}, {g}";
        }

        public override string ToString()
        {
            string g = (gender == 'k') ? "female" : "man";

            return $"ID: {personId}, Name: {firstName}, Surname: {lastName}, Age: {age}, Gender: {g}, Address: {address}";
        }

    }
}
