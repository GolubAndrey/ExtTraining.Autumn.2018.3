using System;
using System.Collections.Generic;

namespace No2
{
    public class Stock : IObservable
    {
        private delegate void StocksHandler(StockInfo info);

        private event StocksHandler OnNotify;

        private StockInfo stocksInfo;

        public Stock()
        {
            stocksInfo = new StockInfo();
        }

        public void Register(IObserver observer)=> OnNotify += observer.Update;

        public void Unregister(IObserver observer) => OnNotify-=observer.Update;

        public void Notify()
        {
            OnNotify(stocksInfo);
        }

        public void Market()
        {
            Random rnd = new Random();
            stocksInfo.USD = rnd.Next(20, 40);
            stocksInfo.Euro = rnd.Next(30, 50);
            Notify();
        }
    }
}
