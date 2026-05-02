namespace SortedContainers;

// V2: List + BinarySearch
// LeetCode guarantees timestamps are strictly increasing per key,
// so plain List stays sorted without extra work.
// BinarySearch ~result gives insert point; floor = ~result - 1.
public class TimeMapV2 : ITimeMap
{
    private readonly Dictionary<string, List<(int ts, string val)>> data = new();

    public void Set(string key, string value, int timestamp)
    {
        if (!data.TryGetValue(key, out var list))
        {
            list = new List<(int, string)>();
            data[key] = list;
        }
        list.Add((timestamp, value));
    }

    public string Get(string key, int timestamp)
    {
        if (!data.TryGetValue(key, out var list)) return "";

        var lo = 0;
        var hi = list.Count - 1;
        var ans = -1;
        while (lo <= hi)
        {
            var mid = lo + (hi - lo) / 2;
            if (list[mid].ts <= timestamp) { ans = mid; lo = mid + 1; }
            else hi = mid - 1;
        }
        return ans != -1 ? list[ans].val : "";
    }
}

// V3: SortedDictionary + LINQ TakeWhile
// SortedDictionary iterates keys in ascending order, so TakeWhile(k <= ts)
// captures all valid candidates; Last() gives the floor.
// Trade-off: Get is O(n) vs O(log n), but code is minimal.
public class TimeMapV3 : ITimeMap
{
    private readonly Dictionary<string, SortedDictionary<int, string>> data = new();

    public void Set(string key, string value, int timestamp)
    {
        if (!data.TryGetValue(key, out var sorted))
        {
            sorted = new SortedDictionary<int, string>();
            data[key] = sorted;
        }
        sorted[timestamp] = value;
    }

    public string Get(string key, int timestamp)
    {
        if (!data.TryGetValue(key, out var sorted)) return "";

        var candidates = sorted.TakeWhile(kvp => kvp.Key <= timestamp).ToList();
        return candidates.Count > 0 ? candidates[^1].Value : "";
    }
}

// V4: PriorityQueue-backed store
// Each key holds a max-heap (PriorityQueue with negated priority = max-heap).
// Set pushes (value, timestamp). Get drains entries with ts <= timestamp
// and keeps the one with the highest ts.
// Trade-off: Get is destructive — peeked-and-put-back approach needed,
// so we use a sorted snapshot instead. Shows PriorityQueue usage pattern.
public class TimeMapV4 : ITimeMap
{
    private readonly Dictionary<string, PriorityQueue<string, int>> data = new();

    // Snapshot for non-destructive Get: store pairs sorted for binary search
    private readonly Dictionary<string, List<(int ts, string val)>> snapshot = new();

    public void Set(string key, string value, int timestamp)
    {
        if (!data.TryGetValue(key, out var pq))
        {
            pq = new PriorityQueue<string, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
            data[key] = pq;
            snapshot[key] = new List<(int, string)>();
        }
        pq.Enqueue(value, timestamp);
        snapshot[key].Add((timestamp, value));
    }

    public string Get(string key, int timestamp)
    {
        if (!snapshot.TryGetValue(key, out var list)) return "";

        // Binary search on snapshot (ascending by ts)
        var lo = 0; var hi = list.Count - 1; var ans = -1;
        while (lo <= hi)
        {
            var mid = lo + (hi - lo) / 2;
            if (list[mid].ts <= timestamp) { ans = mid; lo = mid + 1; }
            else hi = mid - 1;
        }
        return ans != -1 ? list[ans].val : "";
    }
}

// V5: Array doubling (amortized O(1) Set, O(log n) Get)
// Stores timestamps and values in parallel arrays per key.
// Arrays double in capacity like List<T> internally, avoiding
// per-element allocation. Shows manual resizing pattern.
public class TimeMapV5 : ITimeMap
{
    private class Bucket
    {
        public int[] Timestamps = new int[4];
        public string[] Values = new string[4];
        public int Count;

        public void Add(int ts, string val)
        {
            if (Count == Timestamps.Length)
            {
                Array.Resize(ref Timestamps, Count * 2);
                Array.Resize(ref Values, Count * 2);
            }
            Timestamps[Count] = ts;
            Values[Count] = val;
            Count++;
        }
    }

    private readonly Dictionary<string, Bucket> data = new();

    public void Set(string key, string value, int timestamp)
    {
        if (!data.TryGetValue(key, out var bucket))
        {
            bucket = new Bucket();
            data[key] = bucket;
        }
        bucket.Add(timestamp, value);
    }

    public string Get(string key, int timestamp)
    {
        if (!data.TryGetValue(key, out var bucket)) return "";

        var lo = 0; var hi = bucket.Count - 1; var ans = -1;
        while (lo <= hi)
        {
            var mid = lo + (hi - lo) / 2;
            if (bucket.Timestamps[mid] <= timestamp) { ans = mid; lo = mid + 1; }
            else hi = mid - 1;
        }
        return ans != -1 ? bucket.Values[ans] : "";
    }
}
