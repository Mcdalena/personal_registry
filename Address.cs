using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace personal_registry
{
    [Serializable]
    [XmlRoot("Address")]
    class Address
    {
        private string streetName;
        private string houseNumber;
        private string zipCode;
        private string city;

        public Address(string streetName, string houseNumber, string zipCode, string city)
        {
            this.streetName = streetName;
            this.houseNumber = houseNumber;
            this.zipCode = zipCode;
            this.city = city;
        }

        [XmlAttribute("AddressStreet")]
        public string StreetName
        {
            get => streetName;
            set => streetName = value;
        }

        [XmlAttribute("AddressHouseNumber")]
        public string HouseNumber
        {
            get => houseNumber;
            set => houseNumber = value;
        }

        [XmlAttribute("AddressZipCode")]
        public string ZipCode
        {
            get => zipCode;
            set => zipCode = value;
        }

        [XmlAttribute("AddressCity")]
        public string City
        {
            get => city;
            set => city = value;
        }

        public string getAddress()
        {
            return $"Address: {streetName} {houseNumber}, {zipCode} {city}";
        }
        public Address() { }
        public override string ToString()
        {
            return $"Street: {streetName} {houseNumber}, City: {city} Zip: {zipCode}";
        }
    }
}
