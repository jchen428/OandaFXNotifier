using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using OandaFXNotifier.TradeLibrary.DataTypes;

namespace OandaFXNotifier.TradeLibrary
{
	public abstract class StreamSession<T> where T: IHeartbeat
	{
		protected readonly int _accountId;
		private WebResponse _response;
		private bool _shutdown;

		public delegate void DataHandler(T data);

		public event DataHandler dataReceived;

		public void onDataReceived(T data)
		{
			DataHandler handler = dataReceived;
			if (handler != null) handler(data);
		}

		protected StreamSession(int accountId)
		{
			_accountId = accountId;
		}

		protected abstract Task<WebResponse> getSession();
		
		public async void startSession()
		{
			_shutdown = false;
			_response = await getSession();
			

			Task.Run(() =>
				{
					DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
					StreamReader reader = new StreamReader(_response.GetResponseStream());
					while (!_shutdown)
					{
						MemoryStream memStream = new MemoryStream();
						
						string line = reader.ReadLine();
						memStream.Write(Encoding.UTF8.GetBytes(line), 0, Encoding.UTF8.GetByteCount(line));
						memStream.Position = 0;

						var data = (T)serializer.ReadObject(memStream);
						
						// Don't send heartbeats
						if (!data.isHeartbeat())
						{
							onDataReceived(data);
						}
					}
				}
				);

		}

		public void stopSession()
		{
			_shutdown = true;
		}
	}
}
