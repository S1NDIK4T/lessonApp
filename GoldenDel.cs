using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonapp
{
    public class GoldenDel : GrushaTree
    {
        public override void Grow()
        {
            Age += 4;
        }
        public GoldenDel(int a, string b) : base(a, b) { }
    }
}
