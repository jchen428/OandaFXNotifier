using OandaRest.TradeLibrary.DataTypes.Communications;

namespace OandaRest.TradeLibrary.DataTypes
{
    public class Transaction : Response
    {
        public long id { get; set; }
        public int accountId { get; set; }
		public string time { get; set; }
		public string type { get; set; }
        public string instrument { get; set; }
		public string side { get; set; }
		public int units { get; set; }
        public double price { get; set; }
		public double lowerBound { get; set; }
		public double upperBound { get; set; }
		public double takeProfitPrice { get; set; }
		public double stopLossPrice { get; set; }
		public double trailingStopLossDistance { get; set; }
		public double pl { get; set; }
		public double interest { get; set; }
		public double accountBalance { get; set; }
		public long tradeId { get; set; }
	    public long orderId { get; set; }
		public TradeData tradeOpened { get; set; }
		public TradeData tradeReduced { get; set; }
		public string reason { get; set; }
		public string expiry { get; set; }

        /// <summary>
        /// Gets a basic title for the type of transaction
        /// </summary>
        /// <returns></returns>
        public string getTitle()
        {
            switch ( type )
            {
                case "CloseOrder":
                    return "Order Closed";
                case "SellLimit":
                    return "Sell Limit Order Created";
                case "BuyLimit":
                    return "Buy Limit Order Created";
            }
            return type;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string getReadableString()
        {
            string readable = units + " " + instrument + " at " + price;
            if ( pl != 0 )
            {
                readable += "\nP/L: " + pl;
            }
            return readable;
        }
    }
}
