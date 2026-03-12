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
}