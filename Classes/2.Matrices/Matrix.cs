using System;
using System.Text;

namespace _2.Matrices
{
    [Version(1, 6)]
    public class Matrix<T> where T : struct
    {
        private T[,] matrix;


        private readonly int rows;
        private readonly int cols;

        public Matrix(int rows, int cols)
        {
            if (rows < 0)
            {
                throw new ArgumentException("Rows shoud be positive number.");
            }

            if (cols < 0)
            {
                throw new ArgumentException("Cols shoud be positive number.");
            }

            this.rows = rows;
            this.cols = cols;

            this.matrix = new T[rows, cols];
        }

        public Matrix(T[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            this.matrix = new T[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    this.matrix[row, col] = matrix[row, col];
                }
            }

            this.rows = rows;
            this.cols = cols;
        }

        public int Rows
        {
            get { return this.rows; }
        }

        public int Cols
        {
            get { return cols; }
        }

        public T this[int row, int col]
        {
            get
            {
                this.ValidateIndexes(row, col);
                return this.matrix[row, col];
            }
            set
            {
                this.ValidateIndexes(row, col);
                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new ArithmeticException("Matrix dimensions shoud be the same.");
            }

            int rows = m1.Rows;
            int cols = m1.Cols;

            var result = new Matrix<T>(rows, cols);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    result[row, col] = (dynamic)m1[row, col] + (dynamic)m2[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new ArithmeticException("Matrix dimensions shoud be the same.");
            }

            int rows = m1.Rows;
            int cols = m1.Cols;

            var result = new Matrix<T>(rows, cols);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    result[row, col] = (dynamic)m1[row, col] - (dynamic)m2[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            int firstMatrixRows = firstMatrix.Rows;
            int firstMatrixCols = firstMatrix.Cols;

            int secondMatrixRows = secondMatrix.Rows;
            int secondMatrixCols = secondMatrix.Cols;

            if (firstMatrixCols != secondMatrixRows)
            {
                throw new ArithmeticException("Matrices cannot be multiplied.");
            }

            var resultMatrix = new Matrix<T>(firstMatrixRows, secondMatrixCols);

            for (int i = 0; i < firstMatrixRows; i++)
            {
                for (int j = 0; j < secondMatrixCols; j++)
                {
                    for (int k = 0; k < firstMatrixCols; k++)
                    {
                        resultMatrix[i, j] += (dynamic)firstMatrix[i, k] * (dynamic)secondMatrix[k, j];
                    }
                }
            }

            return resultMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            int rows = matrix.Rows;
            int cols = matrix.Cols;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if ((dynamic)matrix[row, col] != 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {

            int rows = matrix.Rows;
            int cols = matrix.Cols;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if ((dynamic)matrix[row, col] != 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    result.Append(this.matrix[row, col] + " ");
                }
                result.Append(Environment.NewLine);
            }

            return result.ToString().Trim();
        }

        private void ValidateIndexes(int row, int col)
        {
            if (row < 0 || row >= this.Rows)
            {
                throw new IndexOutOfRangeException("Given row index is out of range.");
            }
            if (col < 0 || col >= this.Cols)
            {
                throw new IndexOutOfRangeException("Given col index is out of range.");
            }
        }
    }
}