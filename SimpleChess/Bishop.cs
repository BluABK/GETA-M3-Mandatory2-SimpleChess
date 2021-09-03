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
            throw new System.NotImplementedException();
        }
    }
}