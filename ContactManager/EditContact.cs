using System;

namespace ContactManager
{
    public static class EditContact
    {
        public static void Edit()
        {
            ShowContacts.Show();

            Console.WriteLine("\nSelect index contacts");
            
            ContactManager.EditNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Edit name contact");
            string editNameContact = Console.ReadLine();

            ContactManager.NameList[ContactManager.EditNumber] = editNameContact;
            Console.Write("Modify contact number?[Y/N] ");
            string answear = Console.ReadLine();
            answear = answear.ToUpper();

            if (answear[0] == 'Y')
            {
                Console.WriteLine("Edit number: ");
                int contactNumber = int.Parse(Console.ReadLine());

                if (!ContactManager.NumberList.Contains(contactNumber))
                {
                    ContactManager.NumberList[ContactManager.EditNumber] = contactNumber;
                    Console.WriteLine("Contact Added!");
                }
                else
                {
                    Console.WriteLine("This number is already taken.");
                }
            }
        }

    }
}
