using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabblelicious
{
    public class CellRange
    {
        private Pos _startingPos;
        private int _length;

        public CellRange(Pos start, int length)
        {
            start = _startingPos;
            length = _length;
        }

        public Pos Start { get { return _startingPos; } set { } }
        public int Length { get { return _length; } set { } }
    }
}
