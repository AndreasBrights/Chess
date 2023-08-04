using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    internal class Knight
    {
        public bool IsWhite { get; set; }
        public Knight(bool isWhite)
        {
            IsWhite = isWhite;
        }

        //public override bool IsValidMove(int currentRow, int currentColumn, int newRow, int newColumn)
        //{
        //    // To do! Check if the move made is ok within the rules of the piece.
        //}
    }
}

