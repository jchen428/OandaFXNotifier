using System.Collections.Generic;

namespace OandaFXNotifier.TradeLibrary.DataTypes.Communications
{
    public class PricesResponse
    {
        public long time;
        public List<Price> prices;
    }
}
