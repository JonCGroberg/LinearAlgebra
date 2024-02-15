namespace LinearAlgebra;

public class LinearAlgebra
{
    public static void Main()
    {
        int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Matrix matrix1 = new Matrix(array);

        Console.WriteLine(matrix1);
        Console.WriteLine("Size: " + matrix1.Size());
        Console.WriteLine("Rank: " + matrix1.Rank);
        Console.WriteLine(matrix1.ToRowReducedEchelonForm());
    }
}