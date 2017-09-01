using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymophime
{
    public class Instrutor:Homme

    {
        public Instrutor(string name, string last) : base(name, last) { }

        public override string Display()
        {
            return $" je suis un Instructor: {base.Display()}";
        }


    }
}
