using System.Collections.Generic;

namespace OandaRest.TradeLibrary.DataTypes.Communications
{
    public class OrdersResponse
    {
        public List<Order> orders;
        public string nextPage;
    }
}
