namespace OandaRest.TradeLibrary.DataTypes
{
	public class RateStreamResponse : IHeartbeat
	{
		public Heartbeat heartbeat;
		public Price tick;
		public bool isHeartbeat()
		{
			return (heartbeat != null);
		}
	}
}
