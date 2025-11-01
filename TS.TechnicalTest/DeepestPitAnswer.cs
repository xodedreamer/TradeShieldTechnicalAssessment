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
             
            valleyIndex = peakIndex; // Q starts at the potential peak.

            // Step 2. Finding the Valley (Q): Travel downhill as far as possible.
            // Stoping when the descent stops (heights / points[Q] <= heights / points [Q+1]).
            while (valleyIndex < totalPoints - 1 && points[valleyIndex] > points[valleyIndex + 1])
            {
                valleyIndex++;
            }

            ridgeIndex=valleyIndex;

            //Step 3. Finding Ridge (R) : travel uphill as far as possible.
            // Stopping when the ascent stops (heights(points)[R] >= heights(points)[R+1]).
            while (ridgeIndex < totalPoints - 1 && points[ridgeIndex] < points[ridgeIndex + 1])
            {
                ridgeIndex++;
            }

            // step 4. Calculating Depth. A valid pit must be P < Q < R.
            if (peakIndex < valleyIndex && valleyIndex < ridgeIndex)
            {
                // Depth is the minimum distance from the Valley (Q) to the Peak (P) or Ridge (R).
                int depthP = points[valleyIndex] - points[valleyIndex];
                int depthR = points[ridgeIndex] - points[valleyIndex];

                int currentDepth = Math.Min(depthP, depthR);

                // Updating the running maximum depth.
                maxDepth = Math.Max(maxDepth, currentDepth);

                if (points[peakIndex] > 0)
                {
                    if (currentDepth > maxDepth)
                    {
                        maxDepth = currentDepth;
                    }
                }
                // Step 5. Ensuring no overlapping pits are missed.
                peakIndex = ridgeIndex;

            }
        }

        return maxDepth;
    }
}
