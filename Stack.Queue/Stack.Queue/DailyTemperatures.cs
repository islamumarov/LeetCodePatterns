namespace Stack.Queue;

public class DailyTemperatures
{
    public static int[] DailyTemperaturesSol(int[] temperatures) {
        var n =  temperatures.Length;
        var res = new int[n];
        var monotonic = new Stack<int>();

        for (int i = n-1; i > -1; i--)
        {
            while (monotonic.Count > 0 && temperatures[i] >= temperatures[monotonic.Peek()])
            {
                monotonic.Pop();
            }
            res[i] = monotonic.Count > 0 ? monotonic.Peek() - i : 0;
            monotonic.Push(i);
        }
        return res;
    }
}