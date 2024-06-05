using MVP_Checkers.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MVP_Checkers.Models
{
    public class GameSquare : INotifyPropertyChanged
    {
        private int row;
        private int column;
        private SquareColor shade;
        private string texture;
        private GamePiece piece;
        private string legalSquareSymbol;

        public event PropertyChangedEventHandler PropertyChanged;

        public GameSquare(int row, int column, SquareColor shade, GamePiece piece)
        {
            this.row = row;
            this.column = column;
            this.shade = shade;
            if(shade == SquareColor.Dark)
            {
                texture = Utility.purpleSquare;
            }
            else
            {
                texture = Utility.pinkSquare;
            }
            this.piece = piece;
        }

        public int Row
        {
            get
            {
                return row;
            }
        }

        public int Column
        {
            get
            {
                return column;
            }
        }

        public SquareColor Shade
        {
            get
            {
                return shade;
            }
        }

        public string Texture
        {
            get
            {
                return texture;
            }
            set
            {
                texture = value;
                NotifyPropertyChanged("Texture");
            }
        }

        public GamePiece Piece
        {
            get
            {
                return piece;
            }
            set
            {
                piece = value;
                NotifyPropertyChanged("Piece");
            }
        }

        public string LegalSquareSymbol
        {
            get
            {
                return legalSquareSymbol;
            }
            set
            {
                legalSquareSymbol = value;
                NotifyPropertyChanged("LegalSquareSymbol");
            }
        }

        protected void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }   
        }
    }
}
