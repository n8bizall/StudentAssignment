using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentAssignment
{
    class Program
    {
       public static void Main(string[] args)
        {
            IntroDbContext db = new IntroDbContext();

            




            //NameOfStudent[] nameOfStudents = db.Name.ToArray();
            //   foreach(NameOfStudent name in nameOfStudents)
            //{
            //    string message = $"Id= {name.Id}, Name={name.Name}";
            //    Console.WriteLine(message);
            //}

            NameOfStudent[] withHonors = db.Name.ToArray();
            foreach (NameOfStudent name in withHonors)
            {
                string message = $"Id= {name.Id}, Name={name.Name}, Honors= {name.Names.Name}";
                Console.WriteLine(withHonors);
            }
            Console.ReadKey();


            
        }
    }
}
