namespace PlayBacktrack2.App
{
    public class PlayBacktrack
    {
        private readonly IList<string> _answers = [];
        // inputArray: 
        // targetSum:
        public void Test(int[] inputArray, int targetSum)
        {

            _answers.Clear();
            Backtrack(inputArray, 0, targetSum, "");

            PrintAnswers();

            
        }

        private void Backtrack(int[] inputArray, int currentPos, int restOfTargetSum, string prefixAnswer)
        {
            // * Base case
            if (currentPos == inputArray.Length) // It means reading the end of inputArray
            {
                if (restOfTargetSum == 0)
                    _answers.Add(prefixAnswer);
                return;
            }

            // * + inputArray[currentPos]
            Backtrack(inputArray, currentPos + 1, restOfTargetSum - inputArray[currentPos], prefixAnswer + "+" + inputArray[currentPos]);

            // * - inputArray[currentPos]
            Backtrack(inputArray, currentPos + 1, restOfTargetSum + inputArray[currentPos], prefixAnswer + "-" + inputArray[currentPos]);
        }

        private void PrintAnswers()
        {
            foreach (var answer in _answers)
            {
                Console.WriteLine(answer);
            }
        
        }
    }

}