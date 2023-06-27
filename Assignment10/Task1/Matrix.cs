using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//1) შევქმნათ 2x2 -ზე მატრიცა, რომლის ინიციალიზაციას მოვახდენთ კონსოლიდან.
//2) გავაკეთოთ implicit დაკასტვა სკალარულ მნიშვნელობაზე (მაგალითად: double, int).
//3) გადავტვირთოთ მატრიცების შეკრების და გამოკლების ოპერაციები (ბინარული).
//4) გადავტვირთოთ მატრიცების გამრავლების ოპერაცია (ბინარული).
//5) გადავტვირთოთ უნარული გამოკლება (-), რომელიც მოახდენს მატრიცის შებრუნებას.
//6) მოახდინეთ Equals-ის და ToString-ის გადაფარვა (override).

namespace Task1
{
    public class Matrix
    {
        public decimal[,] matrix { get; set; }
        public Matrix()
        {
            matrix = new decimal[2, 2];
        }

        public void InputElements() 
        {
            Console.WriteLine("sheiyvanet elementebi: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    while (true) {
                        Console.Write($"[{i},{j}]:");
                        try
                        {
                            decimal number = decimal.Parse(Console.ReadLine());
                            matrix[i, j] = number;
                            break;
                        }
                        catch 
                        {
                            Console.WriteLine("sheiyvanet mxolod ricxviti mnishneloba: ");
                        }
                    }
                }
            }
        } 

        public static implicit operator Matrix(decimal d)
        {
            Matrix result = new Matrix();
            for (int i = 0; i < result.matrix.GetLength(0); i++)
            {
                for(int j = 0;j < result.matrix.GetLength(1); j++)
                {
                    result.matrix[i, j] = d;
                }
            }
            return result;
        }

        //for 2 dimentions
        public static Matrix operator + ( Matrix m1, Matrix m2 )
        {
            Matrix result = new Matrix();
            for (int row = 0; row < m1.matrix.GetLength(0); row++)
            {
                for(int col = 0; col < m1.matrix.GetLength(1); col++)
                {
                    result.matrix[row, col] = m1.matrix[row, col] + m2.matrix[row,col];
                }
            }
            return result;
        }

        public static Matrix operator - (Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix();
            for (int row = 0; row < m1.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < m1.matrix.GetLength(1); col++)
                {
                    result.matrix[row, col] = m1.matrix[row, col] - m2.matrix[row, col];
                }
            }
            return result;
        }
        public static Matrix operator * (Matrix m1, Matrix m2)
        {
            decimal temp = 0;
            Matrix result = new Matrix();
            for (int i = 0; i < m1.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < m2.matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < m1.matrix.GetLength(1); k++)
                    {
                        temp += m1.matrix[i, k] * m2.matrix[k, j];
                        //Console.WriteLine($"{m1.matrix[i, k]} * {m2.matrix[k, j]}  [{i},{j},{k}]");
                    }
                    result.matrix[i, j] = temp;
                    temp = 0;
                }
            }
            return result;
        }
        public static Matrix operator *(Matrix m, decimal temp)
        {
            
            Matrix result = new Matrix();
            for (int i = 0; i < m.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < m.matrix.GetLength(1); j++)
                {
                    result.matrix[i, j] = temp * m.matrix[i, j];
                }
            }
            return result;
        }

        public static Matrix operator -(Matrix m)
        {
            Matrix result = new Matrix();
            decimal det;
            det = m.matrix[0, 0] * m.matrix[1, 1] - m.matrix[0, 1] * m.matrix[1, 0];
            //Console.WriteLine("det: " + det);

            result.matrix[0, 0] = m.matrix[1, 1];
            result.matrix[0, 1] = -(m.matrix[0, 1]);
            result.matrix[1, 0] = -(m.matrix[1, 0]);
            result.matrix[1, 1] = m.matrix[0, 0];
            //Console.Write(result.matrix[0, 0] + " ");
            //Console.WriteLine(result.matrix[0, 1]);
            //Console.Write(result.matrix[1, 0] + " ");
            //Console.WriteLine(result.matrix[1, 1]);

            result = result * (1/det); 

            return result;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // DownCast
            Matrix matrix2 = (Matrix)obj;
            if(matrix2.matrix.GetLength(0) != matrix.GetLength(0) || matrix2.matrix.GetLength(1) != matrix.GetLength(1))
            { 
                return false; 
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != matrix2.matrix[i, j]) { return false; }
                }
            }

            return true;
        }

        public override string ToString()
        {
            string result = "\n";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                result += "|\t";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result += $"{matrix[i, j]}\t";
                }
                result += "|\n";
            }
            return result;
        }

    }
}
