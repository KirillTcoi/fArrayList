using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Hello = new List<string>() { "Hi", "Hey", "Hallo", "Salut", "Whats up?" };
            Console.WriteLine("Новоё приветсвие: ");
            string NewQ = Console.ReadLine();
            //Hello.Add("Q");
            Console.Clear();
            if (NewQ != null)
            {
                Hello.Insert(0, NewQ);
                Console.WriteLine("Успех!");
            }
            else
                Console.WriteLine("Ошибка");
            Hello.ForEach(VV); //Вывод списка
            Console.ReadKey();
            Console.WriteLine("Удаление из списка приветствий\r\nВведите фразу, которую хотите удалить");
            bool b = false;
            string DelQ = Console.ReadLine();
            foreach (string q in Hello)
                if (q == DelQ)
                    b = true;
            Console.Clear();
            if (b == true)
            {
                Hello.Remove(DelQ);
                Console.WriteLine("Успех!");
            }
            else
                Console.WriteLine("Ошибка");
            Hello.ForEach(VV);//Вывод списка
            Console.ReadKey();             
        }
        public static void VV(string ZDOROVA) 
        {
            Console.WriteLine(ZDOROVA);
        }
    }
    
}

