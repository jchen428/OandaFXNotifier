namespace OandaRest.TradeLibrary.DataTypes
{
    public class Price
    {
        public enum State
        {
            DEFAULT,
            INCREASING,
            DECREASING
        };

        public string instrument { get; set; }
        public string time;
        public double bid { get; set; }
        public double ask { get; set; }
	    public string status;
        public State state = State.DEFAULT;

	    public void update( Price update )
        {
            if ( this.bid > update.bid )
            {
                state = State.DECREASING;
            }
            else if ( this.bid < update.bid )
            {
                state = State.INCREASING;
            }
            else
            {
                state = State.DEFAULT;
            }

            this.bid = update.bid;
            this.ask = update.ask;
            this.time = update.time;
        }
    }
}
