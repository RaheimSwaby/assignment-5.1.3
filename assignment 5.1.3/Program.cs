namespace assignment_5._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter you array size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("enter a number {0}", i + 1);
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the numbers you entered are");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
            bool HasDuplicate = Duplicate(num);
            Console.WriteLine();
            Console.WriteLine($"the result of you numbers having duplicates:{HasDuplicate}");

        }
        public static bool Duplicate(int[] num)
        {
            //    HashSet<int> set = new HashSet<int>();
            //    foreach (int c in num)
            //    {
            //        if (set.Contains(c)) 
            //        {
            //            return true;
            //        }
            //        set.Add(c);
            //    }
            //    return false;

            //}
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int n in num)
            {
                if (dict.ContainsKey(n))
                {
                    return true; 
                }
                dict[n] = 1; // Add the number to the dictionary
            }
            return false;
        }
    }
}

