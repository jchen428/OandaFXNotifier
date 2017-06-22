using System.Collections.Generic;

namespace OandaRest.TradeLibrary.DataTypes.Communications
{
	public class DeletePositionResponse : Response
	{
		public List<long> ids { get; set; }
		public string instrument { get; set; }
		public int totalUnits { get; set; }
		public double price { get; set; }
	}
}
