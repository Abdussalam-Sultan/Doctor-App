using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Services
    {
        public static T GetById<T>(int id, List<T> list)
        {
            if(id <= 0 || id > list.Count)
            {
                return default;
            }
            else
            {

                return (list.ElementAt(id - 1));
            }
        }
        public static void TextColor(ConsoleColor color, string text)
        { 
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
