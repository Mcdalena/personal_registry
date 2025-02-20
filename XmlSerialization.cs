﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace personal_registry
{
    class XmlSerialization : ISerialize
    {
        public void serialize(List<Person> personList)
        {
            Console.WriteLine(" --- XML SERIALIZATION ---");
            Console.WriteLine("Display the list");
            personList.ForEach(Console.WriteLine);

            Console.WriteLine("Serialize ...");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));

            try
            {
                using (TextWriter writer = new StreamWriter(@"./persons.xml"))
                {
                    serializer.Serialize(writer, personList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Clear the list");
            personList.Clear();
            Console.WriteLine($"List size= {personList.Count}");


            Console.WriteLine("Deserialize ...");
            List<Person> newPersonList = new List<Person>();
            try
            {
                using (TextReader reader = new StreamReader(@"./persons.xml"))
                {
                    var obj = serializer.Deserialize(reader);
                    newPersonList = (List<Person>)obj;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"List size= {newPersonList.Count}");
            newPersonList.ForEach(Console.WriteLine);
        }
    }
}