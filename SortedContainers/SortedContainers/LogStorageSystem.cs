namespace SortedContainers;

//Design Log Storage System
///
/// <summary>
/// You are given several logs that each log contains a unique id and timestamp. Timestamp is a
/// string that has the following format: "Year:Month:Day:Hour:Minute:Second", for example,
/// "2017:01:01:23:59:59". All domains are zero
/// padded decimal numbers.
/// /// Implement the LogSystem class:
/// /// LogSystem() Initializes the LogSystem object.
/// /// void put(int id, string timestamp) Stores the given log (id, timestamp)
/// /// /// IList<int> retrieve(string start, string end, string granularity) Returns the id of
/// /// logs whose timestamps are within the range from start to end inclusive, where start and end
/// /// both have the same format as timestamp. However, granularity means that you should only
/// /// consider the prefix of the timestamp string up to the granularity level. For example,
/// /// if granularity is "Day", it means that you need to consider the prefix of
/// /// the timestamp string up to "Day", i.e., "Year:Month:Day".
/// /// The result should be returned in ascending order of id.
/// /// </summary>
public class LogStorageSystem
{
    private SortedDictionary<int, string> logs = new SortedDictionary<int, string>();

    public void Put(int id, string timestamp)
    {
        logs[id] = timestamp;
    }

    public IList<int> Retrieve(string start, string end, string granularity)
    {
        string NormalizeTimestamp(string timestamp, bool isEnd)
        {
            return granularity switch
            {
                "Year"
                    => timestamp.Substring(0, 4) + (isEnd ? ":12:31:23:59:59" : ":01:01:00:00:00"),
                "Month" => timestamp.Substring(0, 7) + (isEnd ? ":31:23:59:59" : ":01:00:00:00"),
                "Day" => timestamp.Substring(0, 10) + (isEnd ? ":23:59:59" : ":00:00:00"),
                "Hour" => timestamp.Substring(0, 13) + (isEnd ? ":00:00" : ":00:00"),
                "Minute" => timestamp.Substring(0, 16) + (isEnd ? ":00" : ":00"),
                "Second" => timestamp,
                _ => throw new ArgumentException("Invalid granularity"),
            };
        }

        string startKey = NormalizeTimestamp(start, false);
        string endKey = NormalizeTimestamp(end, true);

        List<int> result = new List<int>();

        foreach (var log in logs)
        {
            if (string.Compare(log.Value, startKey) >= 0 && string.Compare(log.Value, endKey) <= 0)
            {
                result.Add(log.Key);
            }
        }

        return result;
    }
}
