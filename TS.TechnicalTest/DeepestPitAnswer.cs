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
        int peakIndex = 0; // P - Current Peak index
        int valleyIndex = 0; // Q - Current Valley index
        int ridgeIndex = 0; // R - Current Ridge index

        // Searching for the P-Q-R pattern.
        while (peakIndex < totalPoints - 2)
        {
            // Step 1. Find the Peak (P).
            // The descent (pit) must start after the peak.
            while (peakIndex < totalPoints - 1 && points[peakIndex] <= points[peakIndex + 1])
            {
                peakIndex++;
            }

        }
        
        return maxDepth;
    }
}
