using System;
namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Program");
            LinkList list = new LinkList();
            list.Add(56);
            //list.Add(30);
            list.Add(70);
            //list.Display();
            list.InsertAtParticularPosition(2, 30);
            list.RemoveFirstNode();
            Console.ReadKey();
        }
    }
}
