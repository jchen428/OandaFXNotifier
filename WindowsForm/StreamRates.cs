using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using RestSharp;
using OandaRest;
using OandaRest.TradeLibrary;
using OandaRest.TradeLibrary.DataTypes;

namespace WindowsForm
{
    public static class StreamRates
    {
        private static readonly RestClient _client = new RestClient("https://api.catapush.com/1/messages");
        private static readonly List<Instrument> _targetInstrument = new List<Instrument>();
        private static readonly RatesSession _session;
        private static Price _marketPrice;
        private static double _userPrice;
        private static string _mode;

        static StreamRates()
        {
            Credentials creds = Credentials.getDefaultCredentials();
            _session = new RatesSession(creds.defaultAccountId, _targetInstrument);
            _session.dataReceived += sessionOnDataReceived;
        }

        public static void setInstrument(Instrument instrument)
        {
            _targetInstrument.Add(instrument);
        }

        public static void setMode(string mode)
        {
            _mode = mode;
        }

        public static void startStream(double price, int index)
        {
            _userPrice = price;

            Console.WriteLine("Streaming rates for " + _targetInstrument[0].displayName);
            
            _session.startSession();
        }

        public static void stopStream()
        {
            _session.stopSession();
            _targetInstrument.Clear();
        }

        private static void sessionOnDataReceived(RateStreamResponse data)
        {
            _marketPrice = data.tick;

            double askPrice = _marketPrice.ask;
            double bidPrice = _marketPrice.bid;

            Console.WriteLine(_marketPrice.time);
            Console.WriteLine(_marketPrice.instrument);
            Console.WriteLine("Ask: " + askPrice + "\tBid: " + bidPrice);
            Console.WriteLine("Spread: " + Math.Abs(bidPrice - askPrice) + "\n");

            switch (_mode)
            {
                case "ASK":     // buy
                    if (askPrice <= _userPrice)
                    {
                        sendNotification();
                    }
                    break;
                case "BID":     // sell
                    if (bidPrice >= _userPrice)
                    {
                        sendNotification();
                    }
                    break;
            }
        }

        public static void sendNotification()
        {
            string accessToken;
            Assembly assembly = typeof(StreamRates).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("WindowsForm.CatapushAccessToken.txt");
            using (StreamReader reader = new StreamReader(stream))
            {
                accessToken = reader.ReadLine();
            }

            string fullText = "full tex";
            string notificationText = "notification text";

            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader("authorization", "Bearer " + accessToken);
            request.AddHeader("content-type", "application/json");
            request.AddHeader("accept", "application/json");
            request.AddParameter("application/json", "{ " +
                                                     "\"mobileAppId\":318, " +
                                                     "\"text\":\"" + fullText + "\", " +
                                                     "\"recipients\":[ { \"identifier\":\"18583532077\" } ], " +
                                                     "\"notificationText\":\"" + notificationText + "\" " +
                                                     "}", 
                                ParameterType.RequestBody);
            IRestResponse response = _client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}
