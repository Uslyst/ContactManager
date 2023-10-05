using System;

namespace ContactManager
{
    public static class ShowContacts
    {
        public static void Show()
        {
            int index = 0;
            foreach (string name in ContactManager.NameList)
            {
                Console.WriteLine($"\n[{index}]-{name}-{ContactManager.NumberList[index]}");

                index += 1;
            }
        }
    }
}