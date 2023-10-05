using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ContactManager
{
    public static class ContactManager
    {
        #region Initialization

        public static List<string> NameList = new List<string>();
        public static List<int> NumberList = new List<int>();

        public static int EditNumber;

        #endregion

        #region Main

        public static void Main()
        {
            bool leave = false;
            while (!leave)
            {
                Console.WriteLine("Select one option:\n" +
                                  "[1]Create contacts.\n" +
                                  "[2]Search contacts.\n" +
                                  "[3]Edit contacts.\n" +
                                  "[4]Delete contacts.\n" +
                                  "[5]Show contacts.\n" +
                                  "[6]Leave."
                );
                try
                {
                    int option = int.Parse(Console.ReadLine());
                    
                    switch (option)
                    {
                        case 1:
                            CreateContact.Create();
                            break;
                        case 2:
                            SearchContact.Search();
                            break;
                        case 3:
                            EditContact.Edit();
                            break;
                        case 4:
                            DeleteContact.Delete();
                            break;
                        case 5:
                            ShowContacts.Show();
                            break;
                        case 6:
                            leave = true;
                            break;
                        default:
                            Console.WriteLine("ERROR, OUT OF THE RANGER");
                            break;
                    }
                    Console.WriteLine("\nPress any key to come back");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"INPUT NUMBERS ONLY: {ex}: \n");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"ERROR: THIS INDEX IS OUT OF RANGE: {ex}\n");
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine($"ERROR: WRITE SOMETHING, DON'T LEAVE IT BLANK:{ex}\n");

                }
                catch (SystemException ex)
                {

                    Console.WriteLine($"ERROR:{ex}\n");
                }

            }
            #endregion
        }
    }
}