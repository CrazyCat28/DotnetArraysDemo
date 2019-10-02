using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] table = new int[11][];
            //Цикл создания строк
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = new int[11];
                //Цикл создания значений в текущей строке
                for (int j = 0; j < table[i].Length; j++)
                {
                    //Когда номер строки i - 0 - сохраняем номер столбца
                    if (i == 0)
                    {
                        //Обращаемся к строке i, столбцу j
                        //и сохраняем туда (в текущую ячейку) вычисленное значение
                        table[i][j] = j;
                        //Когда номер столбца j - 0 - сохраняем номер строки
                    }
                    else if (j == 0)
                    {
                        table[i][j] = i;
                        //Иначе сохраняем перемножение номера строки и столбца
                    }
                    else
                    {
                        table[i][j] = i * j;
                    }
                }
            }

            //Проверка вывода всех значений из двумерного массива
            //(массива ссылок на массивы целых значений)
            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 0; j < table[i].Length; j++)
                {
                    Console.Write($"{table[i][j], -4}");
                }
                //Перенос на следующую строку
                Console.WriteLine();
            }
        }
    }
}
