using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studycmd
{
    public class ShushuAttribute : Attribute {
        public string Name { get; }
        public string Pwd { get; }

        public ShushuAttribute(string Name,string Pwd ){

        }
    }
}
