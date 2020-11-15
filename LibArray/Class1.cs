using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibArray
{
    public class DataGridVisualize
    {
        protected DataGridView DataGrid;


        public DataGridVisualize(DataGridView dtg)
        {
            DataGrid = dtg;
        }
        public void InitializeMatrix(int rowCount, int colCount)
        {
            DataGrid.RowCount = rowCount;
            DataGrid.ColumnCount = colCount;

        }


        public void FillWithRandom(int a = -100, int b = 100)
        {
            Random rnd = new Random();
            for (int i = 0; i < DataGrid.RowCount; i++)
            {
                for (int j = 0; j < DataGrid.ColumnCount; j++)
                {
                    //DataGrid.Rows[i].HeaderCell.Value = i.ToString();
                    //DataGrid.Columns[j].HeaderCell.Value = j.ToString();
                    //DataGrid.Columns[j].Width = 25;
                    DataGrid[j, i].Value = rnd.Next(a, b);
                }
            }
        }
        public void Trans(int[,] arr)
        {
            int[,] arr_trans = new int[arr.GetLength(1), arr.GetLength(0)];
            DataGrid.RowCount = arr.GetLength(1);
            DataGrid.ColumnCount = arr.GetLength(0);

            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    arr_trans[i, j] = arr[j, i];
                }
            }

            for (int i = 0; i < arr_trans.GetLength(0); i++)
            {
                for (int j = 0; j < arr_trans.GetLength(1); j++)
                {
                    DataGrid[j, i].Value = arr_trans[i, j];
                }
            }
        }

        public int[,] GetArray(DataGridView dataGrid)
        {
            int[,] arr = new int[dataGrid.Rows.Count, dataGrid.Columns.Count];
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                for (int j = 0; j < dataGrid.Columns.Count; j++)
                {
                    arr[i, j] = Convert.ToInt32(dataGrid[j, i].Value);
                }
            }
            return arr;
        }

        //public int MaxNumThatMoreThanOne(int [,] array)
        //{

        //}

        public int AmountOfColsWithZero(int[,] array)
        {
            int num = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i, j] == 0)
                    {
                        num++;
                        break;
                    }
                }
            }
            return num;
        }

        public int AmountOfPositiveNums(int[,] array)
        {
            int num = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                    {
                        num += 1;
                    }
                }
            }
            return num;
        }

        public int MaxRepeatingNum(int[,] array)
        {
            int[] arr_2 = new int[array.GetLength(0) * array.GetLength(1)];
            int index = 0, max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    arr_2[index] = array[i, j];
                    index++;
                }
            }
            Array.Sort(arr_2);

            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length; j++)
                {
                    if (arr_2[i] == arr_2[j] && i != j)
                    {
                        if (arr_2[i] > max) max = arr_2[i];
                    }
                }

            return max;
        }

        public int AmountOfRowsWithoutZero(int[,] array)
        {
            int num = 0, amount = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == 0)
                    {
                        num += 1;
                        break;
                    }
                }
                if (num == 0) { amount++; }
            }
            return amount;
        }

        public int RowWithBiggestAmountOfSimilarNums(int[,] array)
        {
            int[] num = new int[array.GetLength(0)];
            int row_ind = -1, k = 0, dot = 0, max = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    if (array[i, j - 1] == array[i, j])
                    {
                        num[k]++; dot = 1;
                    }
                    else if (dot == 0)
                    {
                        num[k] = 1;
                    }

                    if (array[i, j - 1] == array[i, j] && j == 1)
                    {
                        num[k]++;
                    }
                }
                k++;
                dot = 0;
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] >= max && num[i] != 1)
                {
                    max = num[i]; row_ind = i;
                }
            }

            return row_ind;
        }

        public int MultiplyRowsWithoutNegNums(int[,] array)
        {
            int[] num = new int[array.GetLength(0)];
            int mult = 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                    {
                        num[i] = 1;
                    }
                    else
                    {
                        num[i] = 0;
                        break;
                    }
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (num[i] != 0)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        mult *= array[i, j];
                    }
                }
                else { }
            }

            return mult;
        }

        public int SumColsWithoutNegNums(int[,] array)
        {
            int[] num = new int[array.GetLength(1)];
            int sum = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i, j] > 0)
                    {
                        num[j] = 1;
                    }
                    else
                    {
                        num[j] = 0;
                        break;
                    }
                }
            }

            for (int i = 0; i < array.GetLength(1); i++)
            {
                if (num[i] != 0)
                {
                    for (int j = 0; j < array.GetLength(0); j++)
                    {
                        sum += array[j, i];
                    }
                }
                else {}
            }

            return sum;
        }

        public int MaxDiagonalSum(int[,] array)
        {

            int sum_diag = 0;
            int max = -100;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == array.GetLength(0) - j - 1)
                    {
                        sum_diag += array[i, j]; //сумма элементов побочной диагонали
                    }
                }
                if (sum_diag > max)
                {
                    max = sum_diag;//поиск максимального значения среди элементов массива
                }
            }

            return max;
        }

        public int MinDiagonalSum(int[,] array)
        {
            int[,] revertArr = new int[array.GetLength(0), array.GetLength(1)];
            int minSum_up = array[0, 0], minSum_down = array[0,0], sum_up = 0, sum_down = 0,
                min, step_a = 0, step = 1;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    revertArr[i, j] = array[array.GetLength(0) - 1 - step_a, j];
                    step_a++;
                }
                step_a = 0;
            }

            while (step <= array.GetLength(0) && step <= array.GetLength(1))
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (i + step == j)
                        {
                            sum_up += Math.Abs(revertArr[i, j]);
                        }
                    }
                }
                if (sum_up < minSum_up && sum_up != 0) minSum_up = sum_up;
                sum_up = 0;


                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (i - step == j)
                        {
                            sum_down += Math.Abs(revertArr[i, j]);
                        }
                    }
                }
                if (sum_down < minSum_down && sum_down != 0) minSum_down = sum_down;
                sum_down = 0;
                step++;
            }
            if (minSum_down < minSum_up)
            {
                min = minSum_down;
            }
            else
            {
                min = minSum_up;
            }

            return min;
        }


        public int SumColsWithNegNums(int[,] array)
        {
            int[] num = new int[array.GetLength(1)];
            int sum = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    if (array[i, j] < 0)
                    {
                        num[j] = 1;
                        break;
                    }
                    else
                    {
                        num[j] = 0;
                    }
                }
            }

            for (int i = 0; i < array.GetLength(1); i++)
            {
                if (num[i] != 0)
                {
                    for (int j = 0; j < array.GetLength(0); j++)
                    {
                        sum += array[j, i];
                    }
                }
                else { }
            }

            return sum;
        }


    }
}
