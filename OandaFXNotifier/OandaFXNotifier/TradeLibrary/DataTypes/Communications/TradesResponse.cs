using System.Collections.Generic;

namespace OandaRest.TradeLibrary.DataTypes.Communications
{
    public class TradesResponse
    {
        public List<TradeData> trades;
        public string nextPage;
    }
}
