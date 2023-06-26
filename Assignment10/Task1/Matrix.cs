﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Matrix
    {
        public decimal[,] matrix { get; set; }
        public Matrix(int rows, int cols)
        {
            matrix = new decimal[rows, cols];
        }

        public void InputElements() 
        {
            Console.WriteLine("sheiyvanet elementebi: ");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"[{i}][{j}]:");
                    decimal number = decimal.Parse(Console.ReadLine());
                    matrix[i, j] = number;
                }
            }
        } 

        //for 2 dimentions
        public static Matrix operator + ( Matrix m1, Matrix m2 )
        {
            Matrix result = new Matrix(m1.matrix.GetLength(0), m1.matrix.GetLength(1));
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
            Matrix result = new Matrix(m1.matrix.GetLength(0), m1.matrix.GetLength(1));
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
            Matrix result = new Matrix(m1.matrix.GetLength(0), m2.matrix.GetLength(1));
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
            
            Matrix result = new Matrix(m.matrix.GetLength(0), m.matrix.GetLength(1));
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
            Matrix result = new Matrix(m.matrix.GetLength(0), m.matrix.GetLength(1));
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

        public override bool Equals(Object? obj)
        {

            return true;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result += $"{matrix[i, j]} ";
                }
                result += "\n";
            }
            return result;
        }

    }
}
