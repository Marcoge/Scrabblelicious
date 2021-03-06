﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabblelicious
{
    public class Cell: INotifyPropertyChanged
    {
        Char _letter;
        Pos _position;
        bool _hasLetter;
        bool _verticalBlock;
        bool _horizontalBlock;

        public Cell() { }
        
        public Cell(int x, int y)
        {
            _position = new Pos(x, y);
        }

        public Char Letter
        {
            get
            {
                return _letter;
            }

            set
            {
                if (value != _letter)
                {
                    _letter = value;
                    _hasLetter = true;
                    OnPropertyChanged("Letter");
                }
            }
        }
        public Pos Position { get { return _position; } }
        public int X { get { return _position.X; } }
        public int Y { get { return _position.Y; } }
        public bool VerticalBlock { get { return _verticalBlock; } set { value = _verticalBlock; } }
        public bool HorizontalBlock { get { return _horizontalBlock; } set { value = _horizontalBlock; } }
        public bool HasLetter { get { return _hasLetter; } }

        public event PropertyChangedEventHandler PropertyChanged;

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
