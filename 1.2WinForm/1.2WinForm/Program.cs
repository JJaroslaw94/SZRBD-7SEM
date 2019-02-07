using System;
using System.Text;

namespace _1._2WinForm
{
    public class Program
    {
        private static String[] tablica = {"Text1", "Text2", "Text3", "Text4", "Text5", "Text6", "Text7" };
        
        public static string[] Tablica { get => tablica; set => tablica = value; }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");

            foreach (String element in tablica)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();

            StringBuilder Sb = new StringBuilder("Czytam ");

            foreach (String element in tablica)
            {
                Sb.Append(element);
                DateTime czas = DateTime.Now;
                String czasPoConv = " teraz " + czas.Hour + "h " + czas.Minute + "m " + czas.Second + "s " + czas.Millisecond + "ms";
                Console.WriteLine(Sb + czasPoConv);
            }

            Console.ReadLine();

        }
    }
}
