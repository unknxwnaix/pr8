using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vipief.Model
{
    public class Colour
    {
        public Colour(string name, string hexademical)
        {
            Name = name;
            Hexademical = hexademical;
        }
        public Colour() { }

        public string Name { get; set; }
        public string Hexademical { get; set; }
    }
}
