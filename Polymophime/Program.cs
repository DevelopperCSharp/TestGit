using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Polymophime
{
    class Program
    {
        static void Main(string[] args)
        {

            IMusicien bat=new Batteur();

           string s= bat.Jouer();

            //Homme studentHomme = new Student("layal", "fakherddine");
            //Student student=new Student("layal","fakherddine");
            //Homme instructor = new Instrutor("layal", "fakherddine");

            Console.WriteLine($"resultat: {s}");
            //Console.WriteLine($"resultat: {student.Display()}");
            //Console.WriteLine($"resultat: {instructor.Display()}");
            //Console.WriteLine($"{instructor.GetType().Name}");
            //MethodInfo[] methods = instructor.GetType().GetMethods();
            //foreach (var m in methods)
            //{
            //     Console.WriteLine($"{m.Name}");
            //}

            var lit= new List<string>(){"layal","had","tttt","rrrr"};
            IDictionary<int, string> dictionary = new Dictionary<int, string>();

            foreach (var v in lit)
            {
              
                dictionary[dictionary.Keys.Count + 1] = v;
            }

            foreach (var d in dictionary)
            {
                Console.WriteLine($"{d.Key},{d.Value}");
            }


            Console.ReadKey();
        }
    }
}
