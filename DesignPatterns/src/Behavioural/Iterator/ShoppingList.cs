using System;

namespace DesignPatterns.src.Behavioural.Iterator;

public class ShoppingList
{
    private List<string> _list = new List<string>();

    public void Push(string item)
    {
        _list.Add(item);
    }

    public void Pop()
    {
        _list.Remove(_list.Last());
    }

    public IIterator<string> CreateIterator()
    {
        return new ListIterator(this);

    }

    public class ListIterator : IIterator<string>
    {
        private ShoppingList _shoppingList;
        private int _index = 0;

        public ListIterator(ShoppingList shoppingList)
        {
            _shoppingList = shoppingList;
        }
        public string Current()
        {
            return _shoppingList._list[_index];   
        }

        public bool HasNext()
        {
            return _index < _shoppingList._list.Count();
        }

        public void Next()
        {
            _index++;
        }
    }
}
