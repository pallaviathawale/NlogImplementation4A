using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogImplementaion
{
    internal class ArrayListOperation
    {

        public ArrayList myArrayList = new ArrayList();

        // Create operation: Adding items to the ArrayList
        public void AddItems()
        {

            myArrayList.Add("Apple");
            myArrayList.Add("Banana");
            myArrayList.Add("Orange");

        }
        //Read operation: Accessing items in the ArrayList
        public void ReadItems()
        {
            Console.WriteLine("Items in the ArrayList Are:");
            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }
        }

        // Update operation: Modifying an item in the ArrayList
        public void UpdateItems()
        {
            myArrayList[1] = "Mango";

            Console.WriteLine("\nUpdated ArrayList:");
            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }
        }
        // Delete operation: Removing an item from the ArrayList

        public void DeleteItem()
        {
            myArrayList.RemoveAt(0);

            Console.WriteLine("\nArrayList after removing an item:");
            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }
        }

    }   
}

