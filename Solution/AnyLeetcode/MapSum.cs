namespace AnyLeetcode;

public class MapSum
{
    private Dictionary<string,int > key_val;
    public MapSum()
    {
        this.key_val = new Dictionary<string, int>();
    }
    
    public void Insert(string key, int val)
    {
        if (this.key_val.ContainsKey(key))
            key_val[key] = val;
        else key_val.Add(key,val);
    }
    
    public int Sum(string prefix)
    {
        int sum = 0;
        foreach (var i in key_val)
        {
            if (i.Key.StartsWith(prefix)) sum += i.Value;
        }

        return sum;
    }
}