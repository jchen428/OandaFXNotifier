using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OandaFXNotifier;
using OandaFXNotifier.TradeLibrary.DataTypes;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Credentials creds = Credentials.getDefaultCredentials();
            Console.WriteLine(creds.accessToken);
        }
    }
}
