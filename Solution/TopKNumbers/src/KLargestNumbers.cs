namespace src;

public class KLargestNumbers
{
    public static int findKLargestNumbers(int[] nums, int k)
    {
        int n = nums.Length;
        for(int i = n/2-1; i >= 0; i--)
        {
            Heapify(nums,n,i);
        }
        for(int i = n-1; i >= 0; i--)
        {
            (nums[0], nums[i]) = (nums[i], nums[0]);
            Heapify(nums, i,0);
        }
        
        return nums[^k];
    }
    private static void Heapify(int[] nums,int n,int i){
        int largest = i;
        int l = i * 2 + 1;
        int r = i * 2 + 2;
        
        if(l < n && nums[l] > nums[largest])
        {
            largest = l;
        }
        if(r < n && nums[r] > nums[largest])
        {
            largest = r;
        }
        if(largest != i){
            (nums[i], nums[largest]) = (nums[largest], nums[i]);
            Heapify(nums,n,largest);
        }
    }
}