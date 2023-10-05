using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactManager
{
    public static class CreateContact
    {
        public static void Create()
        {
            Console.Write("Enter contact name: ");
            string nameContact = Console.ReadLine();

            nameContact = char.ToUpper(nameContact[0]) + nameContact.Substring(1);
            Console.Write("Enter contact number: ");

            int numberContact = int.Parse(Console.ReadLine());

            if (!ContactManager.NameList.Contains(nameContact) && !ContactManager.NumberList.Contains(numberContact))
            {
                ContactManager.NameList.Add(nameContact);


                ContactManager.NumberList.Add(numberContact);
                Console.WriteLine("Contact added!");
            }
            else
            {
                Console.WriteLine("ERROR: This contact already exists"); 
            }
        }
    }
}