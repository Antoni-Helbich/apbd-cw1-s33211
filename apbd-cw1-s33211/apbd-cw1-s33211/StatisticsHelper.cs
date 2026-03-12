namespace apbd_cw1_s33211;

public class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        int sum = 0;
        for(int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }
        return sum / values.Length;
    }

    public static int Max(int[] values)
    {
        int max = values[0];
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] > max)
            {
                max = values[i];
            }
        }

        return max;
    }

    public static int CalculateMin(int[] values)
    {
        return 0;
    }
}