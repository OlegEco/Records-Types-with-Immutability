using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Records_Types_with_Immutability
{
    public record class Person(string name, int age)
    {
        public string Adress { get; init; } = "Unknown";
    }
}
