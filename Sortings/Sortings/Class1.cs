namespace Sortings;

public class SortingAlgos
{
    public static void Insertions(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            var j = i;
            while (j > 0 && arr[j] < arr[j - 1])
            {
                (arr[j - 1], arr[j]) = (arr[j], arr[j - 1]);
                j--;
            }
        }
    }
}
