using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonapp
{
    class Antonovka : Appletree
    {

        public Antonovka(double a, string b) : base(a, b) { }

        public new void Grow()
        {
            Age *= 1.5;
        }
    }
}

