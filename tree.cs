using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonapp
{
    public abstract class Tree
    {
        private double age;
        private string type;
        
        public string Type 
        {
            get 
            {
                return type;
            }
            private set
            {
                type = value;
            }
        }


        public double Age 
        {
            get 
            {
                return age;
            }

            protected set 
            {
                if (value < 0)
                { 
                    age = 0; 
                } 
                else age = value;
            }
        }

        public Tree(double a, string b)
        {
            type = b;
            age = a;
        }

        public abstract void Grow();
      

    }
}
