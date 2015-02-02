namespace SomeExercises
{
    using System;

    public class Matrix<T>
    {
        private T[,] matrix;
        private static int Row = 0;
        private static int Col = 0;

        public Matrix()
        {
        }

        public Matrix(int row, int col)
        {
            this.matrix = new T[row, col];
            Row = row;
            Col = col;
        }

        public T this[int row, int col]
        {
            get {return matrix[row, col]; }
            set { matrix[row, col] = value; }
        }

        public int GetRow
        {
            get { return Row; }
        }

        public int GetCol
        {
            get { return Col; }
        }

        public static Matrix<T> operator +(Matrix<T> m1,Matrix<T> m2)
        {
            if (m1.GetRow != m2.GetRow || m1.GetCol != m2.GetCol)
            {
                throw new ArgumentException("The rows and cols of the both matrixes must be equals!");
            }
            else
            {
                Matrix<T> result = new Matrix<T>(m1.GetRow, m1.GetCol);

                for (int i = 0; i < m1.GetRow; i++)
                {
                    for (int j = 0; j < m1.GetCol; j++)
                    {
                        result[i, j] = (dynamic)m1[i, j] + (dynamic)m2[i, j];
                    }
                }

                return result;
            }
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.GetRow != m2.GetRow || m1.GetCol != m2.GetCol)
            {
                throw new ArgumentException("The rows and cols of the both matrixes must be equals!");
            }
            else
            {
                Matrix<T> result = new Matrix<T>(m1.GetRow, m1.GetCol);

                for (int i = 0; i < m1.GetRow; i++)
                {
                    for (int j = 0; j < m1.GetCol; j++)
                    {
                        result[i, j] = (dynamic)m1[i, j] - (dynamic)m2[i, j];
                    }
                }

                return result;
            }
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.GetRow != m2.GetRow || m1.GetCol != m2.GetCol)
            {
                throw new ArgumentException("The rows and cols of the both matrixes must be equals!");
            }
            else
            {
                Matrix<T> result = new Matrix<T>(m1.GetRow, m1.GetCol);

                for (int i = 0; i < m1.GetRow; i++)
                {
                    for (int j = 0; j < m1.GetCol; j++)
                    {
                        result[i, j] = (dynamic)m1[i, j] * (dynamic)m2[i, j];
                    }
                }

                return result;
            }
        }

        //TODO: Implement true operator
    }
}
