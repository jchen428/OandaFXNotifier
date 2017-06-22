using System.Collections.Generic;

namespace OandaRest.TradeLibrary.DataTypes.Communications
{
    public class TransactionsResponse : Response
    {
        public List<Transaction> transactions;
        public string nextPage;
    }
}
