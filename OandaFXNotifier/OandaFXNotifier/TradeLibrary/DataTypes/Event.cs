namespace OandaRest.TradeLibrary.DataTypes
{
	public class Event : IHeartbeat
	{
		public Heartbeat heartbeat { get; set; }
		public Transaction transaction { get; set; }
		public bool isHeartbeat()
		{
			return (heartbeat != null);
		}
	}
}
