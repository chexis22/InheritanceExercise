using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public bool ColdBlooded { get; set; }
        public int Teeth { get; set; }
        public bool Scales { get; set; }
        public int Tail { get; set; }

        public int Eyes = 2;
    }

    
}
