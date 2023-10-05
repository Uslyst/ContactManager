using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public static class SearchContact
    {
        public static void Search()
        {
            Console.WriteLine("Name contact: ");
            string nameToFind = Console.ReadLine();

            if (nameToFind != null)
            {
                nameToFind = char.ToUpper(nameToFind[0]) + nameToFind.Substring(1);

                int indexNumber = ContactManager.NameList.IndexOf(nameToFind);

                Console.WriteLine($"{nameToFind}");


                Console.WriteLine(ContactManager.NumberList[indexNumber]);

            }
        }
}
}
