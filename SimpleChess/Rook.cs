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
            throw new System.NotImplementedException();
        }
    }
}