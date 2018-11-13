using System;
using System.Collections.Generic;
using System.Linq;
using CurrencyTrader.Contracts;

namespace CurrencyTrader.AdoNet
{

    public class AsyncNetTradeStorage : ITradeStorage
    {

        private readonly ILogger logger;
        private ITradeStorage SynchTradeStorage;


        public AsyncNetTradeStorage(ILogger logger)
        {
            this.logger = logger;
            SynchTradeStorage = new AdonetTradeStorage(logger);
        }


        public void Persist(IEnumerable<TradeRecord> trades)
        {
            Logger.LogInfo("Connecting to Database");
            SynchTradeStorage.Persist(trades);
        }



    }

}