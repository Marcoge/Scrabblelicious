using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabblelicious
{
    public sealed class AppContext : INotifyPropertyChanged
    {
        private static string _availableLetters;
        private static ObservableCollection<Cell> _cells;
        private static TreeNode _dictionary;
        
        public AppContext()
        {
            _cells = new ObservableCollection<Cell>();
            _dictionary = new TreeNode(' ', false);
            fillDictionary();

            var temp = createCells();
            foreach (Cell c in temp)
            {
                _cells.Add(c);
            }
        }

        public void FindWord()
        {
            var bla = new WordTester(_availableLetters, _dictionary);
            CheckHorizontal();
        }


        public String AvailableLetters
        {
            get { return _availableLetters; }
            set
            {
                if (value != _availableLetters)
                {
                    _availableLetters = value;
                    OnPropertyChanged("AvailableLetters");
                }
            }
        }
        public ObservableCollection<Cell> Cells
        {
            get { return _cells; }
            set
            {
                if (value != _cells)
                {
                    _cells = value;
                    OnPropertyChanged("Cells");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

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
        private static void fillDictionary()
        {
            String stemp;
            StreamReader input = new StreamReader("c:\\temp\\decrypted_deutsch.dic");

            while ((stemp = input.ReadLine()) != null)
            {
                String temp1 = parseS(stemp).ToLower();
                _dictionary.addWord(temp1, _dictionary);
            }

            input.Close();
        }
        private static String parseS(String s)
        {
            string st = s;
            int index = s.IndexOf("=");
            if (index > 0)
            {
                st = st.Substring(0, index);
            }
            return st;
        }
        private static void CheckHorizontal()
        {
            List<CellRange> temp = SplitIntoCellRanges("h");

        }

        private static List<CellRange> SplitIntoCellRanges(string p)
        {
            List<CellRange> temp = new List<CellRange>();
            if (p.Equals("h"))
            {
                for (int h = 0; h < 15; h++)
                {
                    for (int i = 0; i < 14; i++)
                    {
                        int LettersInCellRange = 0;
                        if (CheckIfNewLetterInCellRange(new Pos(h,i)))
                        {
                            LettersInCellRange++;
                        }

                        for (int j = 1; j < (_availableLetters.Length + LettersInCellRange) - i; j++)
                        {
                            if (CheckIfNewLetterInCellRange(new Pos(h, j)))
                            {
                                LettersInCellRange++;
                            }
                            temp.Add(new CellRange((new Pos(h,i)),j));
                        }
                    }
                }
               
            }
            return temp;
        }

        private static bool CheckIfNewLetterInCellRange(Pos p)
        {
            return true;
        }

        private void OnPropertyChanged(String propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
