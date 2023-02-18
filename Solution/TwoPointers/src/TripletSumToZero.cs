namespace src;

public class TripletSumToZero
{
    public static IList<IList<int>> FindTriplets(int[] arr)
    {
        Array.Sort(arr);
        var triplets = new List<IList<int>>();
        for (int i = 0; i < arr.Length; i++)
        {
            if(i > 0 && arr[i] == arr[i-1])
                continue;
            SearchTriplets(arr, -arr[i], i + 1, triplets);
        }

        return triplets;
    }

    private static void SearchTriplets(int[] arr, int targetSum, int left, List<IList<int>> triplets)
    {
        var right = arr.Length - 1;
        while (left < right)
        {
            var currentSum = arr[left] + arr[right];
            if (currentSum == targetSum)
            {
                triplets.Add(new List<int> { -targetSum, arr[left], arr[right] });
                left++;
                right--;
                while (left < right && arr[left] == arr[left - 1])
                    left++;
                while (left < right && arr[right] == arr[right + 1])
                    right--;
            }
            else if (targetSum > currentSum)
                left++;
            else
                right--;
        }
    }
}