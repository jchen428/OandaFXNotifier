using System.Collections.Generic;

namespace OandaRest.TradeLibrary.DataTypes.Communications
{
    public class CandlesResponse
    {
	    public string instrument;
	    public string granularity;
        public List<Candle> candles;
    }
}
