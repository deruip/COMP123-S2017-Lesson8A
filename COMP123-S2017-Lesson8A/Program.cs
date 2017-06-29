using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2017_Lesson8A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("---------");
            Console.WriteLine();

            Person person = new Person("Aron", 20);
            person.Talks();

            Student student = new Student("John", 19, "123456789");
            student.Talks();
            student.Studies();
                
        }
    }
}
