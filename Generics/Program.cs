List<string> citys = new List<string>();
citys.Add("Kayseri");
Console.WriteLine(citys.Count);
MyList<string> myList = new MyList<string>();

myList.Add("Sivas");
Console.WriteLine(myList.Count);
class MyList<T>//Generic class
{
    T[] _tempArray;
    T[] _array;
 
    public MyList()
    {
        _array = new T[0];
    }
    public void Add(T item)
    {
        _tempArray = _array;
        _array =new T[_array.Length+1];
        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];

        }
        _array[_array.Length-1] = item;
    }
    private int _count;

    public int Count
    {
        get { return _array.Length; }

    }

}
