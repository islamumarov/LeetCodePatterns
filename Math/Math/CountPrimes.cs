namespace Math;

public class CountPrimes204
{
    
    public static int CountPrimes(int n)
    {
        if(n < 2) return 0;
        var primes = new List<int>();
        for (int i = 2; i <= n; i++)
        {
            var isPrime = true;
            var sqrt = System.Math.Sqrt(i);
            for (int j = 2; j <= sqrt; j+=i)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            
            if(isPrime) { primes.Add(i); }
        }
        
        return primes.Count;
    }
}