using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ProzorovaEvgeniaOOP
{
    public class Matrix
    {
        private int row, col;
        private double[,] coefficients;
        private double[] freeMembers;
        public int Row => row;
        public int Col => col;
        public double[,] Сoefficients => coefficients;
        public double[] FreeMembers => freeMembers;
        public Matrix(int row, int col)
        {
            this.row = row;
            this.col = col;
            this.coefficients = new double[row, col];
            this.freeMembers = new double[col];
        }
        public Matrix(double[,] elems, double[] freeMembers)
        {
            this.row = elems.GetLength(1);
            this.col = elems.GetLength(0);
            this.coefficients = elems;
            this.freeMembers = freeMembers;
        }
        public Matrix(Matrix other)
        {
            this.row = other.Row;
            this.col = other.Col;
            this.coefficients = other.Сoefficients;
            this.freeMembers = other.freeMembers;
        }
        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Col; j++)
                {
                    output += this.Сoefficients[i, j].ToString();
                    output += (j < this.Col - 1) ? $"x{i + 1}{j + 1}\t+\t" : "";
                }
                output += $"\t=\t{this.FreeMembers[i]}\n";
            }
            return output;
        }
        public double[] ZeidelMethod()
        {
            return new double[] { 1, 2, 3 };
        }
    }
}
