namespace ListTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var objs = new List<object>();
            objs.Add(2.5d);
            objs.Add(2.0d);
            objs.Add(3);
            objs.Add(2);
            objs.Add("Hello ");
            objs.Add("world");

            int sumInt = 0;
            double sumDouble = 0;
            string sumString = "";

            foreach(var obj in objs)
            {
                Console.WriteLine(obj.GetType());
                if (obj.GetType() == typeof(int))
                {
                    sumInt += (int)obj;
                }
                if (obj.GetType() == typeof(double)) { sumDouble += (double)obj; }
                if (obj.GetType() == typeof(string)) { sumString += (string)obj; }

            }
            Console.WriteLine("Sum of ints is: {0}",sumInt);
            Console.WriteLine("Sum of doubles is: {0}", sumDouble);
            Console.WriteLine("Sum of strings is: {0}", sumString);
        }
    }
}
