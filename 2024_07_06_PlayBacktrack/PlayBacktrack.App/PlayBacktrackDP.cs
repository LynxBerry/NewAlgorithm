using System.Linq;

namespace PlayBacktrack.App
{
    public class PlayBacktrackDP
    {
        private readonly Dictionary<(int, int),IList<string>?> _memoCache = [];
        public void Test(int[] inputArray, int targetSum)
        {
            _memoCache.Clear();
            Backtrack(inputArray, 0, targetSum);
        }

        private void Backtrack(int[] inputArray, int currentPos, int restOfTargetSum)        
        {
            if (_memoCache.ContainsKey((currentPos, restOfTargetSum)))
            {
                return;
            }

            // Base case
            if (currentPos == inputArray.Length) // It means reading the end of inputArray
            {
                if (restOfTargetSum == 0)
                    _memoCache.Add((currentPos,restOfTargetSum),[""]);
                else
                    _memoCache.Add((currentPos,restOfTargetSum), null);
                return;
            }

            // * + inputArray[currentPos]
            Backtrack(inputArray, currentPos + 1, restOfTargetSum - inputArray[currentPos]);

            // * - inputArray[currentPos]
            Backtrack(inputArray, currentPos + 1, restOfTargetSum + inputArray[currentPos]);

            var subLevelAnswersPlus = _memoCache[(currentPos + 1, restOfTargetSum - inputArray[currentPos])];
            var subLevelAnswersMinus = _memoCache[(currentPos + 1, restOfTargetSum + inputArray[currentPos])];
            if (subLevelAnswersPlus == null && subLevelAnswersMinus == null)
            {
                _memoCache[(currentPos, restOfTargetSum)] = null;
            }
            else
            {
                var thisLevelAnswers = _memoCache[(currentPos,restOfTargetSum)] = [];

                if (subLevelAnswersPlus != null)
                {
                    foreach (var subLevelAnswer in subLevelAnswersPlus)
                    {
                        thisLevelAnswers.Add($"+{inputArray[currentPos]}{subLevelAnswer}");
                    }

                }

                if (subLevelAnswersMinus != null)
                {
                    foreach (var subLevelAnswer in subLevelAnswersMinus)
                    {
                        thisLevelAnswers.Add($"+{inputArray[currentPos]}{subLevelAnswer}");
                    }

                }



            }


        }

        private void PrintAnswers(int currentPos, int restOfTargetSum)
        {
            if (_memoCache.ContainsKey((currentPos, restOfTargetSum)) && _memoCache[(currentPos,restOfTargetSum)] != null)
            {
                var answers = _memoCache[(currentPos,restOfTargetSum)];
                foreach (var answer in answers!)
                {
                    Console.WriteLine(answer);
                }
            }
        }
    }
}