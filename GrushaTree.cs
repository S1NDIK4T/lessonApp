using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonapp
{
    public class GrushaTree : Tree
    {
        public GrushaTree(double a, string b) : base(a, b) { }

        public override void Grow()
        {
            Age += 2;
        }
    }
}
