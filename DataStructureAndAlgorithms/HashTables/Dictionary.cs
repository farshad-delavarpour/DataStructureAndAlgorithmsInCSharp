using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms.HashTables
{
    public class Dictionary<TKey, TValue>
    {
        private readonly List<LinkedList<KeyValuePair>> _items;
        
        public Dictionary()
        {
            _items = new List<LinkedList<KeyValuePair>>();
        }
        
        private class KeyValuePair
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
        }

        public void Add(TKey key, TValue value)
        {
            int index = key.GetHashCode();
            KeyValuePair keyValuePair = new ()
            {
                Key = key,
                Value = value
            };
            LinkedList<KeyValuePair> item = _items[index];
        }
    }
}
