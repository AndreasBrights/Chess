using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Chess
{
    internal class Pawn : ChessPieces
    {

        public bool IsWhite { get; set; }
        public Pawn(bool isWhite)
        {
           //  string name = "👶"; test for face in button,content 
            IsWhite = isWhite;

        }

        //public override bool IsValidMove (int currentRow, int currentColumn, int newRow, int newColumn)
        //{
        //    // To do! Check if the move made is ok within the rules of the piece.
        //}
    }
}
