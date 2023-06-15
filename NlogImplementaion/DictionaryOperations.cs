using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogImplementaion
{
    internal class DictionaryOperations
    {
        Dictionary<Int32,string> myDictionary = new Dictionary<Int32,string>();


        // Create operation: Adding key-value pairs to the Dictionary
        public void AddItem()
        {
            myDictionary.Add(1,"Apple");
            myDictionary.Add(2,"Banana");
            myDictionary.Add(3,"Orange");

        }
        //Read operation: Accessing items in the Dictionary
        public void ReadItem()
        {
            Console.WriteLine("Items in the Dictionary:");
            foreach (var pair in myDictionary)
            {
                Console.WriteLine("Key: " + pair.Key + ", Value: " + pair.Value);
            }
        }

        // Update operation: Modifying a value in the Dictionary
        public void UpdateItem()
        {
            int keyToUpdate = 2;
            if (myDictionary.ContainsKey(keyToUpdate))
            {
                myDictionary[keyToUpdate] = "Mango";
                Console.WriteLine("\nUpdated Dictionary:");
                foreach (var pair in myDictionary)
                {
                    Console.WriteLine("Key: " + pair.Key + ", Value: " + pair.Value);
                }
            }
            else
            {
                Console.WriteLine("\nInvalid key for update operation");
            }

        }
        // Delete operation: Removing an item from the Dictionary
        public void DeleteItem()
        {
            int keyToDelete = 1;
            if (myDictionary.ContainsKey(keyToDelete))
            {
                myDictionary.Remove(keyToDelete);
                Console.WriteLine("\nDictionary after removing an item:");
                foreach (var pair in myDictionary)
                {
                    Console.WriteLine("Key: " + pair.Key + ", Value: " + pair.Value);
                }
            }
            else
            {
                Console.WriteLine("\nInvalid key for delete operation");
            }
        }
    }
    
}
