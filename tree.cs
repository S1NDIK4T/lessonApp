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
        #region TypeProperty 
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
        #endregion
        #region AgeProperty
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
        #endregion
        public Tree(double a, string b)
        {
            Type = b;
            Age = a;
        }

        public abstract void Grow();
      

    }
}
