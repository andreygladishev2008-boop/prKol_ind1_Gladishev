using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace zadanie_1
{
    class Program
    {
        static void Main()
        {
            Stack reverser = new Stack("файл.txt", "новый файл.txt");
            reverser.ReverseAndSave();
            Console.ReadKey();
        }
    }
}

