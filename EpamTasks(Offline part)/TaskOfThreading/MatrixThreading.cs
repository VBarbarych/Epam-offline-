using LibraryOfInterfacesAndClasses.AdditionalInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskOfThreading
{
    class MatrixThreading
    {
        private IWriteReadable writeReadOfData;

        private const int row = 1000;
        private const int col = 1000;

        private int[,] matrix;


        public MatrixThreading(IWriteReadable writeReadOfData)
        {
            this.writeReadOfData = writeReadOfData;
        }

        public void RandomMatrix()
        {
            matrix = new int[row, col];
            Random random = new Random();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = random.Next(1, 50);
                }
            }
        }

        public void AsyncSumOfMatrix()
        {
            const int countOfThreads = 4;
            int colThread = col / countOfThreads;
            int sumElementOfMatrix = 0;
            var partialSums = new int[countOfThreads];
            

            Parallel.For(0, 4, (counter) =>
            {
                int sum = 0;

                for (int i = 0; i < row; i++)
                {
                    for (int j = counter * colThread; j < colThread * (counter + 1); j++)
                    {
                        sum += matrix[i, j];
                    }
                }

                partialSums[counter] = sum;
            });

            foreach (var sum in partialSums)
                sumElementOfMatrix += sum;

            writeReadOfData.Write($"Sum element of Matrix {sumElementOfMatrix}");
        }
    }
}
