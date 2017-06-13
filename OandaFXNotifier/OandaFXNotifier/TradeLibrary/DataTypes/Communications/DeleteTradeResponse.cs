namespace OandaFXNotifier.TradeLibrary.DataTypes.Communications
{
	public class DeleteTradeResponse : Response
	{
		public long id { get; set; }
		public double price { get; set; }
		public string instrument { get; set; }
		public double profit { get; set; }
		public string side { get; set; }
		public string time { get; set; }
	}
}
