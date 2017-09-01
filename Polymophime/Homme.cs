using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymophime
{
    public class Homme
    {

        protected string FirstName  { get; }
        protected string LastName { get; }

        public Homme( string name,string last)
        {
            FirstName = name;
            LastName = last;
        }
        public virtual string Display() => $"  FirtName:{FirstName}  LastName:{LastName}";

        public sealed override string ToString()
        {
            return $"  FirtName:{FirstName}  LastName:{LastName}";
        }

    
       
        protected  bool Equals(Homme other) => other!=null && string.Equals(FirstName, other.FirstName) && string.Equals(LastName, other.LastName);
        public override int GetHashCode() => FirstName.GetHashCode() ^ LastName.GetHashCode();
    }
}
