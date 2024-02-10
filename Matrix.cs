using System.Runtime.CompilerServices;

namespace LinearAlgebra;

public class Matrix
{
    private readonly int[,] _matrix;
    public int Columns { get; }
    public int Rows { get; }
    public int Rank { get; }

    public Matrix(int columns, int rows)
    {
        Rows = rows;
        Columns = columns;
        _matrix = new int[rows, columns];
        Rank = _matrix.Rank;
    }

    public Matrix(int[,] matrix)
    {
        Rows = matrix.GetLength(0);
        Columns = matrix.GetLength(1);
        _matrix = matrix;
        Rank = _matrix.Rank;
    }

    public (int, int) Size()
    {
        return (Rows, Columns);
    }

    // Backward Phase
    public Matrix ToRowReducedEchelonForm()
    {
        Matrix echelonFormMatrix;
        
        // Forward Phase (First convert to echelon form)
        echelonFormMatrix = new Matrix(_matrix).ToEchelonForm();
        
        // Backward Phase
        // 5. Starting at the rightmost pivot, create 0’s above each pivot.
        // 6. Scale the row so the pivot becomes 1
        // 7. Repeat 5-6 for the next pivots until there are no more pivots to modify.
        return new Matrix(_matrix);
    }

    // Forward Phase
    public static void EchelonForm()
    {
    }

    public Matrix ToEchelonForm()
    {
        // 1. Find the leftmost non-zero column, this is the **pivot column**
        // 2. Select the **pivot** in the pivot column, swap any non zero row to the top to create a pivot, or do nothing if there exists a pivot already.
        // 3. Use **row replacement** to make the positions underneath the pivot 0’s
        // 4. This row is now complete! Repeat steps 1-4 to the sub-matrix consisting of the rest of the rows until there are no more non-zero rows left to modify
        return new Matrix(_matrix);
    }

    public override string ToString()
    {
        var output = $"{Rows}x{Columns} Matrix"; // Header
        for (var r = 0; r < Rows; r++) // Rows 
        {
            output += "\n";
            for (var c = 0; c < Columns; c++)
            {
                output += $" {_matrix[r, c]} ";
            }
        }

        return output;
    }
}