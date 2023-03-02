namespace NPL.Practice.T101.Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Test case array
            int[] chartInput = { 1, 1, 2, 3 };

            //Convert value of array from integers to decimal, convert each value to number of percent in total 
            decimal[] chartOutput = DrawCircleChart(chartInput);
        }

        /// <summary>
        /// Convert value of array from integers to decimal, convert each value to number of percent in total 
        /// </summary>
        /// <param name="chartInput"></param>
        /// <returns></returns>
        private static decimal[] DrawCircleChart(int[] chartInput)
        {

            int sum = 0;
            decimal totalPercent = 0;
            decimal[] chartOutput = new decimal[chartInput.Length];

            //Loop to calculate the sum of all elements of input array
            for (int i = 0; i < chartInput.Length; i++)
            {
                sum += chartInput[i];
            }

            //Loop to the second last element of output array to calculate the percent of each element
            for (int i = 0; i < chartOutput.Length - 1; i++)
            {
                chartOutput[i] = Math.Round((decimal)chartInput[i] / sum * 100, 2);
                totalPercent += chartOutput[i];
            }

            //Calculate the percent of the last element
            chartOutput[chartOutput.Length - 1] = 100 - totalPercent;

            //Loop to print out elements of output array
            for (int i = 0; i < chartOutput.Length; i++)
            {
                Console.Write($"{chartOutput[i]}\t");
            }

            return chartOutput;
        }
    }
}