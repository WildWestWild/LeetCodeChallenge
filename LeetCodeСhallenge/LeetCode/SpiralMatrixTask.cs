namespace LeetCodeСhallenge.LeetCode;

public static class SpiralMatrixTask
{
    private static readonly int LOWER_BOUND = -100;
    
    private static int _counterAllElements;

    private static int _countDimensions;
    public static IList<int> SpiralOrder(int[][] matrix)
    {
        IList<int> resultArray = new List<int>();

        _counterAllElements = default;

        _countDimensions = default;

        int allCountElement = default;

        foreach (var array in matrix)
        {
            allCountElement += array.Length;
            _countDimensions++;
        }

        int resultArrayCount = default;
        var arrIndex = -1;
        var demIndex = 0;
        
        do
        {
            RightMoving(resultArray, matrix, ref arrIndex, ref demIndex);
            
            DownMoving(resultArray, matrix, ref arrIndex, ref demIndex);
            
            LeftMoving(resultArray, matrix, ref arrIndex, ref demIndex);
            
            UpMoving(resultArray, matrix, ref arrIndex, ref demIndex);
            
        } while (_counterAllElements != allCountElement);

        return resultArray;
    }

    private static void RightMoving(IList<int> list, int[][] matrix, ref int arrIndex, ref int demIndex)
    {
        arrIndex++;
        var arrayDimension = matrix[demIndex];
        for (int i = arrIndex; i < arrayDimension.Length; i++)
        {
            if (DoStepIntoMatrix(list, ref arrayDimension[i])) break;
            arrIndex++;
        }

        arrIndex--;
    }
    
    private static void DownMoving(IList<int> list, int[][] matrix, ref int arrIndex, ref int demIndex)
    {
        demIndex++;
        for (int i = demIndex; i < _countDimensions; i++)
        {
            if (DoStepIntoMatrix(list, ref matrix[demIndex][arrIndex])) break;
            demIndex++;
        }

        demIndex--;
    }
    
    private static void LeftMoving(IList<int> list, int[][] matrix, ref int arrIndex, ref int demIndex)
    {
        arrIndex--;
        var arrayDimension = matrix[demIndex];
        for (int i = arrIndex; i >= 0; i--)
        {
            if (DoStepIntoMatrix(list, ref arrayDimension[i])) break;
            arrIndex--;
        }

        arrIndex++;
    }
    
    private static void UpMoving(IList<int> list, int[][] matrix, ref int arrIndex, ref int demIndex)
    {
        demIndex--;
        for (int i = demIndex; i >= 0; i--)
        {
            if (DoStepIntoMatrix(list, ref matrix[demIndex][arrIndex])) break;
            demIndex--;
        }

        demIndex++;
    }
    
    private static bool DoStepIntoMatrix(IList<int> list, ref int value)
    {
        if (value > LOWER_BOUND)
        {
            list.Add(value);
            value = LOWER_BOUND - 1;
            _counterAllElements++;
        }
        else return true;

        return false;
    }
}