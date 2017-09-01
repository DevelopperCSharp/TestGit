using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymophime
{
    public class Student:Homme
    {
        public Student(string name, string last) : base(name, last) { }


        public override string Display()
        {
            return $" je suis un Student: {base.Display()}";
        }

      
    }



}
