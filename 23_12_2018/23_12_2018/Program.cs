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
            var isWriting = true;
            var items = Methods.readFromFileAsync(@"C:\Users\FaridAz\Desktop\stack_items.txt");
            while (isWriting)
            {
                Methods.writeToDB(items.Result);
                if (items.Result.Count==0) { isWriting = false; }
            }
        }
    }
}
