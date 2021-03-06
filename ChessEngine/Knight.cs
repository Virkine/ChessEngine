﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessEngine
{
    class Knight : Piece
    {
        public Knight(string initPos, bool initColor, Board initBoard) : base(initPos, initColor, initBoard) 
        {
            value = 3;
        }

        public override List<string> GetPossibleMove()
        {
            char[,] boardArr = board.GetBoardTab();
            
            possibleMoves = new List<string>();

            List<int> ijCoord = board.CoordToIj(pos);

            int len = (int) Math.Sqrt(boardArr.Length);

            for(int i=0; i<len; i++)
            {
                int vertDist = Math.Abs(i - ijCoord[0]);

                for(int j=0; j<len; j++)
                {
                    int horDist = Math.Abs(j - ijCoord[1]);

                    if ((vertDist == 1 && horDist == 2) || (vertDist == 2 && horDist == 1))
                    {
                        char elem = boardArr[i, j];

                        if (!( (elem >= 'a' && elem <= 'z' && color == false) || (elem >= 'A' && elem <= 'Z' && color == true) ))
                        {
                            possibleMoves.Add(board.IjToCoord(i, j));
                        }

                    }
                }
            }

            possibleMoves = base.GetPossibleMove();

            return possibleMoves;
        }
    }
}
