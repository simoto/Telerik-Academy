namespace Refactoring.cs
{
    class SecondExercise
    {
        public void PrintMaxAndAvarage(double[] arr, int count)
        {
            double biggestElement = arr[0];
            double sum = arr[0];
			
            for (int i = 1; i < count; i++)
            {
                if (arr[i] > biggestElement)
                {
                    biggestElement = arr[i];
                }
				
                sum += arr[i];
            }

            // PrintMax(biggestElement);     
            //PrintAvg(sum/count);
        }
    }
}
