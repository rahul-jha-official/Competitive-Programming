/// <description>
/// Given an m x n integer matrix matrix, if an element is 0, set its entire row and column to 0's.
/// You must do it in place.
/// 
/// Example 1:
/// Input: matrix = [[1,1,1],[1,0,1],[1,1,1]]
/// Output: [[1,0,1],[0,0,0],[1,0,1]]
/// 
/// Example 2:
/// Input: matrix = [[0,1,2,0],[3,4,5,2],[1,3,1,5]]
/// Output: [[0,0,0,0],[0,4,5,0],[0,3,1,0]]
/// 
/// Constraints:
/// m == matrix.length
/// n == matrix[0].length
/// 1 <= m, n <= 200
/// -231 <= matrix[i][j] <= 231 - 1
/// </description>
public class SetMatrixZeroesSolution
{
    public void SetZeroes(int[][] matrix)
    {
        var replica = new bool[matrix.Length][];
        for (int i = 0; i < matrix.Length; i++)
        {
            replica[i] = new bool[matrix[i].Length];
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    for (int k = 0; k < matrix[i].Length; k++)
                    {
                        replica[i][k] = true;
                    }

                    for (int k = 0; k < matrix.Length; k++)
                    {
                        replica[k][j] = true;
                    }
                }
            }
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (replica[i][j])
                {
                    matrix[i][j] = 0;
                }
            }
        }
    }
}

/// <explanation>
/// Above solution is brute force solution.
/// Create an bool matrix of same size as input.
/// Traverse the matrix and if position is 0 and change row and column of bool matrix as true.
/// Finally change the original matrix where bool matrix is true.
/// </explanation>
