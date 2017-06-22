using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace OandaRest
{
	public enum EServer
	{
		ACCOUNT,
		RATES,
		STREAMING_RATES,
		STREAMING_EVENTS,
		LABS
	}

	public enum EEnvironment
	{
		SANDBOX,
		PRACTICE,
		TRADE
	}

	public class Credentials
	{
		public bool hasServer(EServer server)
		{
			return Servers[environment].ContainsKey(server);
		}

		public string getServer(EServer server)
		{
			if (hasServer(server))
			{
				return Servers[environment][server];
			}
			return null;
		}

		private static readonly Dictionary<EEnvironment, Dictionary<EServer, string>> Servers = new Dictionary<EEnvironment, Dictionary<EServer, string>>
			{
				{EEnvironment.SANDBOX, new Dictionary<EServer, string>
					{
						{EServer.ACCOUNT, "http://api-sandbox.oanda.com/v1/"},
						{EServer.RATES, "http://api-sandbox.oanda.com/v1/"},
						{EServer.STREAMING_RATES, "http://stream-sandbox.oanda.com/v1/"},
						{EServer.STREAMING_EVENTS, "http://stream-sandbox.oanda.com/v1/"},
					}
				},
				{EEnvironment.PRACTICE, new Dictionary<EServer, string>
					{
						{EServer.STREAMING_RATES, "https://stream-fxpractice.oanda.com/v1/"},
						{EServer.STREAMING_EVENTS, "https://stream-fxpractice.oanda.com/v1/"},
						{EServer.ACCOUNT, "https://api-fxpractice.oanda.com/v1/"},
						{EServer.RATES, "https://api-fxpractice.oanda.com/v1/"},
						{EServer.LABS, "https://api-fxpractice.oanda.com/labs/v1/"},
					}
				},
				{EEnvironment.TRADE, new Dictionary<EServer, string>
					{
						{EServer.STREAMING_RATES, "https://stream-fxtrade.oanda.com/v1/"},
						{EServer.STREAMING_EVENTS, "https://stream-fxtrade.oanda.com/v1/"},
						{EServer.ACCOUNT, "https://api-fxtrade.oanda.com/v1/"},
						{EServer.RATES, "https://api-fxtrade.oanda.com/v1/"},
						{EServer.LABS, "https://api-fxtrade.oanda.com/labs/v1/"},
					}
				}
			};
		public string accessToken;

		private static Credentials _instance;
		public int defaultAccountId;
		public EEnvironment environment;

		public bool isSandbox
		{
			get { return environment == EEnvironment.SANDBOX; }
		}
		public string username;

		public static Credentials getDefaultCredentials()
		{
			if (_instance == null)
			{
				_instance = getPracticeCredentials();
				//_instance = getSandboxCredentials();
			}
			return _instance;
		}

		private static Credentials getSandboxCredentials()
		{
			return new Credentials()
				{
					environment = EEnvironment.SANDBOX,
				};
		}

		private static Credentials getPracticeCredentials()
		{
		    var assembly = typeof(Credentials).GetTypeInfo().Assembly;
		    Stream stream = assembly.GetManifestResourceStream("OandaRest.AccessToken.txt");
		    string text = "";
		    using (var reader = new StreamReader(stream))
		    {
		        text = reader.ReadToEnd();
		    }

            return new Credentials()
				{
					defaultAccountId = 9097430,
					environment = EEnvironment.PRACTICE,
					accessToken = text,
				};
			
		}

		private static Credentials getLiveCredentials()
		{
			// You'll need to add your own accessToken and account if desired
			return new Credentials()
				{
					//defaultAccountId = 00000,
					//accessToken = "fhaishihfweaiuu2u892h829h829h92ha8rfa89",
					environment = EEnvironment.TRADE
				};
		}
		
		public static void setCredentials(EEnvironment environment, string accessToken, int defaultAccount = 0)
		{
			_instance = new Credentials
				{
					environment = environment,
					accessToken = accessToken,
					defaultAccountId = defaultAccount
				};
		}
	}
}
