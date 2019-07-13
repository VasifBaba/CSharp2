 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iyul13
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person();
            Console.Write("Zehmet olmasa adinizi daxil edin :");
            string ad = Console.ReadLine();
            Console.Write("Zehmet olmasa email daxil edin :");
            string email = Console.ReadLine();

            int d = 0;

            while (d == 0)
            {
                Console.Write("Zehmet olmasa yasinizi daxil edin :");
                string yas= Console.ReadLine();
                
                try
                {
                    byte yeniyas = Convert.ToByte(yas);
                    d = 1;
                    newPerson.deyerotur(ad, email, yeniyas);
                    Console.WriteLine(newPerson.name + " " + newPerson.email + " " + newPerson.age);
                    Console.ReadKey();
                }
                catch(Exception)
                {
                    Console.WriteLine("-----------------------------");

                    Console.WriteLine("Zehmet olmasa duzgun yasinizi daxil edin : ");

                    Console.WriteLine("-----------------------------");

                }
            }

        }

    }
    class Person
    {
        public string name;
        public string email;
        public byte age;
        public void deyerotur (string name, string email, byte age)
        {
            this.name = name;
            this.email = email;
            this.age = age;
        }

    }
}

   