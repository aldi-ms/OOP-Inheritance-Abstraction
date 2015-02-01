using System;
using System.Linq;

namespace _03.Animals
{
    public class AnimalsMain
    {
        public static void Main()
        {
            Animal[] animals = new Animal[]
            {
                new Dog("Sharo", 4, Gender.Male),
                new Dog("Belcho", 8, Gender.Male),
                new Dog("Sara", 5, Gender.Female),
                new Tomcat("Topcho", 1),
                new Dog("Richie", 2, Gender.Male),
                new Cat("Maca", 4, Gender.Female),
                new Kitten("Puhi", 0),
                new Frog("Jabcho", 0, Gender.Male),
                new Frog("Jabka", 1, Gender.Female),
                new Frog("Jaboka Kermit", 3, Gender.Male),
                new Cat("Tom", 3, Gender.Male)
            };

            var avgAgeBySpecies =
                from a in animals
                group a by (a is Cat) ? typeof(Cat) : a.GetType() into gr
                select new
                {
                    Species = gr.Key.Name,
                    AverageAge = gr.Average(x => x.Age)
                };

            foreach (var a in avgAgeBySpecies)
            {
                Console.WriteLine("{0} average age is {1}", a.Species, a.AverageAge);
            }

            Console.ReadKey();
        }
    }
}
