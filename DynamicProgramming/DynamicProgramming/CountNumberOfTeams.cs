using System;

namespace DynamicProgramming;

public class CountNumberOfTeams
{
    public int NumTeams(int[] rating)
    {
        // This method counts the number of teams that can be formed
        int n = rating.Length;
        int count = 0;

        // Iterate through each soldier as a potential team leader
        // and count how many soldiers are less and greater than the leader
        for (int i = 0; i < n; i++)
        {            int leftLess = 0,
                leftGreater = 0;
            int rightLess = 0,
                rightGreater = 0;

            for (int j = 0; j < n; j++)
            {
                if (rating[j] < rating[i])
                {
                    if (j < i)
                        leftLess++;
                    else
                        rightLess++;
                }
                else if (rating[j] > rating[i])
                {
                    if (j < i)
                        leftGreater++;
                    else
                        rightGreater++;
                }
            }

            count += leftLess * rightGreater + leftGreater * rightLess;
        }

        return count;
    }
}
