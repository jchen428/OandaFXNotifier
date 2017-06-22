using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using OandaRest.TradeLibrary.DataTypes;

namespace OandaRest.TradeLibrary
{
	public class EventsSession : StreamSession<Event>
	{
		public EventsSession(int accountId) : base(accountId)
		{
		}

		protected override async Task<WebResponse> getSession()
		{
			return await Rest.startEventsSession(new List<int> {_accountId});
		}
	}
}
