using HwIndexators.EasyTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HwIndexators.EasyTasks;



class MyCollection
{
    Dictionary<string, object> _items = new Dictionary<string, object>();
    Dictionary<int, int> _intItems = new Dictionary<int, int>();

    
    public object this[string key]
    {
        get
        {
            if (_items.ContainsKey(key))
            {
                return _items[key];
            }
            else
            {
                Console.WriteLine("Collection doesn't have this key");
                return null;
            }
        }
        set
        {
            _items[key] = value;
        }
    }

    
    public int this[int index]
    {
        get
        {
            if (_intItems.ContainsKey(index))
            {
                return _intItems[index];
            }
            else
            {
                Console.WriteLine("The collection doesn't contain this");
                return 0;
            }
        }
        set
        {
            _intItems[index] = value;
        }
    }
    public void Add(string key, object value)
    {
        if (_items.ContainsKey(key))
        {
            Console.WriteLine("The collection already contains this");
        }
        _items.Add(key, value);
    }
}

