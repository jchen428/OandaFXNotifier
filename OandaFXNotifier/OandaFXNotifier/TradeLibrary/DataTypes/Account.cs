namespace OandaFXNotifier.TradeLibrary.DataTypes
{
    public class Account
    {
		public bool hasAccountId;
		private int _accountId;
		public int accountId
		{
			get { return _accountId; }
			set
			{
				_accountId = value;
				hasAccountId = true;
			}
		}

		public bool hasAccountName;
		private string _accountName;
		public string accountName
		{
			get { return _accountName; }
			set
			{
				_accountName = value;
				hasAccountName = true;
			}
		}

		public bool hasAccountCurrency;
		private string _accountCurrency;
		public string accountCurrency
		{
			get { return _accountCurrency; }
			set
			{
				_accountCurrency = value;
				hasAccountCurrency = true;
			}
		}

		public bool hasMarginRate;
		private string _marginRate;
		public string marginRate
		{
			get { return _marginRate; }
			set
			{
				_marginRate = value;
				hasMarginRate = true;
			}
		}

		[IsOptional]
		public bool hasBalance;
		private string _balance;
		public string balance
		{
			get { return _balance; }
			set
			{
				_balance = value;
				hasBalance = true;
			}
		}

		[IsOptional]
		public bool hasUnrealizedPl;
		private string _unrealizedPl;
		public string unrealizedPl
		{
			get { return _unrealizedPl; }
			set
			{
				_unrealizedPl = value;
				hasUnrealizedPl = true;
			}
		}

		[IsOptional]
		public bool hasRealizedPl;
		private string _realizedPl;
		public string realizedPl
		{
			get { return _realizedPl; }
			set
			{
				_realizedPl = value;
				hasRealizedPl = true;
			}
		}

		[IsOptional]
		public bool hasMarginUsed;
		private string _marginUsed;
		public string marginUsed
		{
			get { return _marginUsed; }
			set
			{
				_marginUsed = value;
				hasMarginUsed = true;
			}
		}

		[IsOptional]
		public bool hasMarginAvail;
		private string _marginAvail;
		public string marginAvail
		{
			get { return _marginAvail; }
			set
			{
				_marginAvail = value;
				hasMarginAvail = true;
			}
		}
		
		[IsOptional]
		public bool hasOpenTrades;
		private string _openTrades;
		public string openTrades
		{
			get { return _openTrades; }
			set
			{
				_openTrades = value;
				hasOpenTrades = true;
			}
		}
		
		[IsOptional]
		public bool hasOpenOrders;
		private string _openOrders;
		public string openOrders
		{
			get { return _openOrders; }
			set
			{
				_openOrders = value;
				hasOpenOrders = true;
			}
		}
    }
}
