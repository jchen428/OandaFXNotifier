using System.Collections.Generic;

namespace OandaFXNotifier.TradeLibrary.DataTypes.Communications
{
    public class CandlesResponse
    {
	    public string instrument;
	    public string granularity;
        public List<Candle> candles;
    }
}
