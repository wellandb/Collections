namespace DictionaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> numberNames =new Dictionary<string,int>();
            numberNames.Add("Joe", 22);
            //adding a key/value using the Add() method
             numberNames.Add("Jack", 23);
            numberNames.Add("Tom", 24);
            foreach(KeyValuePair< string,int > kvp in numberNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            IDictionary<string,string> objectTypes =new Dictionary< string,string >();
            objectTypes.Add( "Fruits","Apple, Banana, Orange, Grapes, Pineapple");
            objectTypes.Add("Vegetables","Sprouts, Carrots, Cauliflower, Peas");
            objectTypes.Add("Furnitures","Table, Chair, Sofa, Stool");
            objectTypes.Add("Hardware","Hammer, Screwdriver, Nails, Screws, crowbar");
            foreach(KeyValuePair<string , string> kvp in objectTypes)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("-----------Exercises-------------");
            // Indexer for a dictionary
            string[] indexer = objectTypes.Keys.ToArray();
            Console.WriteLine("Key: {0}, Value: {1}", indexer[0], objectTypes[indexer[0]]);
            Console.WriteLine("------------------------");

            // Change first key from Fruits to Fruits (Yummy)
            var value = objectTypes[indexer[0]];
            objectTypes.Remove(indexer[0]);
            objectTypes["Fruits (Yummy)"] = value;

            foreach (KeyValuePair<string, string> kvp in objectTypes)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("------------------------");
            objectTypes.Remove(indexer[^1]);
            foreach (KeyValuePair<string, string> kvp in objectTypes)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

            Console.ReadLine();
        }
    }
}
