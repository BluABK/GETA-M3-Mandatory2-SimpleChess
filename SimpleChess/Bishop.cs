using System;

namespace SimpleChess
{
    internal class Bishop : Piece
    {
        private const string symbol = "LPR";
        public Bishop() 
            : base(symbol)
        {
        }

        public override bool Move(string fromPosition, string toPosition)
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];

            return Math.Abs(diffRow) == Math.Abs(diffCol);
        }
    }
}