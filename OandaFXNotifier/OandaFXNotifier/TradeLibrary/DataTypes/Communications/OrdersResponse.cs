using System.Collections.Generic;

namespace OandaFXNotifier.TradeLibrary.DataTypes.Communications
{
    public class OrdersResponse
    {
        public List<Order> orders;
        public string nextPage;
    }
}
