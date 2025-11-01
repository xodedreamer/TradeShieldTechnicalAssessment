namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        //Getting the length of points.
        int totalPoints = points.Length;

        // Ensuring at least 3 points for a pit (P, Q, R).
        if (totalPoints < 3)
        {
            return -1; 
        }

        int maxDepth = -1; // Using -1 as the initial 'no pit found' signal.
        int P = 0; // Current Peak index

        return maxDepth;
    }
}
