using System;
using System.Collections.Generic;

namespace string_list
{
    class MainClass
    {
        static List<string> list = new List<string>();

        public static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter pets name: ");
                string name = Console.ReadLine();
                list.Add(name);

            }
            foreach (string name in list)
            {
                Console.WriteLine(name);
            }
        }
    }
}

