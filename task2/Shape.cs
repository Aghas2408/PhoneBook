using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2.Interfaces;

namespace task2
{
    public abstract class Shape : IMovable
    {
        public virtual void Draw(int i, int j)
        {
            
        }

        public virtual  void Move()
        {
         
        }
    }
}
