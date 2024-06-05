using MVP_Checkers.Commands;
using MVP_Checkers.Models;
using MVP_Checkers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVP_Checkers.ViewModels
{
    public class GameSquareVM : BaseNotification
    {
        private GameLogic gameLogic;
        private GameSquare genericSquare;
        private ICommand clickPieceCommand;
        private ICommand movePieceCommand;

        public GameSquareVM(GameSquare square, GameLogic gameLogic)
        {
            genericSquare = square;
            this.gameLogic = gameLogic;
        }

        public GameSquare GenericSquare
        {
            get
            {
                return genericSquare;
            }
            set
            {
                genericSquare = value;
                NotifyPropertyChanged("GenericSquare");
            }
        }

        public ICommand ClickPieceCommand
        {
            get
            {
                if (clickPieceCommand == null)
                {
                    clickPieceCommand = new GenericCommand<GameSquare>(gameLogic.ClickingPiece);
                }
                return clickPieceCommand;
            }
        }

        public ICommand MovePieceCommand
        {
            get
            {
                if (movePieceCommand == null)
                {
                    movePieceCommand = new GenericCommand<GameSquare>(gameLogic.MovePiece);
                }
                return movePieceCommand;
            }
        }
    }
}
