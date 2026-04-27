namespace SortedContainers;

public class TimeMap
{
    private readonly Dictionary<string, SortedList<int, string>> data;

    public TimeMap()
    {
        data = new Dictionary<string, SortedList<int, string>>();
    }

    public void Set(string key, string value, int timestamp)
    {
        var value1 = data.GetValueOrDefault(key, new SortedList<int, string>());
        value1.Add(timestamp, value);
    }

    public string Get(string key, int timestamp)
    {
        if (!data.TryGetValue(key, out var keys)) return "";

        var left = 0;
        var right = keys.Keys.Count - 1;
        var ans = -1;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            if (keys.Keys[mid] == timestamp) return keys[mid];
            if (keys.Keys[mid] <= timestamp)
            {
                ans = mid;
                left = mid + 1;
            }

            else
            {
                right = mid - 1;
            }
        }

        if (ans != -1) return keys.Keys[ans] < timestamp ? keys[ans] : "";

        return "";
    }
}