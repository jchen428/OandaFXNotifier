namespace OandaRest.TradeLibrary.DataTypes.Communications.Requests
{
	abstract class AccountRequest : Request
	{
		private readonly int _accountId;

		AccountRequest(int accountId)
		{
			_accountId = accountId;
		}

		public override string endPoint
		{
			get { return "/accounts/" + _accountId + getAccountEndPoint(); }
		}

		protected abstract string getAccountEndPoint();
		
		public override EServer getServer()
		{
			return EServer.ACCOUNT;
		}


	}
}
