namespace Graphs;

public class UnionFind
{
    private int[] _sizeOfDs;
    private int[] _dSet;
    private int _size;
    public int _numComponents;
    public UnionFind(int size)
    {
        if(size <= 0) throw new ArgumentException();
        this._dSet = new int[size];
        this._sizeOfDs = new int[size];

        for (int i = 0; i < size; i++)
        {
            this._dSet[i] = i;
            this._sizeOfDs[i] = 1;
        }
        _numComponents = size;
    }

    public int Find(int p)
    {
        var x = p;
        while (_dSet[x] != x)
        {
            x = _dSet[x];
        }
        
        // compress
        while (p != x)
        {
            int next = _dSet[p];
            _dSet[p] = x;
            p = next;
        }

        return x;
    }

    public bool Union(int x, int y)
    {
        x = Find(x);
        y = Find(y);
        if(x == y) return false;
        if (_sizeOfDs[x] >= _sizeOfDs[y])
        {
            _dSet[y] = x;
            _sizeOfDs[x] += _sizeOfDs[y];
        }
        else
        {
            _dSet[x] = y;
            _sizeOfDs[y] += _sizeOfDs[x];
        }
        _numComponents--;
        return true;
    }

    public bool IsConnected(int p, int q)
    {
        return Find(p) == Find(q);
    }
}

