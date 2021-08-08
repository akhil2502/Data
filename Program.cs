using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();
            Console.WriteLine("-----------------");
            int value = linkedList.Search(30);
            linkedList.InsertAtParticularPosition(value + 1, 40);
            linkedList.Display();
        }
    }
}