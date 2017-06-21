using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OandaFXNotifier;
using OandaFXNotifier.TradeLibrary;
using OandaFXNotifier.TradeLibrary.DataTypes;

namespace WindowsForm
{
    public static class StreamRates
    {
        private static Credentials _creds;
        private static List<Instrument> _instruments;
        private static RatesSession _session;

        static StreamRates()
        {
            _creds = Credentials.getDefaultCredentials();
            _instruments = Rest.getInstrumentsAsync(_creds.defaultAccountId).Result;
            _session = new RatesSession(_creds.defaultAccountId, _instruments);
            _session.dataReceived += sessionOnDataReceived;
        }

        public static void startStream()
        {
            _session.startSession();
        }

        public static void stopStream()
        {
            _session.stopSession();
        }

        private static void sessionOnDataReceived(RateStreamResponse data)
        {
            // TODO: this function and also add instrument selection to ui
            Price price = data.tick;

            Console.WriteLine(price.time);
            Console.WriteLine(price.instrument);
            Console.WriteLine("Bid: " + price.bid + "\t" + "Ask: " + price.ask);
            Console.WriteLine("Spread: " + Math.Abs(price.bid - price.ask) + "\n");
        }
    }
}
