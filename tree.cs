using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lessonapp
{
    public class Tree
    {
        private int age;
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


        public int Age 
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

        public Tree(int a, string b)
        {
            type = b;
            age = a;
        }

        public void Grow() 
        {
            age += 2;

        }

    }
}
