﻿using MVP_Checkers.Models;
using MVP_Checkers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Checkers.ViewModels
{
    public class PlayerTurnVM : BaseNotification
    {
        private GameLogic gameLogic;
        private PlayerTurn playerTurn;

        public PlayerTurnVM(GameLogic gameLogic, PlayerTurn playerTurn)
        {
            this.gameLogic = gameLogic;
            this.playerTurn = playerTurn;
        }

        public PlayerTurn PlayerIcon
        {
            get
            {
                return playerTurn;
            }
            set
            {
                playerTurn = value;
                NotifyPropertyChanged("PlayerIcon");
            }
        }
    }
}