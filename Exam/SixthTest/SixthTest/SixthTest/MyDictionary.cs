using System;
using System.Collections.Generic;
using System.Text;

namespace SixthTest
{
    class MyDictionary<T>
    {
        #region Private
        private Dictionary<T, int> dictionary = new Dictionary<T, int>();
        #endregion
        #region Methods
        public void Insert(T value)
        {
            if (dictionary.ContainsKey(value))
            {
                dictionary[value] += 1;
            }
            else
            {
                dictionary.Add(value, 1);
            }
        }

        public void Delete(T value)
        {
            if (dictionary.ContainsKey(value))
            {
                dictionary[value] -= 1;
                if (dictionary[value] == 0)
                {
                    dictionary.Remove(value);
                }
            }
        }

        public int Size()
        {
            return Sum(dictionary.Values);
        }

        private int Sum(Dictionary<T, int>.ValueCollection values)
        {
            int sum = 0;

            foreach (var item in values)
            {
                sum += item;
            }

            return sum;
        }
        #endregion
    }
}
