using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonapp
{
    public class Appletree : Tree
    {
        public Appletree(double a, string b) : base(a,b) { }

        public override void Grow()
        {
            Age += 1;
        }
    }
}
