using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabblelicious
{
    class PosEqualityComparer:IEqualityComparer<Pos>
    {

        public bool Equals(Pos x, Pos y)
        {
            if (x.X ==y.X && x.Y ==y.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(Pos obj)
        {
            int temp = obj.X + obj.Y;
            return temp.GetHashCode();
        }
    }
}
