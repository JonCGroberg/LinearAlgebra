namespace LinearAlgebra;

public class LinearAlgebra
{
    public static void Main()
    {
        var array = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        var matrix = new Matrix(array);

        Console.WriteLine(matrix);
    }
}