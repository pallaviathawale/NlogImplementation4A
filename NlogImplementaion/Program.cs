using NLog;

namespace NlogImplementaion
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //ArrayListOperation arrayListOperation = new ArrayListOperation();
           // arrayListOperation.AddItems();
           // arrayListOperation.ReadItems();
           // arrayListOperation.UpdateItems();
           // arrayListOperation.DeleteItem();

            DictionaryOperations dictionaryOperations = new DictionaryOperations();
            dictionaryOperations.AddItem();
            dictionaryOperations.ReadItem();
            dictionaryOperations.UpdateItem();
            dictionaryOperations.DeleteItem();
        }
    }
    
}