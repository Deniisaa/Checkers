using MVP_Checkers.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Checkers.Models
{
    public class GamePiece : INotifyPropertyChanged
    {
        private PieceColor color;
        private PieceType type;
        private string texture;
        private GameSquare square;

        public event PropertyChangedEventHandler PropertyChanged;

        public GamePiece(PieceColor color)
        {
            this.color = color;
            type = PieceType.Regular;
            if(color == PieceColor.Red)
            {
                texture = Utility.RedCircle;
            }
            else
            {
                texture = Utility.WhiteCircle;
            }
        }

        public GamePiece(PieceColor color,PieceType type)
        {
            this.color = color;
            this.type = type;
            if (color == PieceColor.Red)
            {
                texture = Utility.RedCircle;
            }
            else
            {
                texture = Utility.WhiteCircle;
            }
            if (type == PieceType.King && color == PieceColor.Red)
            {
                texture = Utility.redKing;
            }
            if (type == PieceType.King && color == PieceColor.White)
            {
                texture = Utility.whiteKing;
            }
        }

        public PieceColor Color
        {
            get
            {
                return color;
            }
        }

        public PieceType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                NotifyPropertyChanged("Type");
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

        public GameSquare Square
        {
            get
            {
                return square;
            }
            set
            {
                square = value;
                NotifyPropertyChanged("Square");
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