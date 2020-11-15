using LibArray;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISMDotNet5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_accept_Click(object sender, EventArgs e)
        {

            DataGridVisualize dtg_obj = new DataGridVisualize(dtg_Matrix);
            dtg_obj.InitializeMatrix(Convert.ToInt32(num_N.Value), Convert.ToInt32(num_M.Value));

            int[,] array = dtg_obj.GetArray(dtg_Matrix);
            lb_AmountOfColsWithZero.Text = dtg_obj.AmountOfColsWithZero(array).ToString();
            lb_AmountOfPositiveNums.Text = dtg_obj.AmountOfPositiveNums(array).ToString();
            lb_MaxRepeatingNum.Text = dtg_obj.MaxRepeatingNum(array).ToString();
            lb_AmountOfRowsWithoutZero.Text = dtg_obj.AmountOfRowsWithoutZero(array).ToString();
            lb_RowWithBiggestAmountOfSimilarNums.Text = dtg_obj.RowWithBiggestAmountOfSimilarNums(array).ToString();
            lb_MultiplyRowsWithoutNegNums.Text = dtg_obj.MultiplyRowsWithoutNegNums(array).ToString();
            lb_SumColsWithoutNegNums.Text = dtg_obj.SumColsWithoutNegNums(array).ToString();
            lb_MaxDiagonalSum.Text = dtg_obj.MaxDiagonalSum(array).ToString();
            lb_MinDiagonalSum.Text = dtg_obj.MinDiagonalSum(array).ToString();
            lb_SumColsWithNegNums.Text = dtg_obj.SumColsWithNegNums(array).ToString();

        }

        private void num_N_ValueChanged(object sender, EventArgs e)
        {

        }

        private void b_Random_Click(object sender, EventArgs e)
        {
            DataGridVisualize dtg_obj = new DataGridVisualize(dtg_Matrix);
            dtg_obj.InitializeMatrix(Convert.ToInt32(num_N.Value), Convert.ToInt32(num_M.Value));
            dtg_obj.FillWithRandom(-10,10);
        }

        private void b_Trans_Click(object sender, EventArgs e)
        {
            DataGridVisualize dtg_obj = new DataGridVisualize(dtg_Matrix);
            dtg_obj.InitializeMatrix(Convert.ToInt32(num_N.Value), Convert.ToInt32(num_M.Value));
            int[,] array = dtg_obj.GetArray(dtg_Matrix);
            dtg_obj.Trans(array);
        }
    }
}
