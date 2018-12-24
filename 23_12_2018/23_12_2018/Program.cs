using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_12_2018
{   
    class Program
    {
        static void Main(string[] args)
        {
            var mustRun = true;
            string path = "stack_items.txt";
            Stack<string> list = new Stack<string>();
            Task.Run(() =>
            {
                //Thread.Sleep(30);
                using (StreamReader sr = new StreamReader(path))
                {
                    string line = null;
                    while ((line = sr.ReadLine()) != null)
                    {
                        list.Push(line);
                        Console.WriteLine("instack");
                    }
                }
            });
            while (mustRun)
            {
                Methods.writeToDB(list);
                Console.WriteLine(list.Count);
                if (list.Count==0) { mustRun = false; }
            }
        }
    }
}
