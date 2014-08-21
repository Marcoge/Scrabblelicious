using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabblelicious
{
    public sealed class AppContext
    {
        private string _availableletters;
        
        public AppContext()
        {
            _availableletters = "labernicht";
            Cells = new ObservableCollection<Cell>();
            var temp = createCells();
            foreach (Cell c in temp)
            {
                Cells.Add(c);
            }

        }

        public String AvailableLetters { get { return _availableletters; } set { } }
        public ObservableCollection<Cell> Cells { get; set; }

        private IEnumerable<Cell> createCells()
        {
            List<Cell> temp = new List<Cell>();
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
			    {
			        temp.Add(new Cell(i, j));
			    }
            }
            return temp;
        }

    }
}
