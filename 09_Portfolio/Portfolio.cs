using System.Collections.Generic;
using System;

namespace _09_Portfolio
{
    internal class Portfolio
    {
        private List<IAsset> stks = new List<IAsset>();
        private List<IAsset> sks;
        private List<IAsset> stocks
        {
            set
            {
                sks = value;
            }
            get
            {
                return sks;
            }
        }

        public Portfolio(List<IAsset> stocks)
        {
            this.stocks = stocks;
        }

        public Portfolio() { }

        public double GetTotalValue()
        {
            double result = 0;
            for (int i = 0; i < stocks.Count; i++)
            {
                result = result + stocks[i].GetValue();
            }
            return result;
        }

        public void AddAsset(IAsset stocks)
        {
            stks.Add(stocks);
            this.stocks = stks;
        }
    }
}