using Exercise1.models;
using System;
using System.Collections.Generic;

namespace ItemRestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Worker myWorker = new Worker();

            Item newItem = new Item(1, "Fodbold", 3, 7);
            Item resultItem = myWorker.PostItem(newItem).Result;
            Console.WriteLine($"{resultItem.Id} - {resultItem.Name} - {resultItem.ItemQuality} - {resultItem.Quantity}");
            Console.WriteLine();
            IEnumerable<Item> items = myWorker.GetAllItemsAsync().Result;
            foreach(Item item in items)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - {item.ItemQuality} - {item.Quantity}");
            }
        }
    }
}
