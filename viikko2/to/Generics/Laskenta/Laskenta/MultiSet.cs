using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laskenta
{
    class MultiSet<TKey, TItem>
    {
        private Dictionary<TKey, List<TItem>> _multiset = new();

        public void Add(TKey key, TItem item)
        {
            if (!_multiset.Keys.Contains(key))
            {
                _multiset[key] = new List<TItem>();
            }
            _multiset[key].Add(item);
        }

        public TItem this[TKey key]
        {
            get
            {
                return _multiset[key].First();
            }
        }

        public TItem this[TKey key, int index]
        {
            get
            {
                return _multiset[key][index];
            }
        }

        public void Remove(TKey key)
        {
             _multiset.Remove(key);
            
        }

        public void Remove(TKey key, int index)
        {
            _multiset[key].RemoveAt(index);
        }
        public int ItemCount(TKey key)
        {
            if (!_multiset.Keys.Contains(key))
                return -1;
            return _multiset[key].Count;
        }
    }
}
