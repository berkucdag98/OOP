using System;
using System.Collections.Generic;
using System.Text;

namespace Koleksiyonlar
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] tkey;
        TValue[] tvalue;
        public MyDictionary()
        {
            tkey = new TKey[0];
            tvalue = new TValue[0];
        }

        public void Add(TKey tkeyitem,TValue tvalueitem)
        {
            TKey[] tempKeyArray = tkey;
            TValue[] tempValueArray = tvalue;

            tkey = new TKey[tkey.Length + 1];
            tvalue = new TValue[tvalue.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                tkey[i] = tempKeyArray[i];
            }

            for (int i = 0; i < tempValueArray.Length; i++)
            {
                tvalue[i] = tempValueArray[i];
            }

            tkey[tkey.Length - 1] = tkeyitem;
            tvalue[tvalue.Length - 1] = tvalueitem;
        }

        public int Length
        {
            get { return tkey.Length; }
        }

        public TKey[] TkeyItems
        {
            get { return tkey; }
        }

        public TValue[] TValueItems
        {
            get { return tvalue; }
        }
    }
}
