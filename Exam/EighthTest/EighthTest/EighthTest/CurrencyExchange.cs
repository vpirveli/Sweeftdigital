using System;
using System.Collections.Generic;

namespace EighthTest
{
    static class CurrencyExchange
    {
        #region Private
        private static List<Currencies> currencyList = XMLtoList.ConvertToList();
        #endregion
        #region Methods
        public static List<string> GetCurrencyNames()
        {
            var currencyListNames = new List<string>();
            foreach (var item in currencyList)
            {
                currencyListNames.Add(item.Name);
            }
            return currencyListNames;
        }

        public static string Exchange(string firCurrency, string secCurrency)
        {
            double firstCurrency = 0, secondCurrency = 1;

            foreach (var item in currencyList)
                if (firCurrency == item.Name)
                    firstCurrency = item.ExchangePrice / item.Amount;

            foreach (var item in currencyList)
                if (secCurrency == item.Name)
                    secondCurrency = item.ExchangePrice / item.Amount;

            return String.Format("{0:0.000000}", firstCurrency / secondCurrency);
        }
        #endregion
    }
}
