using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace HomeTask1
{
    internal class BuyersCollection
    {
        NameValueCollection collection = new NameValueCollection();

        public void Add(string buyer, string product)
        {
            collection.Add(buyer, product);
        }

        public IEnumerable<string> GetProductsByBuyer(string buyer)
        {
            return collection.GetValues(buyer);
        }

        public IEnumerable<string> GetBuyersByProduct(string product)
        {
            foreach (var key in collection.AllKeys)
            {
                if (collection.GetValues(key).Contains(product) == true)
                    yield return key;
            }
        }
    }
}
