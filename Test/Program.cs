using System;
using System.Collections.Generic;
using System.Timers;
using OandaRest;
using OandaRest.TradeLibrary;
using OandaRest.TradeLibrary.DataTypes;

namespace Test
{
    class Program
    {
        private static RatesSession _session;
        private static Timer _timer;
        private static int _count;

        static void Main(string[] args)
        {
            Credentials creds = Credentials.getDefaultCredentials();
            Console.WriteLine(creds.accessToken);

            /*List<Account> accounts = Rest.getAccountListAsync().Result;
            foreach (var account in accounts)
            {
                Console.WriteLine(account.accountId);
            }*/

            List<Instrument> instruments = Rest.getInstrumentsAsync(creds.defaultAccountId).Result;

            /*List<Price> rates = Rest.getRatesAsync(instruments).Result;
            foreach (var rate in rates)
            {
                Console.WriteLine(rate.instrument + "\n" + rate.bid + "\n" + rate.ask + "\n");
            }*/

            _session = new RatesSession(creds.defaultAccountId, instruments);
            _session.dataReceived += sessionOnDataReceived;

            Console.WriteLine("Starting rate stream\n");
            setTimer();
            _timer.Start();
            _session.startSession();

            while (true)
            {
                if (_count >= 5)
                {
                    _session.stopSession();
                    Console.WriteLine("Stopping rate stream");
                    break;
                }
            }
        }

        private static void sessionOnDataReceived(RateStreamResponse data)
        {
            Price price = data.tick;

            Console.WriteLine(price.time);
            Console.WriteLine(price.instrument);
            Console.WriteLine("Bid: " + price.bid + "\t" + "Ask: " + price.ask);
            Console.WriteLine("Spread: " + Math.Abs(price.bid - price.ask) + "\n");
        }

        private static void setTimer()
        {
            // Create a timer with a 3 second interval.
            _timer = new Timer(1000);
            // Hook up the Elapsed event for the timer. 
            _timer.Elapsed += onTimedEvent;
            _timer.AutoReset = true;
            _timer.Enabled = false;
        }

        private static void onTimedEvent(Object source, ElapsedEventArgs e)
        {
            _count++;
        }
    }
}
