/// <description>
/// Given an m x n matrix, return all elements of the matrix in spiral order.
/// 
/// Example 1:
/// Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
/// Output: [1,2,3,6,9,8,7,4,5]
/// 
/// Example 2:
/// Input: matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
/// Output: [1,2,3,4,8,12,11,10,9,5,6,7]
/// 
/// Constraints:
/// m == matrix.length
/// n == matrix[i].length
/// 1 <= m, n <= 10
/// -100 <= matrix[i][j] <= 100
/// </description>
public class SpiralMatrixSolution
{
    private const int MARK_AS_DONE = 101;
    public IList<int> SpiralOrder(int[][] matrix)
    {
        int row = 0, column = 0;
        int iteration = matrix.Length * matrix[0].Length;
        IList<int> result = new List<int>();
        var direction = new bool[]
        {
            true,  //Right
            false, //Down
            false, //Left
            false  //Up
        };
        while (iteration > 0)
        {
            if (direction[0])
            {
                if (column < matrix[0].Length && matrix[row][column] != MARK_AS_DONE)
                {
                    SetList(result, matrix, ref row, ref column, 0, 1, ref iteration);
                }
                else
                {
                    SetDirection(ref row, ref column, 1, -1, direction, 0);
                }
            }
            else if (direction[1])
            {
                if (row < matrix.Length && matrix[row][column] != MARK_AS_DONE)
                {
                    SetList(result, matrix, ref row, ref column, 1, 0, ref iteration);
                }
                else
                {
                    SetDirection(ref row, ref column, -1, -1, direction, 1);
                }
            }

            else if (direction[2])
            {
                if (column >= 0 && matrix[row][column] != MARK_AS_DONE)
                {
                    SetList(result, matrix, ref row, ref column, 0, -1, ref iteration);
                }
                else
                {
                    SetDirection(ref row, ref column, -1, 1, direction, 2);
                }
            }
            else
            {
                if (row >= 0 && matrix[row][column] != MARK_AS_DONE)
                {
                    SetList(result, matrix, ref row, ref column, -1, 0, ref iteration);
                }
                else
                {
                    SetDirection(ref row, ref column, 1, 1, direction, 3);
                }
            }
        }
        return result;
    }
    private void SetList(IList<int> res, int[][] matrix, ref int row, ref int column, int incrementRow, int incrementColumn, ref int iteration)
    {
        res.Add(matrix[row][column]);
        matrix[row][column] = MARK_AS_DONE;
        iteration--;
        row += incrementRow;
        column += incrementColumn;
    }
    private void SetDirection(ref int row, ref int column, int incrementRow, int incrementColumn, bool[] direction, int currentDirection)
    {
        row += incrementRow;
        column += incrementColumn;
        direction[currentDirection++] = false;
        if (currentDirection >= 4) direction[0] = true;
        else direction[currentDirection] = true;
    }
}
/// <explanation>
/// Just try to read in Spiral fashion. :( 
/// </explanation>
