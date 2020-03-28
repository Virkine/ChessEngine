﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    class AI : Player
    {
        public AI(bool initColor, Board initBoard) : base(initColor, initBoard) { }

        public override void GetNextMove()
        {
            Dictionary<string,List<string>> allPossibleMoves = board.GetAllMove(color);
            List<string> keyList = new List<string>(allPossibleMoves.Keys);

            Random rand = new Random();
            
            if(allPossibleMoves.Count > 0)
            {
                int nbPiece = rand.Next(allPossibleMoves.Count);
                string coordPiece = keyList[nbPiece];

                int nbMove = rand.Next(allPossibleMoves[coordPiece].Count);

                board.SetPieceCoord(coordPiece, allPossibleMoves[coordPiece][nbMove]);
            }
            
        }
    }
}