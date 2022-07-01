using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_banca_oop
{
    internal class ConsoleCreation
    {
        public static void Title(string title, string subtitle = "")
        {
            Console.WriteLine($"****** {title} ******\n");
            if(subtitle != "")
            {
                Console.WriteLine(subtitle + "\n");
            }
        }
    }
}
