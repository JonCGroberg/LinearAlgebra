namespace LinearAlgebra;

public class Matrix
{
    private int[,] matrix { get; }
    private int Columns { get; }
    private int Rows { get; }
    private int Rank { get; }

    public Matrix(int columns, int rows)
    {
        this.Columns = columns;
        this.Rows = rows;
        this.matrix = new int[rows, columns];
        this.Rank = this.matrix.Rank;
    }

    public Matrix(int[,] matrix)
    {
        this.matrix = matrix;
        this.Rows = matrix.GetLength(0);
        this.Columns = matrix.GetLength(1);
    }

    public int[] Size()
    {
        return [Rows, Columns];
    }

    public override string ToString()
    {
        var output = $"{Rows}x{Columns} Matrix\n";
        for (var r = 0; r < Rows; r++)
        {
            for (var c = 0; c < Columns; c++)
            {
                output += $" {matrix[r,c]} ";
            }

            if (r < Rows - 1)
            {
                output += "\n";
            }
        }

        return output;
    }
}