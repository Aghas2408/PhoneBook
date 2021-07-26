using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    interface IShape
    {
        string KeyWord { get; set; }
        void Draw(int i, int j);
    }
}
