using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using OandaFXNotifier.TradeLibrary.DataTypes;

namespace OandaFXNotifier.TradeLibrary
{
	public class RatesSession : StreamSession<RateStreamResponse>
	{
		private readonly List<Instrument> _instruments;

		public RatesSession(int accountId, List<Instrument> instruments) : base(accountId)
		{
			_instruments = instruments;
		}

		protected override async Task<WebResponse> getSession()
		{
			return await Rest.startRatesSession(_instruments, _accountId);
		}
	}
}
