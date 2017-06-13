using System.Collections.Generic;

namespace OandaFXNotifier.TradeLibrary.DataTypes.Communications
{
    public class TradesResponse
    {
        public List<TradeData> trades;
        public string nextPage;
    }
}
