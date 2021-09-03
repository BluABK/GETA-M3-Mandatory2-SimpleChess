namespace SimpleChess
{
    internal class Rook : Piece
    {
        private const string symbol = "TRN";
        public Rook()
            : base(symbol)
        {
        }

        public override bool Move(string fromPosition, string toPosition)
        {
            return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
        }
    }
}