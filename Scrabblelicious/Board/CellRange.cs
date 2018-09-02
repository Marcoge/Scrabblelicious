
namespace Scrabblelicious {
    public class CellRange {
        private Pos _startingPos;
        private int _length;

        public CellRange(Pos start, int length) {
            _startingPos = start;
            _length = length;
        }

        public Pos Start { get { return _startingPos; } }
        public int Length { get { return _length; } }
    }
}
