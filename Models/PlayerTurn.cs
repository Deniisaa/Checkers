﻿using MVP_Checkers.Services;
using MVP_Checkers.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Checkers.Models
{
    public class PlayerTurn : BaseNotification
    {
        private PieceColor color;
        private string image;

        public PlayerTurn(PieceColor color)
        {
            this.color = color;
            loadImages();
        }

        public void loadImages()
        {
            if (color == PieceColor.Red)
            {
                image = Utility.RedCircle;
                return;
            }
            image = Utility.WhiteCircle;
        }

        public PieceColor PlayerColor
        {
            get { return color; }
            set
            {
                color = value;
                NotifyPropertyChanged("PlayerColor");
            }
        }

        public string TurnImage
        {
            get
            {
                return image;
            }
            set
            {
                image = value;
                NotifyPropertyChanged("TurnImage");
            }
        }
    }
}
