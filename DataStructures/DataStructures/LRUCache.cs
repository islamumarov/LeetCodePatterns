namespace DataStructures;

public class LRUCache {

    private readonly int capacity;
    private readonly Dictionary<int, LinkedListNode<KeyValuePair<int, int>>> _cacheMap;
    private readonly LinkedList<KeyValuePair<int,int>> _cache;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        _cacheMap = new Dictionary<int, LinkedListNode<KeyValuePair<int, int>>>(capacity);
        _cache = new LinkedList<KeyValuePair<int, int>>();
    }
    
    public int Get(int key) {
        if (_cacheMap.TryGetValue(key, out var node))
        {
            _cache.Remove(node);
            _cache.AddFirst(node);
            return node.Value.Value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if (_cacheMap.TryGetValue(key, out var node))
        {
            node.Value = new KeyValuePair<int, int>(key, value);
            _cache.Remove(node);
            _cache.AddFirst(node);
        }
        else
        {
            if (_cacheMap.Count >= capacity)
            {
                var lastNode = _cache.Last;
                _cacheMap.Remove(lastNode.Value.Key);
                _cache.RemoveLast();
            }

            var newNode = new LinkedListNode<KeyValuePair<int, int>>(new KeyValuePair<int, int>(key, value));
            _cacheMap.Add(key, newNode);
            _cache.AddFirst(newNode);
        }
    }
}
