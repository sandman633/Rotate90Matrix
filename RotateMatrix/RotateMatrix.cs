using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateMatrix
{
    public class RotateMatrix
    {
        public readonly int[,] matrix = new int[,]
        {
            { 1, 4, 0, 5, 9 },
            { 2, 7, 3, 4, 1 },
            { 0, 3, 8, 1, 0 },
            { 3, 2, 9, 5, 3 },
            { 6, 4, 0, 1, 7 },
        };
        public event Action<string> printMessage;


        public void Rotate(int[,] matrix)
        {
            var n = matrix.GetLength(0);
            for (int layer = 0; layer < n / 2; layer++)
            {
                var first = layer;
                var last = n - 1 - layer;
                for (int i = first; i < last; i++)
                {
                    var offset = i - first;
                    var upLeft = matrix[first, i];
                    var downLeft = matrix[last - offset, first];
                    var downRight = matrix[last, last - offset];
                    var upRight = matrix[i, last];


                    matrix[first, i] = upRight;
                    matrix[last - offset, first] = upLeft;
                    matrix[last, last - offset] = downLeft;
                    matrix[i, last] = downRight;


                    printMessage?.Invoke(LogMatrix(matrix)); 
                    


                }

            }
        }

        public string LogMatrix(int[,] matrix)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sb.Append("[ ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append(" ");
                    sb.Append(matrix[i, j]);
                    sb.Append(" ");
                }
                sb.Append(" ]");
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
