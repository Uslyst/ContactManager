using System;

namespace ContactManager
{
    public static class DeleteContact
    {
        public static void Delete()
        {
            ShowContacts.Show();

            Console.WriteLine("\nSelect the index contact that you want to remove");
            ContactManager.EditNumber = int.Parse(Console.ReadLine());

            ContactManager.NameList.RemoveAt(ContactManager.EditNumber);

            ContactManager.NumberList.RemoveAt(ContactManager.EditNumber);

        }
    }
}
