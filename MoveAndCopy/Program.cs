using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace MoveAndCopy
{
    class Program
    {
       
        static void Main(string[] args)
        {
            String path1 = "C://Users/admin/Desktop/essay1.txt";
            String path2 = "C://Users/admin/Desktop/ToDoList/essay.txt";
            FileInfo file = new FileInfo(path1);
            file.CopyTo(path2,true);
            File.Move(path2, "C://Users/admin/Desktop/essay.txt");

            Console.WriteLine(path1);
            Console.WriteLine(path2);
            Console.ReadKey();
        }
    }
}
