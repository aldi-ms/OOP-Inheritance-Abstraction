using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HumanStudentWorker
{
    public class StudentWorkerMain
    {
        static void Main()
        {
            List<Student> students = new List<Student> 
            {
                new Student("Teodosii", "Spasov", "f0341"),
                new Student("Mariq", "Stoimenova", "f0304"),
                new Student("Alexandar", "Spasov", "fb0341"),
                new Student("Petur", "Petrov", "hh021a"),
                new Student("Ivan", "Petrovov", "fz0210"),
                new Student("Dragan", "Draganov", "f0342"),
                new Student("Qvor", "Mihailov", "c021ba"),
                new Student("Angel", "Stoqnov", "cf9341"),
                new Student("Dimitur", "Dimitrov", "f03415"),
                new Student("Boiko", "Borisov", "a09901")
            };

            Console.WriteLine("Student list:");
            PrintList<Student>(students);

            students.Sort(
                (x, y) => string.Compare(x.FacultyNumber, y.FacultyNumber)
                );

            Console.WriteLine("\nStudent list sorted by faculty number:");
            PrintList<Student>(students);

            List<Worker> workers = new List<Worker>
            {
                new Worker("Teodosii", "Spasov", 100, 5),
                new Worker("Mariq", "Stoimenova", 91.9, 4),
                new Worker("Alexandar", "Spasov", 121.11, 4.5),
                new Worker("Petur", "Petrov", 135, 7),
                new Worker("Ivan", "Petrovov", 120.9, 4.7),
                new Worker("Dragan", "Draganov", 99.9, 3.9),
                new Worker("Qvor", "Mihailov", 170, 8.7),
                new Worker("Angel", "Stoqnov", 90, 3.3),
                new Worker("Dimitur", "Dimitrov", 150.5, 8),
                new Worker("Boiko", "Borisov", 50, 1)
            };

            Console.WriteLine("\nWorker list:");
            PrintList<Worker>(workers);

            workers.Sort(
                (x, y) => (y.MoneyPerHour().CompareTo(x.MoneyPerHour()))
                );

            Console.WriteLine("\nWorker list sorted by money-per-Hour:");
            PrintList<Worker>(workers);

            Console.ReadKey();
        }

        private static void PrintList<T>(List<T> list)
        {
            foreach (T el in list)
            {
                Console.WriteLine(el.ToString());
            }
        }
    }
}
