using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml;

namespace EighthTest
{
    public static class XMLtoList
    {
        #region Private
        private static string urlString = "http://www.nbg.ge/rss.php";
        #endregion
        #region Method
        public static List<Currencies> ConvertToList()
        {
            string XML = "";
            HtmlDocument document = new HtmlDocument();
            using (XmlTextReader reader = new XmlTextReader(urlString))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.CDATA)
                    {
                        XML += reader.Value;
                    }
                }
            }

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(XML);

            var elementList = new List<string[]>();
            foreach (var row in doc.DocumentNode.SelectNodes("//tr[td]"))
            {
                elementList.Add(row.SelectNodes("td").Select(td => td.InnerText).ToArray());
            }

            var currencyList = new List<Currencies>();

            foreach (var item in elementList)
            {
                currencyList.Add(new Currencies
                {
                    Name = item[0],
                    Amount = Convert.ToInt32(new string(item[1].TakeWhile(char.IsDigit).ToArray())),
                    ExchangePrice = Convert.ToDouble(item[2]),
                    Exchange = Convert.ToDouble(item[4])
                });
            }

            return currencyList;
        }
        #endregion
    }
}
